namespace UFIDA.U9.Cust.JSDY.BarCode
{
    using System;
    using System.Collections.Generic;
    using UFSoft.UBF.AopFrame;
    using UFIDA.U9.SM.SO;
    using UFIDA.U9.SM.ShipPlan;
    using UFIDA.U9.Base.Profile;
    using UFIDA.U9.CBO.SCM.Warehouse;
    using UFIDA.U9.InvDoc.TransferOut;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Lot;
    using UFIDA.U9.Cust.JSDY.BarCodeSV.BarCodeSV;
using UFIDA.U9.Base.Organization;

    /// <summary>
    /// GenProductBarCodesByShip partial 
    /// </summary>	
    public partial class GenProductBarCodesByShip
    {
        internal BaseStrategy Select()
        {
            return new GenProductBarCodesByShipImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GenProductBarCodesByShipImpementStrategy : BaseStrategy
    {
        public GenProductBarCodesByShipImpementStrategy() { }

        private Dictionary<string, Warehouse> whDict = new Dictionary<string, Warehouse>();

        public override object Do(object obj)
        {
            GenProductBarCodesByShip bpObj = (GenProductBarCodesByShip)obj;
            if (bpObj.ProductBarCodeDTOs == null || bpObj.ProductBarCodeDTOs.Count == 0) return null;

            //销售订单转调出单
            SOToTransOutBP soToTransOut = new SOToTransOutBP();
            soToTransOut.SOToTransOutDTOs = CreateSOToTransOutDTOs(bpObj.ProductBarCodeDTOs);
            soToTransOut.SplitMergeRule = new List<string>();
            List<SOToTransOutResultDTO> resultDTOs = soToTransOut.Do();
            if (resultDTOs == null || resultDTOs.Count == 0) return null;

            using (Session s = Session.Open())
            {
                List<ProductBarCodeByShipDTO> barCodeDTOs = new List<ProductBarCodeByShipDTO>(bpObj.ProductBarCodeDTOs);

                foreach (SOToTransOutResultDTO resultDTO in resultDTOs)
                {
                    TransferOut transferOut = new TransferOut.EntityKey(resultDTO.TransOut).GetEntity();
                    foreach (TransOutLine transOutline in transferOut.TransOutLines)
                    {
                        ProductBarCodeByShipDTO barCodeDTO = FindProductBarCodeDTO(barCodeDTOs, transOutline);
                        barCodeDTOs.Remove(barCodeDTO);
                        //生成批号数据
                        LotMaster.EntityKey lotKey = LotBuilder.CreateLot(transOutline.ItemInfo.ItemID, barCodeDTO.BarCode, barCodeDTO.ActualLength);
                        //设置调出行批号
                        SetTransOutLineLotInfo(transOutline, lotKey);
                        //记录来源关系
                        ShipPlanLine shipPlanline = ShipPlanLine.Finder.FindByID(barCodeDTO.ShipPlanLine);
                        transOutline.DescFlexSegments.PrivateDescSeg3 = shipPlanline.ID.ToString();//来源出货计划行ID
                        transOutline.DescFlexSegments.PrivateDescSeg4 = shipPlanline.ShipPlan.DocNo;  //来源出货计划单号
                        transOutline.DescFlexSegments.PrivateDescSeg5 = shipPlanline.DocLineNo.ToString();  //来源出货计划行号

                        //生成成品条码记录
                        ProductBarCode productBarCode = ProductBarCode.Create();
                        productBarCode.OrgKey = new Base.Organization.Organization.EntityKey(barCodeDTO.OrgID);
                        productBarCode.BarCode = barCodeDTO.BarCode;
                        productBarCode.ActualLength = barCodeDTO.ActualLength;
                        productBarCode.ItemKey = transOutline.ItemInfo.ItemIDKey;
                        productBarCode.LotKey = lotKey;
                        productBarCode.OperatorsKey = new CBO.HR.Operator.Operators.EntityKey(barCodeDTO.QcOperator);
                        productBarCode.ScanBy = barCodeDTO.ScanBy;
                        productBarCode.ScanOn = DateTime.Now; // barCodeDTO.ScanOn;

                        productBarCode.ShipPlanKey = new ShipPlan.EntityKey(barCodeDTO.ShipPlan);
                        productBarCode.ShipPlanLineKey = new ShipPlanLine.EntityKey(barCodeDTO.ShipPlanLine);
                        productBarCode.TransferOutKey = transOutline.TransferOutKey;
                        productBarCode.TransferOutLineKey = transOutline.Key;
                        productBarCode.ProductBarCodeKind = ProductBarCodeKindEnum.Ship;
                    }
                }
                s.Commit();
            }

            return null;
        }

        private void SetTransOutLineLotInfo(TransOutLine transOutLine, LotMaster.EntityKey lotKey)
        {
            if (lotKey == null) return;
            LotMaster lotMaster = lotKey.GetEntity();

            transOutLine.LotInfo = new LotMasterInfo();
            transOutLine.LotInfo.DisabledDatetime = lotMaster.InvalidTime;
            transOutLine.LotInfo.LotCode = lotMaster.LotCode;
            transOutLine.LotInfo.LotMaster = lotMaster;
            transOutLine.LotInfo.LotValidDate = lotMaster.ValidDate;

        }

        private ProductBarCodeByShipDTO FindProductBarCodeDTO(List<ProductBarCodeByShipDTO> barCodeDTOs, TransOutLine transOutline)
        {
            foreach (ProductBarCodeByShipDTO barCodeDTO in barCodeDTOs)
            {
                if (barCodeDTO.SOShipLine == transOutline.SrcDocInfo.SrcDocSubLine.EntityID && barCodeDTO.ActualLength == (int)(transOutline.StoreUOMQty*1000))
                    return barCodeDTO;
            }

            throw new Exception(string.Format("没有找到调出单{0}行{1}对应的DTO数据", transOutline.TransferOut.DocNo, transOutline.DocLineNo));
        }

        private Warehouse GetWarehouse(Organization.EntityKey orgKey, string whCode)
        {
            string key = orgKey.ID.ToString() + "-" + whCode;
            if (whDict.ContainsKey(key)) return whDict[key];
            Warehouse wh = Warehouse.FindByCode(orgKey.GetEntity(), whCode);
            whDict.Add(key, wh);
            return wh;
        }

        private List<SOToTransOutDTO> CreateSOToTransOutDTOs(List<ProductBarCodeByShipDTO> barCodeDTOs)
        {
            List<SOToTransOutDTO> transOutDTOs = new List<SOToTransOutDTO>();
            foreach (ProductBarCodeByShipDTO barCodeDTO in barCodeDTOs)
            {
                ShipPlanLine shipPlanLine = ShipPlanLine.Finder.FindByID(barCodeDTO.ShipPlanLine);
                if (shipPlanLine == null)
                    throw new Exception(string.Format("出货计划行实体({0})已经被删除异常", barCodeDTO.ShipPlanLine));
                if (shipPlanLine.WHKey == null)
                    throw new Exception(string.Format("出货计划{0}行号{1}存储地点为空，不允许出货！", shipPlanLine.ShipPlan.DocNo, shipPlanLine.DocLineNo));
                string virtualTransInWhCode = shipPlanLine.DescFlexField.PubDescSeg4;
                if (string.IsNullOrEmpty(virtualTransInWhCode))
                    throw new Exception(string.Format("出货计划{0}行号{1}调入仓为空，不允许出货！", shipPlanLine.ShipPlan.DocNo, shipPlanLine.DocLineNo));

                Warehouse virtualTransInWh = GetWarehouse(shipPlanLine.OrgKey, virtualTransInWhCode);
                if (shipPlanLine.WHKey.ID == virtualTransInWh.ID)
                    throw new Exception(string.Format("出货计划{0}行号{1}存储地点{2}与调入仓相同，不允许出货！", shipPlanLine.ShipPlan.DocNo, shipPlanLine.DocLineNo, shipPlanLine.WH.Name));

                //记录barCodeDTO对应的销售订单子行ID，后面需要用到
                barCodeDTO.SOShipLine = shipPlanLine.SrcDocSubLine;

                SOToTransOutDTO transOutDTO = new SOToTransOutDTO();
                transOutDTO.SOShiplineKey = barCodeDTO.SOShipLine;
                transOutDTO.SubSOToTransOutDTOs = new List<SubSOToTransOutDTO>();
                SubSOToTransOutDTO subDTO = new SubSOToTransOutDTO();
                subDTO.TransInOrg = barCodeDTO.OrgID;
                subDTO.TransInWh = virtualTransInWh.ID;
                subDTO.TransOutBusDate = Base.Context.LoginDate;
                subDTO.TransOutOrg = barCodeDTO.OrgID;
                subDTO.TransOutQty1 = (decimal)(barCodeDTO.ActualLength/1000.0);
                subDTO.TransOutWh = shipPlanLine.WHKey.ID;
                transOutDTO.SubSOToTransOutDTOs.Add(subDTO);
                transOutDTOs.Add(transOutDTO);
            }
            return transOutDTOs;
        }
    }

    #endregion


}
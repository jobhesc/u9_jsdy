namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
    using UFSoft.UBF.AopFrame;
    using UFIDA.U9.PM.Rcv;
    using UFIDA.U9.PM.DTOs;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.JSDY.BarCodeSV.BarCodeSV;
    using UFIDA.U9.Lot;
using UFIDA.U9.SM.RMA;
    using UFIDA.U9.SM.RMA.Proxy;
    using UFIDA.U9.PM.Rcv.Proxy;

	/// <summary>
	/// GenProductBarCodesByRMA partial 
	/// </summary>	
	public partial class GenProductBarCodesByRMA 
	{	
		internal BaseStrategy Select()
		{
			return new GenProductBarCodesByRMAImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class GenProductBarCodesByRMAImpementStrategy : BaseStrategy
	{
		public GenProductBarCodesByRMAImpementStrategy() { }

		public override object Do(object obj)
		{						
			GenProductBarCodesByRMA bpObj = (GenProductBarCodesByRMA)obj;
            if (bpObj.ProductBarCodeDTOs == null || bpObj.ProductBarCodeDTOs.Count == 0) return null;

            //生成销售退回收货单
            CreateReceivementProxy createRcv = new CreateReceivementProxy();
            createRcv.RcvHeadDTOs = CreateRcvHeadDTOs(bpObj.ProductBarCodeDTOs);
            List<BusinessEntity.EntityKey> resultKeys = createRcv.Do();
            if (resultKeys == null || resultKeys.Count == 0) return null;

            using (Session s = Session.Open())
            {
                List<ProductBarCodeByRMADTO> barCodeDTOs = new List<ProductBarCodeByRMADTO>(bpObj.ProductBarCodeDTOs);

                foreach (BusinessEntity.EntityKey resultKey in resultKeys)
                {
                    Receivement rcv = new Receivement.EntityKey(resultKey.ID).GetEntity();
                    foreach (RcvLine rcvLine in rcv.RcvLines)
                    {
                        ProductBarCodeByRMADTO barCodeDTO = FindProductBarCodeDTO(barCodeDTOs, rcvLine);
                        barCodeDTOs.Remove(barCodeDTO);
                        //生成批号数据
                        LotMaster.EntityKey lotKey = LotBuilder.CreateLot(rcvLine.ItemInfo.ItemID, barCodeDTO.BarCode, barCodeDTO.ActualLength);
                        //设置收货行批号
                        SetRcvLineLotInfo(rcvLine, lotKey);
                        //生成成品条码记录
                        ProductBarCode productBarCode = ProductBarCode.Create();
                        productBarCode.OrgKey = new Base.Organization.Organization.EntityKey(barCodeDTO.OrgID);
                        productBarCode.BarCode = barCodeDTO.BarCode;
                        productBarCode.ActualLength = barCodeDTO.ActualLength;
                        productBarCode.ItemKey = rcvLine.ItemInfo.ItemIDKey;
                        productBarCode.LotKey = lotKey;
                        productBarCode.OperatorsKey = new CBO.HR.Operator.Operators.EntityKey(barCodeDTO.QcOperator); 

                        productBarCode.RMAKey = new SM.RMA.RMA.EntityKey(barCodeDTO.RMA);
                        productBarCode.RMALineKey = new SM.RMA.RMALine.EntityKey(barCodeDTO.RMALine);
                        productBarCode.ReceivementKey = rcvLine.ReceivementKey;
                        productBarCode.RcvLineKey = rcvLine.Key;
                        productBarCode.ProductBarCodeKind = ProductBarCodeKindEnum.RMR;

                    }
                }
                s.Commit();
            }
            return null;
		}

        private void SetRcvLineLotInfo(RcvLine rcvLine, LotMaster.EntityKey lotKey)
        {
            if (lotKey == null) return;
            LotMaster lotMaster = lotKey.GetEntity();
            //rcvLine.RcvLotKey = lotKey;
            //rcvLine.RcvLotCode = lotMaster.LotCode;

            rcvLine.InvLotKey = lotKey;
            rcvLine.InvLotCode = lotMaster.LotCode;
            rcvLine.InvLotEnableDate = lotMaster.EffectiveDatetime;
            rcvLine.InvLotValidDate = lotMaster.ValidDate;

        }

        private ProductBarCodeByRMADTO FindProductBarCodeDTO(List<ProductBarCodeByRMADTO> barCodeDTOs, RcvLine rcvLine)
        {
            foreach (ProductBarCodeByRMADTO barCodeDTO in barCodeDTOs)
            {
                if (barCodeDTO.RMALine == rcvLine.SrcDoc.SrcDocLine.EntityID && barCodeDTO.ActualLength == (int)(rcvLine.RcvQtyTU*1000))
                    return barCodeDTO;
            }

            throw new Exception(string.Format("没有找到销售退回收货单{0}行{1}对应的DTO数据", rcvLine.Receivement.DocNo, rcvLine.DocLineNo));
        }

        private List<RcvHeadDTOData> CreateRcvHeadDTOs(List<ProductBarCodeByRMADTO> barCodeDTOs)
        {
            RcvHeadDTOData rcvHeadDTO = null;
            foreach (ProductBarCodeByRMADTO barCodeDTO in barCodeDTOs)
            {
                RMAToRcvProxy toRcv = new RMAToRcvProxy();
                toRcv.SplitTerms = new List<string>();
                toRcv.RmaLines = new List<RmaTransformParaDTOData>();

                RmaTransformParaDTOData paraDTO = new RmaTransformParaDTOData();
                paraDTO.ArriveTime = Base.Context.LoginDateTime;
                paraDTO.RmaLine = barCodeDTO.RMALine;
                paraDTO.TransformDate = Base.Context.LoginDate;
                paraDTO.TransformQty = new CBO.DTOs.DoubleQuantityData();
                paraDTO.TransformQty.Amount1 = (decimal)(barCodeDTO.ActualLength/1000.0);
                toRcv.RmaLines.Add(paraDTO);
                RcvFromRMADTOData resultDTO = toRcv.Do(); 
                if (resultDTO != null && resultDTO.RcvHeadDatas != null)
                {
                    List<RcvHeadDTOData> rcvHeadDTODatas = resultDTO.RcvHeadDatas as List<RcvHeadDTOData>;

                    if (rcvHeadDTO == null)
                        rcvHeadDTO = rcvHeadDTODatas[0];
                    else
                    {
                        rcvHeadDTO.RcvLineDTOs.AddRange(rcvHeadDTODatas[0].RcvLineDTOs);
                    }
                }
            }

            List<RcvHeadDTOData> rcvHeadDTOs = new List<RcvHeadDTOData>();
            rcvHeadDTOs.Add(rcvHeadDTO);
            return rcvHeadDTOs;
        }

        private Dictionary<long, List<RmaTransformParaDTOData>> SplitRMALines(List<ProductBarCodeByRMADTO> barCodeDTOs)
        {
            Dictionary<long, List<RmaTransformParaDTOData>> dict = new Dictionary<long, List<RmaTransformParaDTOData>>();
            foreach (ProductBarCodeByRMADTO barCodeDTO in barCodeDTOs)
            {
                if (!dict.ContainsKey(barCodeDTO.RMALine))
                    dict.Add(barCodeDTO.RMALine, new List<RmaTransformParaDTOData>());

                RmaTransformParaDTOData paraDTO = new RmaTransformParaDTOData();
                paraDTO.ArriveTime = Base.Context.LoginDateTime;
                paraDTO.RmaLine = barCodeDTO.RMALine;
                paraDTO.TransformDate = Base.Context.LoginDate;
                paraDTO.TransformQty = new CBO.DTOs.DoubleQuantityData();
                paraDTO.TransformQty.Amount1 = barCodeDTO.ActualLength;

                dict[barCodeDTO.RMALine].Add(paraDTO);
            }
            return dict;
        }
	}

	#endregion
	
	
}
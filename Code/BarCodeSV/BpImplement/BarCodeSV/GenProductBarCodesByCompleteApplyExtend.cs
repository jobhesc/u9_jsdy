namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
    using UFSoft.UBF.AopFrame;
    using UFIDA.U9.Complete.CompleteRpt;
    using UFIDA.U9.Complete.RCVRpt;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.JSDY.BarCodeSV.BarCodeSV;
    using UFIDA.U9.Lot;
    using UFIDA.U9.Complete.Enums;
    using UFIDA.U9.ISV.MO;
    using UFIDA.U9.CBO.SCM.Item;
using UFIDA.U9.Base.FlexField.DescFlexField;
    using UFIDA.U9.MO.Util;
    using UFIDA.U9.ISV.MO.Proxy;

	/// <summary>
	/// GenProductBarCodesByCompleteApply partial 
	/// </summary>	
	public partial class GenProductBarCodesByCompleteApply 
	{	
		internal BaseStrategy Select()
		{
			return new GenProductBarCodesByCompleteApplyImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class GenProductBarCodesByCompleteApplyImpementStrategy : BaseStrategy
	{
		public GenProductBarCodesByCompleteApplyImpementStrategy() { }

		public override object Do(object obj)
		{						
			GenProductBarCodesByCompleteApply bpObj = (GenProductBarCodesByCompleteApply)obj;
            if (bpObj.ProductBarCodeDTOs == null || bpObj.ProductBarCodeDTOs.Count == 0) return null;

            CompleteApplyDoc completeApplyDoc = new CompleteApplyDoc.EntityKey(bpObj.ProductBarCodeDTOs[0].CompleteApplyDoc).GetEntity();
            if (completeApplyDoc == null) return null;

            if (completeApplyDoc.DocState != CompleteApplyDocStatusEnum.Approved)
                throw new Exception(string.Format("完工申报单{0}没有审核，不允许生成成品入库单和成品条码记录", completeApplyDoc.DocNo));

            //生成成品入库单
            CreateRcvRptDocProxy createRcvRptDoc = new CreateRcvRptDocProxy();
            createRcvRptDoc.CompleteDocInfoDTOList = CreateCompleteDocInfos(bpObj.ProductBarCodeDTOs);
            createRcvRptDoc.Direction = 0;//0是入库、1是出库
            createRcvRptDoc.IsOffLine = false; //是否在制品入库(影响成品入库单单据类型的选择)
            List<WOKeyData> woKeys = createRcvRptDoc.Do();

            RcvRptDoc rcvRptDoc = new RcvRptDoc.EntityKey(woKeys[0].ID).GetEntity();
            if (rcvRptDoc == null) return null;

            using (Session s = Session.Open())
            {
                foreach (RcvRptDocLine rcvRptDocLine in rcvRptDoc.RcvRptDocLines)
                {
                    ProductBarCodeByCompleteApplyDTO barCodeDTO = FindProductBarCodeDTO(bpObj.ProductBarCodeDTOs, rcvRptDocLine);
                    //生成成品条码记录
                    ProductBarCode productBarCode = ProductBarCode.Create();
                    productBarCode.OrgKey = new Base.Organization.Organization.EntityKey(barCodeDTO.OrgID);
                    productBarCode.BarCode = barCodeDTO.BarCode;
                    productBarCode.ActualLength = barCodeDTO.ActualLength;
                    productBarCode.ItemKey = rcvRptDocLine.ItemKey;
                    productBarCode.LotKey = rcvRptDocLine.RcvLotMasterKey;
                    productBarCode.OperatorsKey = new CBO.HR.Operator.Operators.EntityKey(barCodeDTO.QcOperator);

                    productBarCode.CompleteApplyDocKey = new CompleteApplyDoc.EntityKey(barCodeDTO.CompleteApplyDoc);
                    productBarCode.CompleteApplyDocLineKey = new CompleteApplyDocLine.EntityKey(barCodeDTO.CompleteApplyDocLine);
                    productBarCode.RcvRptDocKey = rcvRptDocLine.RcvRptDocKey;
                    productBarCode.RcvRptDocLineKey = rcvRptDocLine.Key;

                    productBarCode.ScanBy = barCodeDTO.ScanBy;
                    productBarCode.ScanOn = DateTime.Now; // barCodeDTO.ScanOn;
                    productBarCode.ProductBarCodeKind = ProductBarCodeKindEnum.Rcv;
                }
                s.Commit();
            }

            return null;
		}

        private ProductBarCodeByCompleteApplyDTO FindProductBarCodeDTO(List<ProductBarCodeByCompleteApplyDTO> barCodeDTOs, RcvRptDocLine rcvRptDocLine)
        {
            string lotCode = rcvRptDocLine.RcvLotNo;
            foreach (ProductBarCodeByCompleteApplyDTO barCodeDTO in barCodeDTOs)
            {
                if (barCodeDTO.BarCode == lotCode)
                    return barCodeDTO;
            }

            throw new Exception(string.Format("没有找到成品入库单{0}行{1}对应的DTO数据", rcvRptDocLine.RcvRptDoc.DocNo, rcvRptDocLine.LineNum));
        }

        private List<CompleteDocInfoDTOData> CreateCompleteDocInfos(List<ProductBarCodeByCompleteApplyDTO> barCodeDTOs)
        {
            List<CompleteDocInfoDTOData> docInfoList = new List<CompleteDocInfoDTOData>();
            CompleteDocInfoDTOData docInfoDTO = new CompleteDocInfoDTOData();
            docInfoDTO.BusinessDate = Base.Context.LoginDate;
            docInfoDTO.CompleteList = new List<WOInfoDTOData>();
            docInfoList.Add(docInfoDTO);

            foreach (ProductBarCodeByCompleteApplyDTO barCodeDTO in barCodeDTOs)
            {
                ItemMaster item = new ItemMaster.EntityKey(barCodeDTO.ItemID).GetEntity();
                CompleteApplyDocLine completeApplyDocLine = new CompleteApplyDocLine.EntityKey(barCodeDTO.CompleteApplyDocLine).GetEntity();

                WOInfoDTOData woInfoDTO = new WOInfoDTOData();
                woInfoDTO.CompleteQty = (decimal)(barCodeDTO.ActualLength/1000.0);
                //生成批号数据
                LotMaster.EntityKey lotKey = LotBuilder.CreateLot(item, barCodeDTO.BarCode, barCodeDTO.ActualLength);
                woInfoDTO.LotMaster = lotKey.ID;
                woInfoDTO.LotNo = lotKey.GetEntity().LotCode;

                woInfoDTO.MOKey = new WOKeyData();
                woInfoDTO.MOKey.ID = completeApplyDocLine.MOKey.ID;
                //扩展字段
                woInfoDTO.DescFlexField = GetRcvRptDocLineDescFlexField(completeApplyDocLine);

                docInfoDTO.CompleteList.Add(woInfoDTO);
            }
            return docInfoList;
        }

        private DescFlexSegmentsData GetRcvRptDocLineDescFlexField(CompleteApplyDocLine completeApplyDocLine)
        {
            List<string> srcEntityFullNames = new List<string>{ CompleteApplyDocLine.EntityRes.BE_FullName };
            List<string> targetEntityFullNames = new List<string> { RcvRptDocLine.EntityRes.BE_FullName };
            FlexFieldMapingDTO mappingdto = PubMethod.GetFlexFieldMaping(srcEntityFullNames, targetEntityFullNames);
            if (mappingdto.PublicFlexFieldReferenceDTOs.Count > 0)
            {
                SourceEntityAndDescFieldsDTO sourceEntityAndDescFieldsDTO = new SourceEntityAndDescFieldsDTO
                {
                    DescFlexSegments = completeApplyDocLine.DescFlexField,
                    SourceEntity = completeApplyDocLine
                };
                return PubMethod.GetFlexField(CompleteApplyDocLine.EntityRes.BE_FullName, sourceEntityAndDescFieldsDTO,
                    RcvRptDocLine.EntityRes.BE_FullName, mappingdto).ToEntityData();
            }
            return new DescFlexSegmentsData();
        }
	}

	#endregion
	
	
}
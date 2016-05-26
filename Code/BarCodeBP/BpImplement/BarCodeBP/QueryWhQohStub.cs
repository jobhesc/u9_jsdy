﻿







namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ServiceModel;
	using System.Runtime.Serialization;
	using System.IO;
	using UFSoft.UBF.Util.Context;
	using UFSoft.UBF;
	using UFSoft.UBF.Exceptions;
	using UFSoft.UBF.Service.Base ;

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.JSDY.BarCode.IQueryWhQoh")]
    public interface IQueryWhQoh
    {
		[ServiceKnownType(typeof(ApplicationContext))]
		[ServiceKnownType(typeof(PlatformContext))]
		[ServiceKnownType(typeof(ThreadContext))]
		[ServiceKnownType(typeof( UFSoft.UBF.Business.BusinessException))]
		[ServiceKnownType(typeof( UFSoft.UBF.Business.EntityNotExistException))]
		[ServiceKnownType(typeof( UFSoft.UBF.Business.AttributeInValidException))]
		[ServiceKnownType(typeof(UFSoft.UBF.Business.AttrsContainerException))]
		[ServiceKnownType(typeof(UFSoft.UBF.Exceptions.MessageBase))]
			[FaultContract(typeof(UFSoft.UBF.Service.ServiceLostException))]
		[FaultContract(typeof(UFSoft.UBF.Service.ServiceException))]
		[FaultContract(typeof(UFSoft.UBF.Service.ServiceExceptionDetail))]
		[FaultContract(typeof(ExceptionBase))]
		[FaultContract(typeof(Exception))]
		[OperationContract()]
        List<UFIDA.U9.Cust.JSDY.BarCode.WhQohInfoDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,System.String itemID, System.String segLength);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class QueryWhQohStub : OperationStubBase, IQueryWhQoh
    {
        #region IQueryWhQoh Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.JSDY.BarCode.WhQohInfoDTOData> Do(IContext context ,out IList<MessageBase> outMessages, System.String itemID, System.String segLength)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, itemID, segLength);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.JSDY.BarCode.WhQohInfoDTOData> DoEx(ICommonDataContract commonData, System.String itemID, System.String segLength)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.JSDY.BarCode.QueryWhQoh");                
                QueryWhQoh objectRef = new QueryWhQoh();
		
				objectRef.ItemID = itemID;
				objectRef.SegLength = segLength;

				//处理返回类型.
				List<UFIDA.U9.Cust.JSDY.BarCode.WhQohInfoDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.JSDY.BarCode.WhQohInfoDTOData> listEntityList = new List<UFIDA.U9.Cust.JSDY.BarCode.WhQohInfoDTOData>();
				foreach (UFIDA.U9.Cust.JSDY.BarCode.WhQohInfoDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.JSDY.BarCode.WhQohInfoDTOData resultdata = obj.ToEntityData();
					listEntityList.Add(resultdata);
				}
				DoSerializeKey(listEntityList, "UFIDA.U9.Cust.JSDY.BarCode.QueryWhQoh");
				return listEntityList;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.JSDY.BarCode.QueryWhQoh");
            }
        }
	#endregion
    }
}

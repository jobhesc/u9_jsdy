







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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.JSDY.BarCode.IGetCompleteApplyBarCodePrintData")]
    public interface IGetCompleteApplyBarCodePrintData
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
        List<UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCodeDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,List<System.String> completeApplyBarCodeIDs);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetCompleteApplyBarCodePrintDataStub : OperationStubBase, IGetCompleteApplyBarCodePrintData
    {
        #region IGetCompleteApplyBarCodePrintData Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCodeDTOData> Do(IContext context ,out IList<MessageBase> outMessages, List<System.String> completeApplyBarCodeIDs)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, completeApplyBarCodeIDs);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCodeDTOData> DoEx(ICommonDataContract commonData, List<System.String> completeApplyBarCodeIDs)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.JSDY.BarCode.GetCompleteApplyBarCodePrintData");                
                GetCompleteApplyBarCodePrintData objectRef = new GetCompleteApplyBarCodePrintData();
	
				objectRef.CompleteApplyBarCodeIDs = completeApplyBarCodeIDs;

				//处理返回类型.
				List<UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCodeDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCodeDTOData> list = new List<UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCodeDTOData>();
				foreach (UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCodeDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCodeDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.JSDY.BarCode.GetCompleteApplyBarCodePrintData");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.JSDY.BarCode.GetCompleteApplyBarCodePrintData");
            }
        }
	#endregion
    }
}

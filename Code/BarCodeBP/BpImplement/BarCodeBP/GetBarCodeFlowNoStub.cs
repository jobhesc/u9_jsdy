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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.JSDY.BarCode.IGetBarCodeFlowNo")]
    public interface IGetBarCodeFlowNo
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
        System.Int32 Do(IContext context ,out IList<MessageBase> outMessages ,System.String baseBarCode);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetBarCodeFlowNoStub : OperationStubBase, IGetBarCodeFlowNo
    {
        #region IGetBarCodeFlowNo Members

        //[OperationBehavior]
        public System.Int32 Do(IContext context ,out IList<MessageBase> outMessages, System.String baseBarCode)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, baseBarCode);
        }
        
        //[OperationBehavior]
        public System.Int32 DoEx(ICommonDataContract commonData, System.String baseBarCode)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.JSDY.BarCode.GetBarCodeFlowNo");                
                GetBarCodeFlowNo objectRef = new GetBarCodeFlowNo();
	
				objectRef.BaseBarCode = baseBarCode;

				//处理返回类型.
				System.Int32 result = objectRef.Do();
				return result ;
						return result;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.JSDY.BarCode.GetBarCodeFlowNo");
            }
        }
	#endregion
    }
}

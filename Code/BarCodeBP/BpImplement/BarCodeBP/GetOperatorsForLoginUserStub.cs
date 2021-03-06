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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.JSDY.BarCode.IGetOperatorsForLoginUser")]
    public interface IGetOperatorsForLoginUser
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
        UFIDA.U9.Cust.JSDY.BarCode.OperatorsDTOData Do(IContext context ,out IList<MessageBase> outMessages );
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetOperatorsForLoginUserStub : OperationStubBase, IGetOperatorsForLoginUser
    {
        #region IGetOperatorsForLoginUser Members

        //[OperationBehavior]
        public UFIDA.U9.Cust.JSDY.BarCode.OperatorsDTOData Do(IContext context ,out IList<MessageBase> outMessages)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData);
        }
        
        //[OperationBehavior]
        public UFIDA.U9.Cust.JSDY.BarCode.OperatorsDTOData DoEx(ICommonDataContract commonData)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.JSDY.BarCode.GetOperatorsForLoginUser");                
                GetOperatorsForLoginUser objectRef = new GetOperatorsForLoginUser();


				//处理返回类型.
				UFIDA.U9.Cust.JSDY.BarCode.OperatorsDTO result = objectRef.Do();

				if (result == null)
					return null ;
						UFIDA.U9.Cust.JSDY.BarCode.OperatorsDTOData resultdata = result.ToEntityData();
				DoSerializeKey(resultdata, "UFIDA.U9.Cust.JSDY.BarCode.GetOperatorsForLoginUser");
				return resultdata;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.JSDY.BarCode.GetOperatorsForLoginUser");
            }
        }
	#endregion
    }
}

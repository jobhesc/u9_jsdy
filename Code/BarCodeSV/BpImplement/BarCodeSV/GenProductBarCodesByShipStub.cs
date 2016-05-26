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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.JSDY.BarCode.IGenProductBarCodesByShip")]
    public interface IGenProductBarCodesByShip
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
        void Do(IContext context ,out IList<MessageBase> outMessages ,List<UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeByShipDTOData> productBarCodeDTOs);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GenProductBarCodesByShipStub : ServiceStubBase, IGenProductBarCodesByShip
    {
        #region IGenProductBarCodesByShip Members

        //[OperationBehavior]
        public void Do(IContext context ,out IList<MessageBase> outMessages, List<UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeByShipDTOData> productBarCodeDTOs)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			DoEx(commonData, productBarCodeDTOs);
        }
        
        //[OperationBehavior]
        public void DoEx(ICommonDataContract commonData, List<UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeByShipDTOData> productBarCodeDTOs)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.JSDY.BarCode.GenProductBarCodesByShip");                
                GenProductBarCodesByShip objectRef = new GenProductBarCodesByShip();
	

				if (productBarCodeDTOs != null)
				{
					DeSerializeKey(productBarCodeDTOs);
					List<UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeByShipDTO> listProductBarCodeDTOs = new List<UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeByShipDTO>();
					foreach (UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeByShipDTOData obj in productBarCodeDTOs)
					{
						if (obj == null)
							continue;
				
						UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeByShipDTO child = new UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeByShipDTO();
						child.FromEntityData(obj);
						//值对象应该是依赖主创建的.但此处不是.可能的问题？
						listProductBarCodeDTOs.Add(child);
					}
					objectRef.ProductBarCodeDTOs = listProductBarCodeDTOs;
				}

				//处理返回类型.
				objectRef.Do(); //没有返回值

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.JSDY.BarCode.GenProductBarCodesByShip");
            }
        }
	#endregion
    }
}

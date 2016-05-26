








namespace UFIDA.U9.Cust.JSDY.BarCode.Proxy
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.IO;
	using System.ServiceModel;
	using System.Runtime.Serialization;
	using UFSoft.UBF;
	using UFSoft.UBF.Exceptions;
	using UFSoft.UBF.Util.Context;
	using UFSoft.UBF.Service;
	using UFSoft.UBF.Service.Base ;

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.JSDY.BarCode.IGenProductBarCodesByCompleteApply")]
    public interface IGenProductBarCodesByCompleteApply
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
		void Do(IContext context, out IList<MessageBase> outMessages ,List<UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeByCompleteApplyDTOData> productBarCodeDTOs);
    }
	[Serializable]    
    public class GenProductBarCodesByCompleteApplyProxy : ServiceProxyBase//, UFIDA.U9.Cust.JSDY.BarCode.Proxy.IGenProductBarCodesByCompleteApply
    {
	#region Fields	
				private List<UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeByCompleteApplyDTOData> productBarCodeDTOs ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 成品条码记录DTO (该属性可为空,且无默认值)
		/// 根据完工申报单生成成品条码记录.Misc.成品条码记录DTO
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeByCompleteApplyDTOData> ProductBarCodeDTOs
		{
			get	
			{	
				return this.productBarCodeDTOs;
			}

			set	
			{	
				this.productBarCodeDTOs = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public GenProductBarCodesByCompleteApplyProxy()
        {
        }
        #endregion
        
        #region 跨site调用
        public void Do(string targetSite)
        {
  			InitKeyList() ;
			InvokeBySite<UFIDA.U9.Cust.JSDY.BarCode.Proxy.IGenProductBarCodesByCompleteApply>(targetSite);
			
        }
        #endregion end跨site调用

		#region 跨组织调用
        public void Do(long targetOrgId)
        {
  			InitKeyList() ;
			InvokeByOrg<UFIDA.U9.Cust.JSDY.BarCode.Proxy.IGenProductBarCodesByCompleteApply>(targetOrgId);
			
        }
		#endregion end跨组织调用

		#region Public Method
		
        public void Do()
        {
  			InitKeyList() ;
 			InvokeAgent<UFIDA.U9.Cust.JSDY.BarCode.Proxy.IGenProductBarCodesByCompleteApply>();
			
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IGenProductBarCodesByCompleteApply channel = oChannel as IGenProductBarCodesByCompleteApply;
            if (channel != null)
            {
				channel.Do(context, out returnMsgs, productBarCodeDTOs);
	    }
            return  null;
        }
		#endregion
		
		#region  Init KeyList 
		//初始化SKey集合--由于接口不一样.BP.SV都要处理
		private void InitKeyList()
		{
			System.Collections.Hashtable dict = new System.Collections.Hashtable() ;
						{
				if (ProductBarCodeDTOs!=null)
				{
					foreach(UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeByCompleteApplyDTOData objdata in ProductBarCodeDTOs)
					{
						objdata.DoSerializeKeyList(dict);
					}
				}
			}
		
		}
		#endregion 

    }
}




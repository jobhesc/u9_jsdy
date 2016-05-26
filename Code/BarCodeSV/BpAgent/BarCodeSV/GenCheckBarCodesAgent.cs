﻿








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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.JSDY.BarCode.IGenCheckBarCodes")]
    public interface IGenCheckBarCodes
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
		void Do(IContext context, out IList<MessageBase> outMessages ,List<UFIDA.U9.Cust.JSDY.BarCode.CheckBarCodeDTOData> checkBarCodeDTOs);
    }
	[Serializable]    
    public class GenCheckBarCodesProxy : ServiceProxyBase//, UFIDA.U9.Cust.JSDY.BarCode.Proxy.IGenCheckBarCodes
    {
	#region Fields	
				private List<UFIDA.U9.Cust.JSDY.BarCode.CheckBarCodeDTOData> checkBarCodeDTOs ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 盘点条码记录DTO (该属性可为空,且无默认值)
		/// 生成盘点条码记录.Misc.盘点条码记录DTO
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.JSDY.BarCode.CheckBarCodeDTOData> CheckBarCodeDTOs
		{
			get	
			{	
				return this.checkBarCodeDTOs;
			}

			set	
			{	
				this.checkBarCodeDTOs = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public GenCheckBarCodesProxy()
        {
        }
        #endregion
        
        #region 跨site调用
        public void Do(string targetSite)
        {
  			InitKeyList() ;
			InvokeBySite<UFIDA.U9.Cust.JSDY.BarCode.Proxy.IGenCheckBarCodes>(targetSite);
			
        }
        #endregion end跨site调用

		#region 跨组织调用
        public void Do(long targetOrgId)
        {
  			InitKeyList() ;
			InvokeByOrg<UFIDA.U9.Cust.JSDY.BarCode.Proxy.IGenCheckBarCodes>(targetOrgId);
			
        }
		#endregion end跨组织调用

		#region Public Method
		
        public void Do()
        {
  			InitKeyList() ;
 			InvokeAgent<UFIDA.U9.Cust.JSDY.BarCode.Proxy.IGenCheckBarCodes>();
			
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IGenCheckBarCodes channel = oChannel as IGenCheckBarCodes;
            if (channel != null)
            {
				channel.Do(context, out returnMsgs, checkBarCodeDTOs);
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
				if (CheckBarCodeDTOs!=null)
				{
					foreach(UFIDA.U9.Cust.JSDY.BarCode.CheckBarCodeDTOData objdata in CheckBarCodeDTOs)
					{
						objdata.DoSerializeKeyList(dict);
					}
				}
			}
		
		}
		#endregion 

    }
}



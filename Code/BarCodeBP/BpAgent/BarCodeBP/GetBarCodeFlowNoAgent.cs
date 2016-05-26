








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
		System.Int32 Do(IContext context, out IList<MessageBase> outMessages ,System.String baseBarCode);
    }
	[Serializable]    
    public class GetBarCodeFlowNoProxy : OperationProxyBase//, UFIDA.U9.Cust.JSDY.BarCode.Proxy.IGetBarCodeFlowNo
    {
	#region Fields	
				private System.String baseBarCode ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 条码基础部分 (该属性可为空,且无默认值)
		/// 获取条码流水号.Misc.条码基础部分
		/// </summary>
		/// <value>System.String</value>
		public System.String BaseBarCode
		{
			get	
			{	
				return this.baseBarCode;
			}

			set	
			{	
				this.baseBarCode = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public GetBarCodeFlowNoProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public System.Int32 Do()
        {
  			InitKeyList() ;
 			System.Int32 result = (System.Int32)InvokeAgent<UFIDA.U9.Cust.JSDY.BarCode.Proxy.IGetBarCodeFlowNo>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IGetBarCodeFlowNo channel = oChannel as IGetBarCodeFlowNo;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, baseBarCode);
	    }
            return  (System.Int32)0;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private System.Int32 GetRealResult(System.Int32 result)
		{

				return result ;
		}
		#region  Init KeyList 
		//初始化SKey集合--由于接口不一样.BP.SV都要处理
		private void InitKeyList()
		{
			System.Collections.Hashtable dict = new System.Collections.Hashtable() ;
					
		}
		#endregion 

    }
}




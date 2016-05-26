








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
		List<UFIDA.U9.Cust.JSDY.BarCode.WhQohInfoDTOData> Do(IContext context, out IList<MessageBase> outMessages ,System.String itemID, System.String segLength);
    }
	[Serializable]    
    public class QueryWhQohProxy : OperationProxyBase//, UFIDA.U9.Cust.JSDY.BarCode.Proxy.IQueryWhQoh
    {
	#region Fields	
				private System.String itemID ;
						private System.String segLength ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 料品ID (该属性可为空,且无默认值)
		/// 查询库存量.Misc.料品ID
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemID
		{
			get	
			{	
				return this.itemID;
			}

			set	
			{	
				this.itemID = value;	
			}
		}		
						

		/// <summary>
		/// 段长 (该属性可为空,且无默认值)
		/// 查询库存量.Misc.段长
		/// </summary>
		/// <value>System.String</value>
		public System.String SegLength
		{
			get	
			{	
				return this.segLength;
			}

			set	
			{	
				this.segLength = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public QueryWhQohProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public List<UFIDA.U9.Cust.JSDY.BarCode.WhQohInfoDTOData> Do()
        {
  			InitKeyList() ;
 			List<UFIDA.U9.Cust.JSDY.BarCode.WhQohInfoDTOData> result = (List<UFIDA.U9.Cust.JSDY.BarCode.WhQohInfoDTOData>)InvokeAgent<UFIDA.U9.Cust.JSDY.BarCode.Proxy.IQueryWhQoh>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IQueryWhQoh channel = oChannel as IQueryWhQoh;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, itemID, segLength);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private List<UFIDA.U9.Cust.JSDY.BarCode.WhQohInfoDTOData> GetRealResult(List<UFIDA.U9.Cust.JSDY.BarCode.WhQohInfoDTOData> result)
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




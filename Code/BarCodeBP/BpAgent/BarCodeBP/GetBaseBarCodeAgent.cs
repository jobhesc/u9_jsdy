








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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.JSDY.BarCode.IGetBaseBarCode")]
    public interface IGetBaseBarCode
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
		System.String Do(IContext context, out IList<MessageBase> outMessages ,System.String itemCode, System.Int32 segLength, System.String operatorCode, System.DateTime businessDate);
    }
	[Serializable]    
    public class GetBaseBarCodeProxy : OperationProxyBase//, UFIDA.U9.Cust.JSDY.BarCode.Proxy.IGetBaseBarCode
    {
	#region Fields	
				private System.String itemCode ;
						private System.Int32 segLength ;
						private System.String operatorCode ;
						private System.DateTime businessDate ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 料号 (该属性可为空,且无默认值)
		/// 获取条码基础部分.Misc.料号
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemCode
		{
			get	
			{	
				return this.itemCode;
			}

			set	
			{	
				this.itemCode = value;	
			}
		}		
						

		/// <summary>
		/// 段长 (该属性可为空,但有默认值)
		/// 获取条码基础部分.Misc.段长
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 SegLength
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
						

		/// <summary>
		/// 检验员代号 (该属性可为空,且无默认值)
		/// 获取条码基础部分.Misc.检验员代号
		/// </summary>
		/// <value>System.String</value>
		public System.String OperatorCode
		{
			get	
			{	
				return this.operatorCode;
			}

			set	
			{	
				this.operatorCode = value;	
			}
		}		
						

		/// <summary>
		/// 日期 (该属性可为空,且无默认值)
		/// 获取条码基础部分.Misc.日期
		/// </summary>
		/// <value>System.Date</value>
		public System.DateTime BusinessDate
		{
			get	
			{	
				return this.businessDate;
			}

			set	
			{	
				this.businessDate = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public GetBaseBarCodeProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public System.String Do()
        {
  			InitKeyList() ;
 			System.String result = (System.String)InvokeAgent<UFIDA.U9.Cust.JSDY.BarCode.Proxy.IGetBaseBarCode>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IGetBaseBarCode channel = oChannel as IGetBaseBarCode;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, itemCode, segLength, operatorCode, businessDate);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private System.String GetRealResult(System.String result)
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




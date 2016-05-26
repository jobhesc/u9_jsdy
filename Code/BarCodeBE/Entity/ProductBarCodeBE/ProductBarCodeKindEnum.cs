using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.JSDY.BarCode
{
    /// <summary>
    /// 可扩展枚举: 条码状态 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class ProductBarCodeKindEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeKindEnum");
        #region ctor & cctor 
        static ProductBarCodeKindEnum()
        {
            InitData();
        }
        private ProductBarCodeKindEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private ProductBarCodeKindEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,ProductBarCodeKindEnum>();
            rcv = new ProductBarCodeKindEnum(0,"Rcv") ;
            innerEnums.Add(0,rcv) ;
            ship = new ProductBarCodeKindEnum(1,"Ship") ;
            innerEnums.Add(1,ship) ;
            rMR = new ProductBarCodeKindEnum(2,"RMR") ;
            innerEnums.Add(2,rMR) ;
            empty = new ProductBarCodeKindEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static ProductBarCodeKindEnum empty;
        public static ProductBarCodeKindEnum Empty
        {
            get
            {
                return empty;
            }
        }
        #endregion 

        #region Intstance Propertites 
        private int currentValue;
        public System.Int32 Value
        {
            get
            {
				return currentValue ;         
            }
        }
        private string  name ;
        public string  Name 
        {
            get
            {
                return name;
            }
        }
        [System.Obsolete("已经废弃,请用EnumRes.GetResource(name)方式来获取显示名称. ")]
        public string Res_Name
        {
        	get 
        	{
        		switch ( this.Name )
        		{
        			case "Rcv":
        				return this.Res_Rcv; 
        			case "Ship":
        				return this.Res_Ship; 
        			case "RMR":
        				return this.Res_RMR; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static ProductBarCodeKindEnum rcv ;
        /// <summary>
        /// 枚举值: 入库  Value:0  
        /// 条码状态.Misc.入库
        /// </summary>
        public static ProductBarCodeKindEnum Rcv
        {
            get
            {
                return  rcv ;
            }
        }
        private static ProductBarCodeKindEnum ship ;
        /// <summary>
        /// 枚举值: 出库  Value:1  
        /// 条码状态.Misc.出库
        /// </summary>
        public static ProductBarCodeKindEnum Ship
        {
            get
            {
                return  ship ;
            }
        }
        private static ProductBarCodeKindEnum rMR ;
        /// <summary>
        /// 枚举值: 销售退回  Value:2  
        /// 条码状态.Misc.销售退回
        /// </summary>
        public static ProductBarCodeKindEnum RMR
        {
            get
            {
                return  rMR ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, ProductBarCodeKindEnum> innerEnums;
        /// <summary>
        /// Get ProductBarCodeKindEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<ProductBarCodeKindEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get ProductBarCodeKindEnum By Value 
        /// </summary>
        public static ProductBarCodeKindEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						ProductBarCodeKindEnum newValue = new ProductBarCodeKindEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get ProductBarCodeKindEnum By Value 
        /// </summary>
        public static ProductBarCodeKindEnum GetFromValue(object value)
        {
			if (value == null)
				return ProductBarCodeKindEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get ProductBarCodeKindEnum By Name 
        /// </summary>
        public static ProductBarCodeKindEnum GetFromName(string name)
        {
            foreach (ProductBarCodeKindEnum obj in innerEnums.Values)
            {
                if (obj.Name == name)
                    return obj;
            }
            //don't need modify to return a Default Value .
            return null;
        }
        #endregion 


		#region ModelResource
		/// <summary>
		/// 条码状态的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 条码状态的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeKindEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Rcv　{ get {return EnumRes.GetResource("Rcv");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Ship　{ get {return EnumRes.GetResource("Ship");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_RMR　{ get {return EnumRes.GetResource("RMR");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeKindEnum";　}　}

			/// <summary>
			///  获取资源接口,直接传了枚举对象.Name 就可.
			/// </summary>
			public static string GetResource(String attrName)
			{
				if (attrName== Enum_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEnumResource(Enum_FullName);
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEnumResource(Enum_FullName, attrName);
			}
			/// <summary>
			///  获取资源接口,直接传了枚举对象.Value 或Int32值 就可.
			/// </summary>
			public static string GetResourceByValue(Int32 value)
			{
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetNameForEnumValue(Enum_FullName, value);
			}
		}
		#endregion 
    }
}
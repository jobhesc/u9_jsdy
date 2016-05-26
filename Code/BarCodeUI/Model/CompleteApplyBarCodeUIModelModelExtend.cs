#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;
using UFIDA.U9.UI.PDHelper;
using UFIDA.U9.Cust.JSDY.BarCode.Proxy;
using UFIDA.U9.Cust.JSDY.BarCode;

#endregion

namespace UFIDA.U9.Cust.JSDY.CompleteApplyBarCodeUIModel
{	public partial class CompleteApplyBarCodeUIModelModel 
	{
        //初始化UIMODEL之后的方法
        public override  void AfterInitModel()
        {
            //默认完工申报日期
            this.viewCompleteApplyBarCode.FieldBusinessDate.DefaultValue = PDContext.Current.LoginDate;
            //默认一个条码，然后在BE中自动生成
            this.viewCompleteApplyBarCode.FieldBarCode.DefaultValue = "自动编码";
            //默认检验员
            GetOperatorsForLoginUserProxy getOperatorsProxy = new GetOperatorsForLoginUserProxy();
            OperatorsDTOData operatorsDTO = getOperatorsProxy.Do();
            if (operatorsDTO != null)
            {
                this.viewCompleteApplyBarCode.FieldOperators.DefaultValue = operatorsDTO.OperatorsID;
                this.viewCompleteApplyBarCode.FieldOperators_Code.DefaultValue = operatorsDTO.OperatorsCode;
                this.viewCompleteApplyBarCode.FieldOperators_Name.DefaultValue = operatorsDTO.OperatorsName;
            }
        }
        
        //UIModel提交保存之前的校验操作.
        public override void OnValidate()
        {
        		base.OnValidate() ;
            OnValidate_DefualtImpl();
            //your coustom code ...
        }
	}
}
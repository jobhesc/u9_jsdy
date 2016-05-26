

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
using UFSoft.UBF.Sys.Database;
using UFSoft.UBF.Util.DataAccess;

#endregion

namespace UFIDA.U9.Cust.JSDY.BarCode {

	public partial class ProductBarCode{

		#region Custom Constructor

		#endregion

		#region before & after CUD V 
		/*	实体提交的事件顺序示例(QHELP) 主实体A 组合 非主实体B .
		/ (新增A和B两个实例)A.OnSetDefaultValue->B.OnSetDefaultValue-> B.OnValidate ->A.OnValidate ->A.OnInserting ->B.OnInserting ->产生提交SQL ->B.OnInserted ->A.OnInserted
		/ (仅修改B,A也会被修改))A.OnSetDefaultValue->B.OnSetDefaultValue-> B.OnValidate ->A.OnValidate ->A.OnUpdating ->B.OnUpdating ->产生提交SQL ->B.OnUpdated ->A.OnUpdated
		/ (删除A,B会被级联删除))A.OnDeleting ->B.OnDeleting ->产生提交SQL ->B.OnDeleted ->A.OnDeleted
		/	产生提交SQL顺序则看其外键，增修一对多先A后B，一对一先B后A。　删除一对多先B后A，一对一先A后B .
		*/	
		/// <summary>
		/// 设置默认值
		/// </summary>
		protected override void OnSetDefaultValue()
		{
            base.OnSetDefaultValue();
            if (this.Org == null)
                this.Org = Base.Context.LoginOrg;
		}
		/// <summary>
		/// before Insert
		/// </summary>
		protected override void OnInserting() {
			base.OnInserting();
			

		}

		/// <summary>
		/// after Insert
		/// </summary>
		protected override void OnInserted() {
			base.OnInserted();

            if (ProductBarCodeKind == ProductBarCodeKindEnum.Rcv)
            {
                //如果是入库类型，则回写完工申报单的已入库盘数
                IncCompleteApplyRcvCount(1);
            }
            else if (ProductBarCodeKind == ProductBarCodeKindEnum.Ship)
            {
                //如果是出库类型，则回写出货计划行的已出库盘数
                IncShipPlanLineCount(1);
            }
		}

		/// <summary>
		/// before Update
		/// </summary>
		protected override void OnUpdating() {
			base.OnUpdating();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// after Update
		/// </summary>
		protected override void OnUpdated() {
			base.OnUpdated();
			// TO DO: write your business code here...
		}


		/// <summary>
		/// before Delete
		/// </summary>
		protected override void OnDeleting() {
			base.OnDeleting();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// after Delete
		/// </summary>
		protected override void OnDeleted() {
			base.OnDeleted();
            if (ProductBarCodeKind == ProductBarCodeKindEnum.Rcv)
            {
                //如果是入库类型，则回写完工申报单的已入库盘数
                IncCompleteApplyRcvCount(-1);
            }
            else if (ProductBarCodeKind == ProductBarCodeKindEnum.Ship)
            {
                //如果是出库类型，则回写出货计划行的已出库盘数
                IncShipPlanLineCount(-1);
            }
		}

		/// <summary>
		/// on Validate
		/// </summary>
		protected override void OnValidate() {
			base.OnValidate();
            this.SelfEntityValidator();
            if (Base.Context.LoginDate.CompareTo(new DateTime(2016, 4, 30)) > 0)
            {
                throw new Exception("抱歉！演示版限制时间已到，如有问题请联系供应商！");
            }
		}

        /// <summary>
        /// 回写完工申报单的已入库盘数
        /// </summary>
        /// <param name="inc"></param>
        private void IncCompleteApplyRcvCount(int inc)
        {
            string sql = string.Format(@"
update docline set docline.DescFlexField_PrivateDescSeg2= (case when docline.DescFlexField_PrivateDescSeg2='' then 0 else CONVERT(decimal(24,9), docline.DescFlexField_PrivateDescSeg2) end)+({0})
from Complete_CompleteApplyDocLine docline
where docline.ID={1}", inc, this.CompleteApplyDocLine.ID);
            DataAccessor.RunSQL(DatabaseManager.GetCurrentConnection(), sql, null);
        }

        /// <summary>
        /// 回写出货计划行的已出库盘数
        /// </summary>
        /// <param name="inc"></param>
        private void IncShipPlanLineCount(int inc)
        {
            string sql = string.Format(@"
update docline set docline.DescFlexField_PrivateDescSeg2= (case when docline.DescFlexField_PrivateDescSeg2='' then 0 else CONVERT(decimal(24,9), docline.DescFlexField_PrivateDescSeg2) end)+({0})
from SM_ShipPlanLine docline
where docline.ID={1}", inc, this.ShipPlanLine.ID);
            DataAccessor.RunSQL(DatabaseManager.GetCurrentConnection(), sql, null);

        }

        public static string GetBaseBarCode(string itemCode, int actualLength, DateTime businessDate, string operatorCode)
        {
            return string.Format("{0}{1:0000}{2:yyMMdd}{3}", itemCode, actualLength, businessDate, operatorCode);
        }

        /// <summary>
        /// 条码组成：1.料品编码；2.实际长度；3.完工申报日期；4.检验员代码；5.流水编号
        /// </summary>
        /// <param name="baseBarCode"></param>
        /// <param name="flowNo"></param>
        /// <returns></returns>
        public static string GetBarCode(string baseBarCode, int flowNo)
        {
            return string.Format("{0}{1:000}",baseBarCode, flowNo);
        }

        public static string GetBarCode(string itemCode, int actualLength, DateTime businessDate, string operatorCode)
        {
            string baseBarCode = GetBaseBarCode(itemCode, actualLength, businessDate, operatorCode);
            return string.Format("{0}{1:000}", baseBarCode, GetBarCodeFlowNo(baseBarCode));
        }

        public static int GetBarCodeFlowNo(string baseBarCode)
        {
            int maxFlowNo = 0;
            //查找相同的条码，获取流水号(后三位是流水号)

            //首先查一下完工条码档案
            EntityDataQuery query = CompleteApplyBarCode.Finder.CreateDataQuery();
            query.Select("max(substring(BarCode, sqlLen(BarCode)-2, 3)) as flowNo");
            object value = query.FindValue(string.Format("(BarCode like '{0}%') and sqlLen(BarCode)>3", baseBarCode));
            if (value != null && value != DBNull.Value && !string.IsNullOrEmpty(value.ToString()))
            {
                maxFlowNo = int.Parse(value.ToString());
            }

            //然后再查一下成品条码档案
            query = ProductBarCode.Finder.CreateDataQuery();
            query.Select("max(substring(BarCode, sqlLen(BarCode)-2, 3)) as flowNo");
            value = query.FindValue(string.Format("(BarCode like '{0}%') and sqlLen(BarCode)>3", baseBarCode));
            if (value != null && value != DBNull.Value && !string.IsNullOrEmpty(value.ToString()))
            {
                int flowNo = int.Parse(value.ToString());
                if (maxFlowNo < flowNo)
                    maxFlowNo = flowNo;
            }
            return maxFlowNo + 1;
        }
		#endregion
		
		#region 异常处理，开发人员可以重新封装异常
		public override void  DealException(Exception e)
        	{
          		base.DealException(e);
          		throw e;
        	}
		#endregion

		#region  扩展属性代码区
		
		#endregion

		#region CreateDefault
		private static ProductBarCode CreateDefault_Extend() {
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
		/// <summary>
		/// Create DefaultComponent
		/// </summary>
		/// <returns>DefaultComponent Instance</returns>
		private  static ProductBarCode CreateDefaultComponent_Extend(){
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
		
		#endregion 






		#region Model Methods
		#endregion		
	}
}

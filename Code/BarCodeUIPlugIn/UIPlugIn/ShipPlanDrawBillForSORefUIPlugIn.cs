using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.Engine.Builder;
using UFSoft.UBF.UI.WebControls;
using System.Collections.Specialized;

namespace UFIDA.U9.Cust.JSDY.BarCodeUIPlugIn
{
    partial class ShipPlanDrawBillForSORefUIPlugIn : UFSoft.UBF.UI.Custom.ExtendedPartBase
    {
        #region �ֶ�������

        private BaseWebForm _strongPart;
        private IUFButton btnQueryWhQoh = null;

        #endregion

        public override void AfterInit(UFSoft.UBF.UI.IView.IPart part, EventArgs args)
        {
            #region ��ȡ���ǿ��������

            _strongPart = part as BaseWebForm;
            if (_strongPart == null)
                return;

            #endregion

            #region ��ӿؼ�ģ���¼���������

            //ʵ�����ؼ�
            UFSoft.UBF.UI.ControlModel.IUFContainer Card0
                = (UFSoft.UBF.UI.ControlModel.IUFContainer)part.GetUFControlByName(part.TopLevelContainer, "CardPlusFunction");
            

            //���Ӳ�ѯ��水ť
            this.btnQueryWhQoh = UIControlBuilder.BuilderUFButton(Card0, true, "btnQueryWhQoh", true, true, 80, 20, 2, 0, 1, 1, "100", "", "", "btnQueryWhQoh", false, "", "", "7a847b62-5778-42db-abed-e41fb6130a76");
            this.btnQueryWhQoh.Text = "����ѯ";
            this.btnQueryWhQoh.AutoPostBack = true;
            this.btnQueryWhQoh.Click += new EventHandler(btnQueryWhQoh_Click);

            #endregion
        }

        private void showErrorMessage(string message)
        {
            IUIModel model = _strongPart.Model;
            model.ErrorMessage.SetErrorMessage(ref model, message);
        }

        void btnQueryWhQoh_Click(object sender, EventArgs e)
        {
            _strongPart.Model.ClearErrorMessage();
            _strongPart.DataCollect();//��ǰ�¼���ִ�������ռ�

            _strongPart.IsDataBinding = true;
            _strongPart.IsConsuming = false;

            if (this.FocusedRecord == null)
            {
                showErrorMessage("��ѡ����Ҫ���п���ѯ�ļ�¼��");
                return;
            }

            if (!DrawBillView.Fields.Contains("ItemInfo_ItemID"))
            {
                showErrorMessage("��ѯ�����в�����ItemInfo_ItemID(��ƷID)�ֶΣ�����ϵϵͳ����Ա��������");
                return;
            }

            if (!DrawBillView.Fields.Contains("SOLine_DescFlexField_PubDescSeg1"))
            {
                showErrorMessage("��ѯ�����в�����SOLine_DescFlexField_PubDescSeg1(���۶����й�����չ�ֶ�1�γ�)�ֶΣ�����ϵϵͳ����Ա��������");
                return;
            }

            string itemID = this.FocusedRecord["ItemInfo_ItemID"].ToString();
            string segLength = this.FocusedRecord["SOLine_DescFlexField_PubDescSeg1"] == null ? "" : this.FocusedRecord["SOLine_DescFlexField_PubDescSeg1"].ToString();

            NameValueCollection nameValue = new NameValueCollection();
            nameValue.Add("ItemID", itemID);
            nameValue.Add("SegLength", segLength);
            _strongPart.ShowModalDialog("1230c62c-36d0-49da-b9d8-00dcafb3e6b6", "����ѯ", "992", "504", "", nameValue, false, true, false);
        }

        private IUIView DrawBillView
        {
            get { return _strongPart.Model.Views["DrawBillView"]; }
        }

        private IUIRecord FocusedRecord
        {
            get { return DrawBillView.FocusedRecord; }
        }
    }
}

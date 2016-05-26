using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
using UFIDA.U9.MO.Enums;
using UFSoft.UBF.Util.Exceptions;
using UFIDA.U9.CBO.SCM.Customer;
using UFIDA.U9.MO.Complete;
using UFIDA.U9.SM.RMA;
using UFIDA.U9.Cust.JSDY.BarCode;
using UFIDA.U9.CBO.HR.Operator;

namespace UFIDA.U9.Cust.JSDY.BarCodeAppPlugIn
{
    [UFSoft.UBF.Eventing.Configuration.Failfast]
    public class RMAAfterUpdated : UFSoft.UBF.Eventing.IEventSubscriber
    {
        #region IEventSubscriber ��Ա

        public void Notify(params object[] args)
        {
            //���¼�������ȡ�õ�ǰҵ��ʵ��
            if (args == null || args.Length == 0 || !(args[0] is UFSoft.UBF.Business.EntityEvent)) return;
            BusinessEntity.EntityKey key = ((UFSoft.UBF.Business.EntityEvent)args[0]).EntityKey;
            if (key == null) return;

            RMA rma = key.GetEntity() as RMA;
            if (rma == null) return;

            //���ʱ����������������������˻��ջ���
            if (rma.Status == RMAStatusEnum.Posted && rma.OriginalData.Status != RMAStatusEnum.Posted)
            {
                List<ProductBarCodeByRMADTO> barCodeDTOs = new List<ProductBarCodeByRMADTO>();
                //������ˮ�ֵ�
                Dictionary<string, int> barCodeFlowNoDict = new Dictionary<string, int>();
                foreach (RMALine rmaline in rma.RMALines)
                {
                    int actualLength = 0;
                    if (!string.IsNullOrEmpty(rmaline.DescFlexField.PrivateDescSeg2))
                    {
                        int.TryParse(rmaline.DescFlexField.PrivateDescSeg2, out actualLength);
                    }
                    if (actualLength <= 0)
                    {
                        throw new RMALineException(rmaline.ID, "�γ�û��¼�����¼����ֵ��Ч���޷���������");
                    }

                    string qcOperatorCode = rmaline.DescFlexField.PrivateDescSeg3;
                    if (string.IsNullOrEmpty(qcOperatorCode))
                    {
                        throw new RMALineException(rmaline.ID, "����Աû��¼�룬�޷���������");
                    }
                    Operators qcOperator = Operators.Finder.Find(string.Format("Org={0} and Code='{1}'", rmaline.OrgKey.ID, qcOperatorCode));
                    if (qcOperator == null)
                    {
                        throw new RMALineException(rmaline.ID, "�޷��ҵ�����Ա��Ӧ��ʵ�壬�޷���������");
                    }

                    int totalLength = (int)rmaline.ApplyQtyTU1; //�ܳ�
                    int count = totalLength / actualLength;  //����

                    string baseBarCode = ProductBarCode.GetBaseBarCode(rmaline.ItemInfo.ItemCode, actualLength, Base.Context.LoginDate, qcOperatorCode);
                    if (!barCodeFlowNoDict.ContainsKey(baseBarCode))
                    {
                        barCodeFlowNoDict.Add(baseBarCode, ProductBarCode.GetBarCodeFlowNo(baseBarCode));
                    }

                    for (int i = 0; i < count; i++)
                    {
                        ProductBarCodeByRMADTO barCodeDTO = new ProductBarCodeByRMADTO();
                        barCodeDTO.BarCode = ProductBarCode.GetBarCode(baseBarCode, barCodeFlowNoDict[baseBarCode]);
                        barCodeDTO.ActualLength = actualLength;
                        barCodeDTO.ItemID = rmaline.ItemInfo.ItemIDKey.ID;
                        barCodeDTO.OrgID = rmaline.OrgKey.ID;
                        barCodeDTO.QcOperator = qcOperator.ID;
                        barCodeDTO.RMA = rma.ID;
                        barCodeDTO.RMALine = rmaline.ID;

                        barCodeDTOs.Add(barCodeDTO);
                        barCodeFlowNoDict[baseBarCode] = barCodeFlowNoDict[baseBarCode] + 1;
                    }
                }

                GenProductBarCodesByRMA genBarCode = new GenProductBarCodesByRMA();
                genBarCode.ProductBarCodeDTOs = barCodeDTOs;
                genBarCode.Do();
            }
        }

        #endregion
    }

    public class RMALineException : ApplicationExceptionBase
    {
        public RMALineException(string message) : base(message) { }

        public RMALineException(long entityID, string message) : this(entityID, string.Empty, message) { }

        public RMALineException(long entityID, string attributeName, string message)
            : base(message)
        {
            base.EntityFullName = RMALine.EntityRes.BE_FullName;
            base.EntityID = entityID;
            base.AttributeName = attributeName;
        }
    }
}

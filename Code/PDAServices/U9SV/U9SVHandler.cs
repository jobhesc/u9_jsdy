using System;
using System.Collections.Generic;
using System.Text;
using JSDY.U9SV.Utils;
using System.Transactions;
using JSDY.U9SV.DTO;
using www.ufida.org.EntityData;

namespace JSDY.U9SV
{
    public class U9SVHandler
    {
        /// <summary>
        /// 获取上下文
        /// </summary>
        /// <param name="loginContext"></param>
        /// <returns></returns>
        private static UFSoft.UBF.Util.Context.ThreadContext GetContext(LoginContext loginContext)
        {
            UFSoft.UBF.Util.Context.ThreadContext context = new UFSoft.UBF.Util.Context.ThreadContext();
            context.nameValueHas = new Dictionary<object, object>();
            context.nameValueHas.Add("OrgID", loginContext.OrgID);
            context.nameValueHas.Add("UserID", loginContext.UserID);
            context.nameValueHas.Add("UserName", loginContext.UserName);
            context.nameValueHas.Add("CultureName", "zh-CN");
            context.nameValueHas.Add("Support_CultureNameList", "zh-CN");
            context.nameValueHas.Add("DefaultCultureName", "zh-CN");
            context.nameValueHas.Add("EnterpriseID", PDAConfig.EnterpriseID);
            context.nameValueHas.Add("EnterpriseName", PDAConfig.EnterpriseName);

            return context;
        }

        /// <summary>
        /// 生成盘点条码记录
        /// </summary>
        /// <param name="importDTOs"></param>
        /// <param name="loginContext"></param>
        public static void genCheckBarCodes(List<InvCheckBarCodeImportDTO> importDTOs, LoginContext loginContext)
        {
            UFSoft.UBF.Util.Context.ThreadContext context = GetContext(loginContext);
            List<UFIDAU9CustJSDYBarCodeCheckBarCodeDTOData> list = new List<UFIDAU9CustJSDYBarCodeCheckBarCodeDTOData>();
            UFIDAU9CustJSDYBarCodeCheckBarCodeDTOData dto = null;
            foreach (InvCheckBarCodeImportDTO importDTO in importDTOs)
            {
                dto = new UFIDAU9CustJSDYBarCodeCheckBarCodeDTOData();
                dto.m_orgID = importDTO.OrgID;
                dto.m_itemID = importDTO.ItemID;
                dto.m_actualLength = importDTO.Qty;
                dto.m_barCode = importDTO.BarCode;
                dto.m_checkedBy = importDTO.ScanPerson;
                dto.m_checkedOn = importDTO.ScanDate;
                list.Add(dto);
            }
            try
            {
                UFIDAU9CustJSDYBarCodeIGenCheckBarCodesClient client = new UFIDAU9CustJSDYBarCodeIGenCheckBarCodesClient();
                client.Do(context, list.ToArray());
            }
            catch (System.Exception ex)
            {
                PDALog.Error(ex);
                throw new System.Exception(ExceptionHelper.ParseError(ex));
            }
        }

        /// <summary>
        /// 根据完工申报单生成成品条码记录
        /// </summary>
        /// <param name="importDTOs"></param>
        /// <param name="loginContext"></param>
        public static void genProductBarCodeByCompleteApply(List<ProductBarCodeImportDTO> importDTOs, LoginContext loginContext)
        {
            UFSoft.UBF.Util.Context.ThreadContext context = GetContext(loginContext);
            List<UFIDAU9CustJSDYBarCodeProductBarCodeByCompleteApplyDTOData> list = new List<UFIDAU9CustJSDYBarCodeProductBarCodeByCompleteApplyDTOData>();
            UFIDAU9CustJSDYBarCodeProductBarCodeByCompleteApplyDTOData dto = null;
            foreach (ProductBarCodeImportDTO importDTO in importDTOs)
            {
                dto = new UFIDAU9CustJSDYBarCodeProductBarCodeByCompleteApplyDTOData();
                dto.m_orgID = importDTO.OrgID;
                dto.m_itemID = importDTO.ItemID;
                dto.m_actualLength = importDTO.Qty;
                dto.m_barCode = importDTO.BarCode;
                dto.m_qcOperator = importDTO.QcOperatorID;
                dto.m_completeApplyDoc = importDTO.DocID;
                dto.m_completeApplyDocLine = importDTO.DocLineID;
                dto.m_scanBy = importDTO.ScanPerson;
                dto.m_scanOn = importDTO.ScanDate;
                list.Add(dto);
            }
            try
            {
                UFIDAU9CustJSDYBarCodeIGenProductBarCodesByCompleteApplyClient client = new UFIDAU9CustJSDYBarCodeIGenProductBarCodesByCompleteApplyClient();
                client.Do(context, list.ToArray());
            }
            catch (System.Exception ex)
            {
                PDALog.Error(ex);
                throw new System.Exception(ExceptionHelper.ParseError(ex));
            }
        }

        /// <summary>
        /// 根据出货计划生成成品条码记录
        /// </summary>
        /// <param name="importDTOs"></param>
        /// <param name="loginContext"></param>
        public static void genProductBarCodeByShip(List<ProductBarCodeImportDTO> importDTOs, LoginContext loginContext)
        {
            UFSoft.UBF.Util.Context.ThreadContext context = GetContext(loginContext);
            List<UFIDAU9CustJSDYBarCodeProductBarCodeByShipDTOData> list = new List<UFIDAU9CustJSDYBarCodeProductBarCodeByShipDTOData>();
            UFIDAU9CustJSDYBarCodeProductBarCodeByShipDTOData dto = null;
            foreach (ProductBarCodeImportDTO importDTO in importDTOs)
            {
                dto = new UFIDAU9CustJSDYBarCodeProductBarCodeByShipDTOData();
                dto.m_orgID = importDTO.OrgID;
                dto.m_itemID = importDTO.ItemID;
                dto.m_actualLength = importDTO.Qty;
                dto.m_barCode = importDTO.BarCode;
                dto.m_qcOperator = importDTO.QcOperatorID;
                dto.m_shipPlan = importDTO.DocID;
                dto.m_shipPlanLine = importDTO.DocLineID;
                dto.m_scanBy = importDTO.ScanPerson;
                dto.m_scanOn = importDTO.ScanDate;
                list.Add(dto);
            }
            try
            {
                UFIDAU9CustJSDYBarCodeIGenProductBarCodesByShipClient client = new UFIDAU9CustJSDYBarCodeIGenProductBarCodesByShipClient();
                client.Do(context, list.ToArray());
            }
            catch (System.Exception ex)
            {
                PDALog.Error(ex);
                throw new System.Exception(ExceptionHelper.ParseError(ex));
            }
        }
    }
}

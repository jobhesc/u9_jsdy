using System;
using System.Collections.Generic;
using System.Text;
using PDAClient.PDAService;
using PDAClient.Entities;

namespace PDAClient.Utils
{
    /// <summary>
    /// ���������
    /// </summary>
    class ServiceAgent
    {
        private static U9PDAService _agent;

        public static U9PDAService Agent
        {
            get
            {
                if (_agent == null)
                    _agent = new U9PDAService();

                _agent.Url = OptionsDataSet.Instance.ServerUrl;
                _agent.Timeout = OptionsDataSet.Instance.ConnTimeout * 1000;
                return _agent;
            }
        }


        /// <summary>
        /// �����̵�ɨ���¼
        /// </summary>
        /// <param name="importDTOs"></param>
        public static void AddInvCheckBarCodes(InvCheckBarCodeImportDTO[] importDTOs)
        {
            if (importDTOs == null || importDTOs.Length == 0) return;
            Agent.AddInvCheckBarCodes(importDTOs, CreateContext());
        }

        /// <summary>
        /// �����깤���ɨ���¼
        /// </summary>
        /// <param name="importDTOs"></param>
        public static void AddCompleteApplyBarCode(ProductBarCodeImportDTO[] importDTOs)
        {
            if (importDTOs == null || importDTOs.Length == 0) return;
            Agent.AddProductBarCodesByCompleteApply(importDTOs, CreateContext());
        }

        /// <summary>
        /// ���ɳ���ɨ���¼
        /// </summary>
        /// <param name="importDTOs"></param>
        public static void AddShipBarCode(ProductBarCodeImportDTO[] importDTOs)
        {
            if (importDTOs == null || importDTOs.Length == 0) return;
            Agent.AddProductBarCodesByShip(importDTOs, CreateContext());
        }

        /// <summary>
        /// ��������������
        /// </summary>
        /// <returns></returns>
        private static LoginContext CreateContext()
        {
            LoginContext context = new LoginContext();
            context.OrgID = PDAContext.LoginOrgID;
            context.UserID = PDAContext.LoginUserID;
            context.UserName = PDAContext.LoginUserName;
            return context;
        }

        /// <summary>
        /// ��������
        /// </summary>
        /// <returns></returns>
        public static void TestConn()
        {
            try
            {
                Agent.LoginValidate("admin", "");
            }
            catch(Exception e)
            {
                throw new Exception("Զ�̷���������ʧ�ܣ�");
            }
        }
    }
}

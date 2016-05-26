using System;
using System.Collections.Generic;
using System.Text;
using PDAClient.PDAService;
using PDAClient.Entities;

namespace PDAClient.Utils
{
    /// <summary>
    /// 服务代理类
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
        /// 生成盘点扫描记录
        /// </summary>
        /// <param name="importDTOs"></param>
        public static void AddInvCheckBarCodes(InvCheckBarCodeImportDTO[] importDTOs)
        {
            if (importDTOs == null || importDTOs.Length == 0) return;
            Agent.AddInvCheckBarCodes(importDTOs, CreateContext());
        }

        /// <summary>
        /// 生成完工入库扫描记录
        /// </summary>
        /// <param name="importDTOs"></param>
        public static void AddCompleteApplyBarCode(ProductBarCodeImportDTO[] importDTOs)
        {
            if (importDTOs == null || importDTOs.Length == 0) return;
            Agent.AddProductBarCodesByCompleteApply(importDTOs, CreateContext());
        }

        /// <summary>
        /// 生成出货扫描记录
        /// </summary>
        /// <param name="importDTOs"></param>
        public static void AddShipBarCode(ProductBarCodeImportDTO[] importDTOs)
        {
            if (importDTOs == null || importDTOs.Length == 0) return;
            Agent.AddProductBarCodesByShip(importDTOs, CreateContext());
        }

        /// <summary>
        /// 创建服务上下文
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
        /// 测试连接
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
                throw new Exception("远程服务器连接失败！");
            }
        }
    }
}

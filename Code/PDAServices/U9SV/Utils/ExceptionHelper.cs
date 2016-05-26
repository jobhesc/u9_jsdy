using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using System.Web.Services.Protocols;
using System.Xml;
using UFSoft.UBF.Service;
using System.ServiceModel;

namespace JSDY.U9SV.Utils
{
    public enum FaultCode
    {
        Client = 0,
        Server = 1
    }

    /// <summary>
    /// 异常辅助类，封装web异常处理
    /// </summary>
    public class ExceptionHelper
    {
        public static SoapException CreateSoapException(string errorMessage, string errorSource)
        {
            return CreateSoapException("", errorMessage, "", errorSource, FaultCode.Server);
        }

        /// <summary>
        /// 封装异常为SoapException
        /// </summary>
        /// <param name="uri">引发异常的方法uri</param>
        /// <param name="errorMessage">错误信息</param>
        /// <param name="errorNumber">错误号</param>
        /// <param name="errorSource">错误源</param>
        /// <param name="code">异常类型</param>
        /// <returns>封装后的SoapException</returns>
        public static SoapException CreateSoapException(string uri, string errorMessage,
            string errorNumber, string errorSource, FaultCode code)
        {
            //初始化限定名
            XmlQualifiedName faultCodeLocation = null;

            //异常类型代码转换
            switch (code)
            {
                case FaultCode.Client:
                    faultCodeLocation = SoapException.ClientFaultCode;
                    break;
                case FaultCode.Server:
                    faultCodeLocation = SoapException.ServerFaultCode;
                    break;
            }
            // 截取errormessage中回车换行之前的信息
            int clindex =  errorMessage.IndexOf("\n", 0);
            if (clindex >= 0)
                errorMessage = errorMessage.Substring(0, clindex);

            // errorMessage超过2000字符，截断
            if (errorMessage.Length > 2000)
                errorMessage = errorMessage.Substring(0, 2000);

            //构建异常信息结构体
            string strXmlOut = @"<detail>"
                             + "<Error>"
                             + "<ErrorNumber>" + errorNumber + "</ErrorNumber>"
                             + "<ErrorMessage>" + errorMessage + "</ErrorMessage>"
                             + "<ErrorSource>" + errorSource + "</ErrorSource>"
                             + "</Error>"
                             + "</detail>";

            //装载为Xml文档
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(strXmlOut);

            //实例化SoapException
            SoapException soapEx = new SoapException(errorMessage, faultCodeLocation, uri, xmlDoc.DocumentElement);

            //返回SoapException
            return soapEx;
        }

        /// <summary>
        /// 解析异常
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static string ParseError(Exception ex)
        {
            // 通过stub方式调用异常处理 
            //SoapException soapEx = ex as SoapException;
            //if (soapEx != null)
            //{
            //    XmlDocument doc = new XmlDocument();
            //    doc.LoadXml(soapEx.Detail.OuterXml);

            //    XmlNamespaceManager nsMgr = new XmlNamespaceManager(doc.NameTable);
            //    nsMgr.AddNamespace("ns", "http://schemas.datacontract.org/2004/07/UFSoft.UBF.Service");

            //    XmlNode errorNode = doc.DocumentElement.SelectSingleNode("ns:ServiceException/InnerExceptions/*/Message", nsMgr);
            //    if (errorNode != null)
            //        return errorNode.InnerText;
            //}

            //return ex.Message;

            // 通过client方式调用方式异常处理
            FaultException<ServiceException> serviceEx = ex as FaultException<ServiceException>;
            if (serviceEx != null && serviceEx.Detail != null)
            {
                string message = serviceEx.Detail.Message;
                // U9服务抛出的异常，异常消息前都带异常名称，需要截掉
                int exNameEndIndex = message.IndexOf(":", 0);
                if(exNameEndIndex>=0)
                    message = message = message.Substring(exNameEndIndex+1, message.Length-exNameEndIndex-1);

                return message;
            }
            return ex.Message;
        }
    }
}

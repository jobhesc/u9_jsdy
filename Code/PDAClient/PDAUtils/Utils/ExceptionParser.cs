using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Services.Protocols;
using System.Xml;

namespace PDAClient.Utils
{
    /// <summary>
    /// webservice异常解析类
    /// </summary>
    public class ExceptionParser
    {
        /// <summary>
        /// 解析异常
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static string ParseError(Exception ex)
        {
            SoapException soapEx = ex as SoapException;
            if(soapEx != null)
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(soapEx.Detail.OuterXml);
                XmlNode categoryNode = doc.DocumentElement.SelectSingleNode("Error");
                if (categoryNode != null)
                {
                    XmlNode errNode = categoryNode.SelectSingleNode("ErrorMessage");
                    if (errNode != null)
                        return errNode.InnerText;
                }
            }

            return ex.Message;
        }
    }
}

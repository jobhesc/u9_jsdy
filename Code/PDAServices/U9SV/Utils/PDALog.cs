using System;
using System.Data;
using System.Configuration;
using System.Xml;
using System.IO;
using log4net;

namespace JSDY.U9SV.Utils
{
    /// <summary>
    /// PDA日志类
    /// </summary>
    // 由于PDALog类在类库中，PDALog.config的路径无法确定，因此放到代码里处理
    //[assembly: log4net.Config.XmlConfigurator(ConfigFile = "PDALog.config", Watch = true)]
    public class PDALog
    {
        static PDALog()
        {
            // 和配置文件关联
            string logfile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data\\PDALog.config");
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(logfile));

            log = log4net.LogManager.GetLogger(typeof(PDALog));
        }

        private static ILog log = null;

        public static void Error(object message)
        {
            log.Error(message);
        }
        public static void Fatal(object message)
        {
            log.Fatal(message);
        }
        public static void Info(object message)
        {
            log.Info(message);
        }
        public static void Debug(object message)
        {
            log.Debug(message);
        }
        public static void Warn(object message)
        {
            log.Warn(message);
        }
    }
}

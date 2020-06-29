using FarmaKode.Client.Properties;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaKode.Client.Util
{
    public class Logger
    {
        ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static Logger instance = null;
        public static Logger GetInstance()
        {
            if(instance==null)
            {
                initializeLog();
                instance = new Logger();
                return instance;
            }

            return instance;
        }

        private static void initializeLog()
        {
            string logDirectory = Settings.Default.LogPath;
            string logFileName = string.Format("{0:yyyyMMdd}_log.txt",DateTime.Now);
            log4net.Repository.ILoggerRepository repository = log4net.LogManager.GetRepository();
            foreach (log4net.Appender.IAppender appender in repository.GetAppenders())
            {
                if (appender.Name.CompareTo("FileAppender") == 0 && appender is log4net.Appender.FileAppender)
                {
                    log4net.Appender.FileAppender fileAppender = (log4net.Appender.FileAppender)appender;
                    fileAppender.File = System.IO.Path.Combine(Settings.Default.DestinationFolder, Settings.Default.LogPath, logFileName);
                    fileAppender.ActivateOptions();
                }
            }
        }

        public void Info(string message)
        {
            if (log.IsInfoEnabled)
                log.Info(message);
        }
      
        public void Debug(string message)
        {
            if (log.IsDebugEnabled)
                log.Debug(message);
        }

        public void Error(string message, Exception ex)
        {
            if (log.IsErrorEnabled)
                log.Error(message,ex);
        }


    }
}

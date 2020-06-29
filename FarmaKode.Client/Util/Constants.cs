using FarmaKode.Client.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaKode.Client.Util
{
    public class Constants
    {

        public const string XPathConfigFileName = "XPathConfig.xml";
        public static string LatestPostFolder = Path.Combine(Settings.Default.DestinationFolder, Settings.Default.LatestPostFolderName);
        public  struct ClearCahceType
        {
            public const int AfterParse = 0;
            public const int Daily = 1;
            public const int None = 2;
        }

        public struct BrowseType
        {
            public const int InternetExplorer = 0;
            public const int Chrome = 1;
            public const int Firefox = 2;
            public const int Opera = 3;
        }

        public enum NotificationAction
        {
            wait,
            start,
            close
        }

        public enum NotificationType
        {
            Success,
            Warning,
            Error,
            Info
        }

    }
}

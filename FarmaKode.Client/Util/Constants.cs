using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaKode.Client.Util
{
    public class Constants
    {
        public const string XPathConfigFileName = "XPathConfig.xml";

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
    }
}

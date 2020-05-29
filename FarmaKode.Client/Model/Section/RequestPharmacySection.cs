using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaKode.Client.Model.Section
{
    public class RequestPharmacySection
    {
        public string TransactionID { get; set; }
        public string FarmakodeID { get; set; }
        public string PCNO { get; set; }
        public string IPAddress { get; set; }
        public string TokenKey { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaKode.Client.Model.Response
{
    public class ResponseData
    {
        public string Pharmacy_name { get; set; }
        public string Pharmacy_phone { get; set; }
        public string Date { get; set; }
        public string Patient_name { get; set; }
        public bool Has_mobile_app { get; set; }
        public bool Supported_multi_lang { get; set; }
        public List<ResponseDrug> Drugs { get; set; }
    }
}

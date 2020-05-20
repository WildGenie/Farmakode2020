using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaKode.Client.Model
{
    public class ResponseDrug
    {
        public int Id { get; set; }
        public object Barcode { get; set; }
        public string Drug_name { get; set; }
        public string Diagnosis { get; set; }
        public string Suggestions { get; set; }
        public bool Has_warnings { get; set; }
        public string Warnings { get; set; }
        public DateTime Expiration_date { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaKode.Client.Model
{
    public class ReportData
    {
        public string PharmacyName { get; set; }
        public string DrugName { get; set; }
        public DateTime Date { get; set; }
        public string Diagnosis { get; set; }
        public string Suggestion { get; set; }
        public string PatientName { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}

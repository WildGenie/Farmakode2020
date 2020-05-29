using FarmaKode.Client.Model.Section;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaKode.Client.Model.Request
{
    public class RequestBarcode
    {
        public RequestPharmacySection PharmacySection { get; set; }
        public RequestHeaderSection HeaderSection { get; set; }
        public List<RequestDrugSection> DrugSection { get; set; }
        public List<RequestICDSection> ICDSection { get; set; }
        public RequestPriceSection PriceSection { get; set; }
    }
}

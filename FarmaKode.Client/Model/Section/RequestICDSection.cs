using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaKode.Client.Model.Section
{
    public class RequestPriceSection
    {
        public double KatkiPayiElden { get; set; }
        public double KatkiPayiMaastan { get; set; }
        public double MuayeneKatkiPayi { get; set; }
        public double MuayeneKatkiMaastan { get; set; }
        public double EczaneIndirimTutari { get; set; }
        public double IlacKatkiPayiTutari { get; set; }
        public double FiyatFarki { get; set; }
        public double ToplamTutar { get; set; }
        public double OdenecekTutar { get; set; }
        public double EczaneyeOdenecekTutar { get; set; }
    }
}

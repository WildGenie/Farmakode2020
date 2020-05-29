using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaKode.Client.Model.Section
{
    public class RequestDrugSection
    {
        public int Id { get; set; }
        public string Barkod { get; set; }
        public int Adet { get; set; }
        public int PeriyodDeger { get; set; }
        public string PeriyodTipi { get; set; }
        public int Doz { get; set; }
        public int DozMiktari { get; set; }
        public string Adi { get; set; }
        public double Tutar { get; set; }
        public double Fark { get; set; }
        public string Rapor { get; set; }
        public string VerilecebilecegiTarih { get; set; }
        public string Mesaj { get; set; }

       
    }

    

}

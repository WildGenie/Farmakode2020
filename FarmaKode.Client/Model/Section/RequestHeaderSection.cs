using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaKode.Client.Model.Section
{
    public class RequestHeaderSection
    {
        public long ReceteSahibiTC { get; set; }
        public long TeslimAlanTC { get; set; }
        public string IlaciTeslimAlan { get; set; }
        public string ReceteSahibiAd { get; set; }
        public string ReceteSahibiSoyad { get; set; }
        public string ReceteSahibiAdSoyad { get; set; }        
        public string TeslimAlanAd { get; set; }
        public string TeslimAlanSoyad { get; set; }
        public string ProvizyonTipi { get; set; }
        public string ProtokolNo { get; set; }
        public string TesisKodu { get; set; }
        public string ReceteTarihi { get; set; }
        public string ReceteNo { get; set; }
        public string KarekodDurumu { get; set; }
        public string Kapsam { get; set; }
        public string IlacAlimTarihi { get; set; }
        public string EReceteNo { get; set; }
        public string ReceteTuru { get; set; }
        public string ReceteAltTuru { get; set; }
        public string HastaTuru { get; set; }
        public string DiplomaTescilNo { get; set; }
        public string DrDiplomaNo { get; set; }
        public string DrAd { get; set; }
        public string DrSoyad { get; set; }
        public string Brans { get; set; }
        public string Sertifika { get; set; }
        public bool Karekodlu { get; set; }
        public bool SiraliDagitimRecetesi { get; set; }
    }
}

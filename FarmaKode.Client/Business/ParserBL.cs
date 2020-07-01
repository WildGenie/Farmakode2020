using FarmaKode.Client.Model;
using FarmaKode.Client.Model.Request;
using FarmaKode.Client.Model.Response;
using FarmaKode.Client.Model.Section;
using FarmaKode.Client.Properties;
using FarmaKode.Client.Util;
using HtmlAgilityPack;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FarmaKode.Client.Business
{
    public class ParserBL
    {

        private static ParserBL instance = null;

        public static ParserBL GetInstance()
        {
            if (instance == null)
            {
                instance = new ParserBL();
                return instance;
            }

            return instance;
        }

        private string RecursiveHtmlDecode(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return str;
            var tmp = HttpUtility.HtmlDecode(str);
            while (tmp != str)
            {
                str = tmp;
                tmp = HttpUtility.HtmlDecode(str);
            }
            return str; //completely decoded string
        }



        public List<ParsedData> Parse(string content)
        {

            HtmlDocument dokuman = new HtmlDocument();
            dokuman.LoadHtml(content);

            List<ParsedData> parsedData = new List<ParsedData>();

            foreach (var parameter in CacheBL.parameterList)
            {                 
                try
                {
                    string value = string.Empty;
                    if (parameter.Enabled)
                    {
                        if (parameter.IsRecursive)
                        {


                            for (int i = 0; i < parameter.RecursiveCount; i++)
                            {
                                string xpath = string.Format(parameter.XPath, i);
                                if (parameter.IsEditable)
                                {
                                    var node = dokuman.DocumentNode.SelectSingleNode(xpath);
                                    value = node == null ? string.Empty : node.GetAttributeValue("value", string.Empty);
                                }
                                else
                                {
                                    if (parameter.IsCombobox)
                                    {
                                        var node = dokuman.DocumentNode.SelectSingleNode(xpath + "/option[@selected='selected']");
                                        value = node == null ? string.Empty : node.InnerHtml;
                                    }
                                    else
                                    {
                                        var node = dokuman.DocumentNode.SelectSingleNode(xpath);
                                        value = node == null ? string.Empty : node.InnerHtml;
                                    }
                                }

                                ParsedData item = new ParsedData();
                                item.GroupId = (i + 1);
                                item.Section = parameter.Group;
                                item.Label = parameter.Label;
                                item.VariableName = parameter.VariableName;
                                item.Value = RecursiveHtmlDecode(value);
                                parsedData.Add(item);

                            }

                        }
                        else
                        {
                            if (parameter.IsEditable)
                            {
                                value = dokuman.DocumentNode.SelectSingleNode(parameter.XPath).GetAttributeValue("value", string.Empty);
                            }
                            else
                            {
                                if (parameter.IsCombobox)
                                    value = dokuman.DocumentNode.SelectSingleNode(parameter.XPath + "/option[@selected='selected']").InnerHtml;
                                else
                                    value = dokuman.DocumentNode.SelectSingleNode(parameter.XPath).InnerHtml;
                            }

                            ParsedData item = new ParsedData();
                            item.GroupId = 0;
                            item.Section = parameter.Group;
                            item.Label = parameter.Label;
                            item.VariableName = parameter.VariableName;
                            item.Value = RecursiveHtmlDecode(value);
                            parsedData.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(string.Format("{0} parametresi okunurken hata oluştu.", parameter.VariableName));
                }
            }

            Logger.GetInstance().Info("Medula reçetesi parametrelerine ayrıştırıldı");
            return parsedData;

        }

        public bool IsValidHTML(string content)
        {

            HtmlDocument dokuman = new HtmlDocument();
            dokuman.LoadHtml(content);
            
            var nodeReceteNo = dokuman.DocumentNode.SelectSingleNode("//*[@id=\"f:t13\"]");
            string receteNo = nodeReceteNo == null ? string.Empty : nodeReceteNo.InnerHtml;

            if (!(receteNo == "0" || receteNo=="")  && content.Contains(Settings.Default.IsParseableKeyword))
            {
                return true;
            }
            else
            {
                return false;
            }




        }

        public RequestBarcode CreateRequestModel(List<ParsedData> data)
        {
            try
            {

                RequestPharmacySection pharmacySection = new RequestPharmacySection();
                #region pharmacySection
                pharmacySection.TransactionID = new Guid().ToString();
                pharmacySection.FarmakodeID = Settings.Default.PharmacyID;
                pharmacySection.IPAddress = Common.GetPublicIp(Settings.Default.IPAddressServer);
                pharmacySection.PCNO = Settings.Default.PharmacyPCNO;
                pharmacySection.TokenKey = Settings.Default.PharmacyID;
                #endregion

                RequestHeaderSection headerSection = new RequestHeaderSection();
                #region headerSection
                headerSection.ReceteSahibiTC = GetLongValue(data, nameof(headerSection.ReceteSahibiTC));
                headerSection.TeslimAlanTC = GetLongValue(data, nameof(headerSection.TeslimAlanTC));
                headerSection.IlaciTeslimAlan = GetStringValue(data, nameof(headerSection.IlaciTeslimAlan));
                headerSection.ReceteSahibiAd = GetStringValue(data, nameof(headerSection.ReceteSahibiAd));
                headerSection.ReceteSahibiSoyad = GetStringValue(data, nameof(headerSection.ReceteSahibiSoyad));
                headerSection.ReceteSahibiAdSoyad = headerSection.ReceteSahibiAd + " " + headerSection.ReceteSahibiSoyad;
                headerSection.TeslimAlanAd = GetStringValue(data, nameof(headerSection.TeslimAlanAd));
                headerSection.TeslimAlanSoyad = GetStringValue(data, nameof(headerSection.TeslimAlanSoyad));
                headerSection.ProvizyonTipi = GetStringValue(data, nameof(headerSection.ProvizyonTipi));
                headerSection.ProtokolNo = GetStringValue(data, nameof(headerSection.ProtokolNo));
                headerSection.TesisKodu = GetStringValue(data, nameof(headerSection.TesisKodu));
                headerSection.ReceteTarihi = GetStringValue(data, nameof(headerSection.ReceteTarihi));
                headerSection.ReceteNo = GetStringValue(data, nameof(headerSection.ReceteNo));
                headerSection.KarekodDurumu = GetStringValue(data, nameof(headerSection.KarekodDurumu));
                headerSection.Kapsam = GetStringValue(data, nameof(headerSection.Kapsam));
                headerSection.IlacAlimTarihi = GetStringValue(data, nameof(headerSection.IlacAlimTarihi));
                headerSection.EReceteNo = GetStringValue(data, nameof(headerSection.EReceteNo));
                headerSection.ReceteTuru = GetStringValue(data, nameof(headerSection.ReceteTuru));
                headerSection.ReceteAltTuru = GetStringValue(data, nameof(headerSection.ReceteAltTuru));
                headerSection.HastaTuru = GetStringValue(data, nameof(headerSection.HastaTuru));
                headerSection.DiplomaTescilNo = GetStringValue(data, nameof(headerSection.DiplomaTescilNo));
                headerSection.DrDiplomaNo = GetStringValue(data, nameof(headerSection.DrDiplomaNo));
                headerSection.DrAd = GetStringValue(data, nameof(headerSection.DrAd));
                headerSection.DrSoyad = GetStringValue(data, nameof(headerSection.DrSoyad));
                headerSection.Brans = GetStringValue(data, nameof(headerSection.Brans));
                headerSection.Sertifika = GetStringValue(data, nameof(headerSection.Sertifika));
                headerSection.Karekodlu = GetBooleanValue(data, nameof(headerSection.Karekodlu));
                headerSection.SiraliDagitimRecetesi = GetBooleanValue(data, nameof(headerSection.SiraliDagitimRecetesi));
                #endregion

                List<RequestDrugSection> drugSection = new List<RequestDrugSection>();
                #region drugSection
                for (int i = 1; i < 6; i++)
                {
                    RequestDrugSection item = new RequestDrugSection();
                    item.Id = i;
                    item.Barkod = GetStringValue(data, nameof(item.Barkod), i);
                    if (!string.IsNullOrEmpty(item.Barkod))
                    {
                        item.Adet = GetIntValue(data, nameof(item.Adet), i);
                        item.PeriyodDeger = GetIntValue(data, nameof(item.PeriyodDeger), i);
                        item.PeriyodTipi = GetStringValue(data, nameof(item.PeriyodTipi), i);
                        item.Doz = GetIntValue(data, nameof(item.Doz), i);
                        item.DozMiktari = GetIntValue(data, nameof(item.DozMiktari), i);
                        item.Adi = GetStringValue(data, nameof(item.Adi), i);
                        item.Tutar = GetDoubleValue(data, nameof(item.Tutar), i);
                        item.Fark = GetDoubleValue(data, nameof(item.Fark), i);
                        item.Rapor = GetStringValue(data, nameof(item.Rapor), i);
                        string _VerilecebilecegiTarih = GetStringValue(data, nameof(item.VerilecebilecegiTarih), i);
                        if (string.IsNullOrEmpty(_VerilecebilecegiTarih))
                            item.VerilecebilecegiTarih = DateTime.MinValue;
                        else
                            item.VerilecebilecegiTarih = DateTime.Parse(_VerilecebilecegiTarih);



                        item.Mesaj = GetStringValue(data, nameof(item.Mesaj), i);
                        drugSection.Add(item);
                    }
                }
                #endregion


                List<RequestICDSection> icdSection = new List<RequestICDSection>();
                #region icdSection
                for (int i = 1; i < 6; i++)
                {
                    RequestICDSection item = new RequestICDSection();
                    item.Kod = GetStringValue(data, nameof(item.Kod), i);
                    item.Tani = GetStringValue(data, nameof(item.Tani), i);

                    if (!string.IsNullOrEmpty(item.Kod) && !string.IsNullOrEmpty(item.Tani))
                        icdSection.Add(item);
                }
                #endregion

                RequestPriceSection priceSection = new RequestPriceSection();
                #region priceSection
                priceSection.KatkiPayiElden = GetDoubleValue(data, nameof(priceSection.KatkiPayiElden));
                priceSection.KatkiPayiMaastan = GetDoubleValue(data, nameof(priceSection.KatkiPayiMaastan));
                priceSection.MuayeneKatkiPayi = GetDoubleValue(data, nameof(priceSection.MuayeneKatkiPayi));
                priceSection.MuayeneKatkiMaastan = GetDoubleValue(data, nameof(priceSection.MuayeneKatkiMaastan));
                priceSection.EczaneIndirimTutari = 0;// GetDoubleValue(data, nameof(priceSection.EczaneIndirimTutari));
                priceSection.IlacKatkiPayiTutari = GetDoubleValue(data, nameof(priceSection.IlacKatkiPayiTutari));
                priceSection.FiyatFarki = GetDoubleValue(data, nameof(priceSection.FiyatFarki));
                priceSection.ToplamTutar = GetDoubleValue(data, nameof(priceSection.ToplamTutar));
                priceSection.OdenecekTutar = GetDoubleValue(data, nameof(priceSection.OdenecekTutar));
                priceSection.EczaneyeOdenecekTutar = GetDoubleValue(data, nameof(priceSection.EczaneyeOdenecekTutar));
                #endregion


                RequestBarcode requestBarcode = new RequestBarcode();
                requestBarcode.DrugSection = drugSection;
                requestBarcode.HeaderSection = headerSection;
                requestBarcode.ICDSection = icdSection;
                requestBarcode.PharmacySection = pharmacySection;
                requestBarcode.PriceSection = priceSection;


                return requestBarcode;

            }
            catch (Exception ex)
            {
                string message = "Requerst modeli oluşturulamadı";
                Logger.GetInstance().Error(message, ex);
                throw new Exception(message, ex);
            }
        }

        public RequestBarcode CreatRetailRequest(List<string> barcods)
        {
            try
            {

                RequestPharmacySection pharmacySection = new RequestPharmacySection();
                #region pharmacySection
                pharmacySection.TransactionID = new Guid().ToString();
                pharmacySection.FarmakodeID = Settings.Default.PharmacyID;
                pharmacySection.IPAddress = Common.GetPublicIp(Settings.Default.IPAddressServer);
                pharmacySection.PCNO = Settings.Default.PharmacyPCNO;
                pharmacySection.TokenKey = Settings.Default.PharmacyID;
                #endregion

                RequestHeaderSection headerSection = new RequestHeaderSection();
                #region headerSection               
                headerSection.ReceteNo = DateTime.Now.ToString("yyyyMMdd_HHmm_") + "Perakende";
                #endregion

                List<RequestDrugSection> drugSection = new List<RequestDrugSection>();
                #region drugSection

                for (int i = 0; i < barcods.Count; i++)
                {
                    RequestDrugSection item = new RequestDrugSection();
                    item.Id = i + 1;
                    item.Barkod = barcods[i];
                    drugSection.Add(item);

                }
                #endregion

                RequestBarcode requestBarcode = new RequestBarcode();
                requestBarcode.DrugSection = drugSection;
                requestBarcode.PharmacySection = pharmacySection;
                requestBarcode.HeaderSection = headerSection;


                return requestBarcode;

            }
            catch (Exception ex)
            {
                string message = "Requerst modeli oluşturulamadı";
                Logger.GetInstance().Error(message, ex);
                throw new Exception(message, ex);
            }
        }

        public T GetObjectFromJsonFile<T>(string jsonFilePath, JsonSerializerSettings serializerSettings = null)
        {
            try
            {
                string content = string.Empty;
                using (FileStream fs = new FileStream(jsonFilePath, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sw = new StreamReader(fs))
                    {
                        content = sw.ReadToEnd();
                        sw.Close();

                    }
                    fs.Close();

                    return JsonConvert.DeserializeObject<T>(content, serializerSettings);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(jsonFilePath + " dosyası okunamadı", ex);
            }
        }

        private void SaveResponse(string folder, ResponseBarcode responseBarcode)
        {
            try
            {
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                #region Save Response

                string path = Path.Combine(folder, responseBarcode.ReceteNo + "_Response.json");
                string jsonContent = JsonConvert.SerializeObject(responseBarcode, Formatting.Indented);
                //File.WriteAllText(path, jsonContent, Encoding.UTF8);
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(jsonContent);
                        sw.Close();
                    }
                    fs.Close();
                }

                #endregion


                Logger.GetInstance().Info("Reçete response son işlemler kalsörüne kayıt edildi");
            }
            catch (Exception ex)
            {
                string message = "Reçete response son işlemler klasörüne yazılamadı";
                Logger.GetInstance().Error(message, ex);
                throw new Exception(message, ex);
            }
        }

        private void SaveResponse(string folder, string receteNo, string content)
        {
            try
            {
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                #region Save Response

                string path = Path.Combine(folder, receteNo + "_Response.json");
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(content);
                        sw.Close();
                    }
                    fs.Close();
                }

                #endregion


                Logger.GetInstance().Info("Reçete response son işlemler kalsörüne kayıt edildi");
            }
            catch (Exception ex)
            {
                string message = "Reçete response son işlemler klasörüne yazılamadı";
                Logger.GetInstance().Error(message, ex);
                throw new Exception(message, ex);
            }
        }

        private void SaveRequest(string folder, RequestBarcode requestBarcode)
        {
            try
            {
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                #region Save Request

                string path = Path.Combine(folder, requestBarcode.HeaderSection.ReceteNo + "_Request.json");
                string jsonContent = JsonConvert.SerializeObject(requestBarcode, Formatting.Indented);
                //File.WriteAllText(path, jsonContent, Encoding.UTF8);
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(jsonContent);
                        sw.Close();
                    }
                    fs.Close();
                }

                #endregion


                Logger.GetInstance().Info("Reçete request i son işlemler klasörüne kayıt edildi");
            }
            catch (Exception ex)
            {
                string message = "Reçete request i son işlemler klasörüne yazılamadı";
                Logger.GetInstance().Error(message, ex);
                throw new Exception(message, ex);
            }
        }

        public ResponseBarcode PostRequest(RequestBarcode requestBarcode)
        {
            try
            {
                var client = new RestClient(Settings.Default.ApiURL);
                string jsonContent = JsonConvert.SerializeObject(requestBarcode, Formatting.Indented);
                var request = new RestRequest();
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(requestBarcode);
                var response = client.Post(request);

                SaveRequest(Constants.LatestPostFolder, requestBarcode); 

                if (response.IsSuccessful)
                {
                     JsonSerializerSettings settings = new JsonSerializerSettings();
                    settings.Culture = new System.Globalization.CultureInfo("tr-TR");
                    settings.DateFormatString = "dd.MM.yyyy";
                    ResponseBarcode responseBarcode = JsonConvert.DeserializeObject<ResponseBarcode>(response.Content, settings);
                   
                    responseBarcode.ReceteNo = requestBarcode.HeaderSection.ReceteNo;

                    SaveResponse(Constants.LatestPostFolder, responseBarcode);
                    return responseBarcode;
                }
                else
                {
                    SaveResponse(Constants.LatestPostFolder, requestBarcode.HeaderSection.ReceteNo, response.Content);
                    throw new Exception("Web servisten reçete detayları alınamadı."+ response.Content);
                }


            }
            catch (Exception ex)
            {
                Logger.GetInstance().Error("Post metodu çalışırken hata oluştu", ex);
                throw ex;
            }

        }

        public ResponseBarcode PostRetailRequest(RequestBarcode requestBarcode)
        {
            try
            {
                var client = new RestClient(Settings.Default.ApiURL);
                string jsonContent = JsonConvert.SerializeObject(requestBarcode, Formatting.Indented);
                var request = new RestRequest();
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(requestBarcode);
                var response = client.Post(request);

                SaveRequest(Constants.LatestPostFolder, requestBarcode);

                if (response.IsSuccessful)
                {
                     JsonSerializerSettings settings = new JsonSerializerSettings();
                    settings.Culture = new System.Globalization.CultureInfo("tr-TR");
                    settings.DateFormatString = "dd.MM.yyyy";
                    ResponseBarcode responseBarcode = JsonConvert.DeserializeObject<ResponseBarcode>(response.Content, settings);

                    responseBarcode.ReceteNo = requestBarcode.HeaderSection.ReceteNo;
                    SaveResponse(Constants.LatestPostFolder, responseBarcode);
                    return responseBarcode;
                }
                else
                {
                    SaveResponse(Constants.LatestPostFolder, requestBarcode.HeaderSection.ReceteNo, response.Content);
                    throw new Exception("Web servisten reçete detayları alınamadı");
                }
            }
            catch (Exception ex)
            {
                Logger.GetInstance().Error("Post metodu çalışırken hata oluştu", ex);
                throw new Exception("Web servisten reçete detayları alınamadı");
            }

        }

        #region Reader functions

        int GetIntValue(List<ParsedData> data, string key, int groupId = 0)
        {
            int value = 0;
            var item = data.Where(p => p.VariableName == key && p.GroupId == groupId).SingleOrDefault();
            if (item != null)
            {
                if (int.TryParse(item.Value, out value))
                {
                    return value;
                }
            }
            return value;
        }

        long GetLongValue(List<ParsedData> data, string key, int groupId = 0)
        {
            long value = 0;
            var item = data.Where(p => p.VariableName == key && p.GroupId == groupId).SingleOrDefault();
            if (item != null)
            {
                if (long.TryParse(item.Value, out value))
                {
                    return value;
                }
            }
            return value;
        }

        double GetDoubleValue(List<ParsedData> data, string key, int groupId = 0)
        {
            double value = 0;
            var item = data.Where(p => p.VariableName == key && p.GroupId == groupId).SingleOrDefault();
            if (item != null)
            {
                if (double.TryParse(item.Value, out value))
                {
                    return value;
                }
            }
            return value;
        }

        string GetStringValue(List<ParsedData> data, string key, int groupId = 0)
        {
            var item = data.Where(p => p.VariableName == key && p.GroupId == groupId).SingleOrDefault();
            return item == null ? string.Empty : item.Value.Trim() ?? string.Empty;
        }

        bool GetBooleanValue(List<ParsedData> data, string key, int groupId = 0)
        {
            bool value = false;
            var item = data.Where(p => p.VariableName == key && p.GroupId == groupId).SingleOrDefault();
            if (item != null)
            {
                if (bool.TryParse(item.Value, out value))
                {
                    return value;
                }
            }
            return value;
        }
        #endregion
    }
}

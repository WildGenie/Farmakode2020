using FarmaKode.Client.Model;
using FarmaKode.Client.Util;
using HtmlAgilityPack;
using Newtonsoft.Json;
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

        public List<ParsedData> ParseFromFile(string jsonFilePath)
        {
            try
            {
                string content = File.ReadAllText(jsonFilePath, Encoding.Default);
                return JsonConvert.DeserializeObject<List<ParsedData>>(content) ;
            }
            catch (Exception ex)
            {
                throw new Exception(jsonFilePath +" dosyası okunamadı", ex);
            }
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
                                    value = dokuman.DocumentNode.SelectSingleNode(xpath).GetAttributeValue("value", string.Empty);
                                }
                                else
                                {
                                    if (parameter.IsCombobox)
                                        value = dokuman.DocumentNode.SelectSingleNode(xpath + "/option[@selected='selected']").InnerHtml;
                                    else
                                        value = dokuman.DocumentNode.SelectSingleNode(xpath).InnerHtml;
                                }

                                ParsedData item = new ParsedData();
                                item.GroupId =(i+1);
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
                    throw new Exception(string.Format("{0} parametresi okunurken hata oluştu.",parameter.VariableName));
                }
            }



            //Section section = new Section();
            //section.DrugSection = new List<Drug>();
            //section.HeaderSection = new List<ParsedData>();
            //foreach (var item in parsedData)
            //{
            //    if (item.Section == "HeaderSection")
            //        section.HeaderSection.Add(item);
            //}

            //List<ParsedData> parsedDrugList = parsedData.Where(p => p.Section == "DrugSection").ToList();

            //var drugList = parsedDrugList.OrderBy(drug => drug.GroupId).GroupBy(drug => drug.GroupId);

            //foreach (var drug in drugList)
            //{
            //    foreach (var drugDetail in drug)
            //    {
                    
            //    }
            //}

            return parsedData;

        }

        public void SavePost(string folder, List<ParsedData> data)
        {
            try
            {
                if (!Directory.Exists(folder))                
                    Directory.CreateDirectory(folder);

                string path = Path.Combine(folder, DateTime.Now.ToString("yyyyMMddHHmmss")+ ".json");
                string jsonContent = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(path, jsonContent, Encoding.Default);
                System.Threading.Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                string message = "Okunan reçete bilgileri son işlemler listesine yazılamadı";
                Logger.GetInstance().Error(message, ex);
                throw new Exception(message, ex);
            }
        }
    }
}

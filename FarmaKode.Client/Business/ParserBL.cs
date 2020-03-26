using FarmaKode.Client.Model;
using HtmlAgilityPack;
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

        public Section Parse(string filePath)
        {
            string content = File.ReadAllText(filePath, Encoding.Default);
            HtmlDocument dokuman = new HtmlDocument();
            dokuman.LoadHtml(content);

            List<ParsedData> data = new List<ParsedData>();
            


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
                                item.LoopId =i;
                                item.Group = parameter.Group;
                                item.Label = parameter.Label;
                                item.VariableName = parameter.VariableName;
                                item.Value = RecursiveHtmlDecode(value);
                                data.Add(item);

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
                            item.LoopId = 0;
                            item.Group = parameter.Group;
                            item.Label = parameter.Label;
                            item.VariableName = parameter.VariableName;
                            item.Value = RecursiveHtmlDecode(value);
                            data.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(string.Format("{0} parametresi okunurken hata oluştu.",parameter.VariableName));
                }
            }



            Section section = new Section();
            section.DrugSection = new List<ParsedData>();
            section.HeaderSection = new List<ParsedData>();
            foreach (var item in data)
            {
                if (item.Group == "HeaderSection")
                    section.HeaderSection.Add(item);
                else if (item.Group == "DrugSection")
                    section.DrugSection.Add(item);

            }

            return section;

        }
    }
}

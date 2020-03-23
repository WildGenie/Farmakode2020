using FarmaKode.Client.Model;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public void Parse(string filePath)
        {
            string content = File.ReadAllText(filePath, Encoding.Default);
            HtmlDocument dokuman = new HtmlDocument();
            dokuman.LoadHtml(content);

            List<RequestData> requestDatas = new List<RequestData>();
             
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

                                RequestData data = new RequestData();
                                data.LoopId = ++i;
                                data.Group = parameter.Group;
                                data.Label = parameter.Label;
                                data.VariableName = parameter.VariableName;
                                data.Value = value;
                                requestDatas.Add(data);
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

                            RequestData data = new RequestData();
                            data.LoopId = 0;
                            data.Group = parameter.Group;
                            data.Label = parameter.Label;
                            data.VariableName = parameter.VariableName;
                            data.Value = value;
                            requestDatas.Add(data);
                        }
                    }
                }
                catch (Exception ex)
                {


                }
            }


        }
    }
}

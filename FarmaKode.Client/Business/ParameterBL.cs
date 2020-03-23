using FarmaKode.Client.Model;
using FarmaKode.Client.Properties;
using FarmaKode.Client.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FarmaKode.Client.Business
{
    public class ParameterBL
    {
        private string XmlPath = string.Empty;
        private string ConfigFilePath = Path.Combine(Application.StartupPath, Settings.Default.XPathConfigFilePath);

        private static ParameterBL instance = null; 
        public static ParameterBL GetInstance()
        {
            if (instance == null)
            {              
                instance = new ParameterBL();
                return instance;
            }

            return instance;
        }


        public List<Parameter> GetParameters()
        {
            try
            {
                
                string jsonContent = File.ReadAllText(ConfigFilePath);
                List<Parameter> parameterList = JsonConvert.DeserializeObject<List<Parameter>>(jsonContent).ToList();
                int i = 1;
                parameterList.ForEach(p => p.Id = i++);
                return parameterList;
            }
            catch (Exception ex)
            {
                string message = "Reçete okuma bilgileri xml den alınamadı";
                Logger.GetInstance().Error(message, ex);
                throw new Exception(message, ex);
            }

        }

        public void SetParameters(List<Parameter> parameters)
        {
            try
            {
                string jsonContent = JsonConvert.SerializeObject(parameters, Formatting.Indented);
                File.WriteAllText(ConfigFilePath,jsonContent,Encoding.UTF8);
                Logger.GetInstance().Info("Reçete okuma ayarları değiştirildi");
            }
            catch (Exception ex)
            {
                string message = "Reçete okuma ayarları kayıt edilemedi";
                Logger.GetInstance().Error(message, ex);
                throw new Exception(message, ex);
            }

        } 
    }
}

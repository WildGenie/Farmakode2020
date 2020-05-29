using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaKode.Client.Model.Response
{
    public class ResponseBarcode
    {
        public string Result { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Print_url { get; set; }
        public string Name_surname { get; set; }

        public string ReceteNo { get; set; }
        public ResponseData Data { get; set; }
    }
}

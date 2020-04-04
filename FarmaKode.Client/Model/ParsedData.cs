using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaKode.Client.Model
{
    public class ParsedData
    {
        public string Section { get; set; }
        public string Label { get; set; }
        public string VariableName { get; set; }
        public string Value { get; set; }
        public int GroupId { get; set; }
    }
}

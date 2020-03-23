using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaKode.Client.Model
{
    public class Parameter
    {
        public int Id { get; set; }
        public bool Enabled { get; set; }
        public string Group { get; set; }
        public string Label { get; set; }
        public string VariableName { get; set; }
        public string XPath { get; set; } 
        public bool IsRecursive { get; set; }
        public int RecursiveCount { get; set; }
        public bool IsCombobox { get; set; }
        public bool IsEditable { get; set; }

       
    }


}

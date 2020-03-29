using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaKode.Client.Model
{
    public class Section
    {
        public List<ParsedData> HeaderSection { get; set; }
        public List<Drug> DrugSection { get; set; }
    }
}

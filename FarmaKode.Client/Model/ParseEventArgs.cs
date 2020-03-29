using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaKode.Client.Model
{

    public class ParseEventArgs : EventArgs
    {
        public string FilePath { get; set; }

        public ParseEventArgs(string filePath)
        {
            FilePath = filePath;
        }

    }
}

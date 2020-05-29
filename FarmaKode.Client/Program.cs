using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FarmaKode.Client.Business;
using FarmaKode.Client.Model.Section;
using HtmlAgilityPack;
namespace FarmaKode.Client
{
    static class Program
    {
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //FarmaKode.Client_TemporaryKey parolası FarmaKode
            CacheBL.LoadCache();

 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           

            Application.Run(new FormButton());
        }


    }
}

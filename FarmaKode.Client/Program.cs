﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FarmaKode.Client.Business;

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
            //Application.Run(new MainForm());
        }


    }
}

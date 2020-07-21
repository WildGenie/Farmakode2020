using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using FarmaKode.Client.Business;
using FarmaKode.Client.Model.Section;
using FarmaKode.Client.Util;
using HtmlAgilityPack;
using Microsoft.Win32;

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


            Common.AddShortcutToStartup();


            var wi = WindowsIdentity.GetCurrent();
            var wp = new WindowsPrincipal(wi);

            bool runAsAdmin = wp.IsInRole(WindowsBuiltInRole.Administrator);

            if (!runAsAdmin)
            {
                // It is not possible to launch a ClickOnce app as administrator directly,
                // so instead we launch the app as administrator in a new process.
                var processInfo = new ProcessStartInfo(Assembly.GetExecutingAssembly().CodeBase);

                // The following properties run the new process as administrator
                processInfo.UseShellExecute = true;
                processInfo.Verb = "runas";

                // Start the new process
                try
                {
                    Process.Start(processInfo);
                }
                catch (Exception)
                {
                    // The user did not allow the application to run as administrator
                    KryptonMessageBox.Show("Yönetici (Admin) rolünde olmadığınız için uygulamayı çalıştıramazsınız");
                }

                // Shut down the current process
                Application.Exit();
            }
            else
            {
                // We are running as administrator
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormButton());
            }

            //RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            //rk.SetValue("FarmaKode.Client.exe", Application.ExecutablePath);

          
        }


    }
}

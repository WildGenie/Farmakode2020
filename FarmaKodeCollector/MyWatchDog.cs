using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaKodeCollector
{
    public class MyWatchDog
    {
        ILog log = log4net.LogManager.GetLogger(typeof(MyWatchDog));
        FileSystemWatcher fsw = null;
        string source = null;
        string destination = null;
        string extension = null;
        public MyWatchDog(string source, string destination, string extension)
        {
            this.source = source;
            this.extension = extension;
            this.destination = destination;
        }
        public void baslat()
        {
            try
            {
                fsw = new FileSystemWatcher(source);
                fsw.Filter = extension;
                // fsw.Filter = "*.*";
                fsw.IncludeSubdirectories = true;
                fsw.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName;


                fsw.Created += new FileSystemEventHandler(yaratildi);
                fsw.Changed += new FileSystemEventHandler(degisti);
                fsw.Renamed += new RenamedEventHandler(isimdegisti);
                fsw.Deleted += new FileSystemEventHandler(silindi);
                //
                fsw.EnableRaisingEvents = true;
                log.InfoFormat("----------------[{0}] Klasöründe dosya izleme basladi----------------", source);
            }
            catch
            {
                log.Error("Yol adını giriniz.örnek,C:\\dosya");
            }
        }

        public void durdur()
        {
            if (fsw != null)
            {
                fsw.EnableRaisingEvents = false;
                log.InfoFormat("----------------[{0}] Klasöründe dosya izleme durdu----------------", source);
            }
        }

        void yaratildi(object gelen, FileSystemEventArgs e)
        {

            log.InfoFormat("{0} dizininde {1} adında yeni dosya olusturuldu", source, e.Name);
            hedefeKopyala(e.FullPath);

        }
        void degisti(object gelen, FileSystemEventArgs e)
        {
            log.InfoFormat("{0} dizinindeki {1} dosyası degisti", source, e.Name);
            hedefeKopyala(e.FullPath);

        }
        void isimdegisti(object gelen, RenamedEventArgs e)
        {
            log.InfoFormat("{0} dizinindeki '{1}' dosyasının ismi '{2}' olarak degisti", source, e.OldName, e.Name);
            hedefeKopyala(e.FullPath);
        }
        void silindi(object gelen, FileSystemEventArgs e)
        {
            log.InfoFormat("{0} dizinindeki {1} dosyası silindi", source, e.Name);
        }

        void hedefeKopyala(string source)
        {
            string fileName = Path.GetFileName(source);
            string destFileName = Path.Combine(this.destination, fileName);
            File.Copy(source, destFileName, true);

        }

    }
}

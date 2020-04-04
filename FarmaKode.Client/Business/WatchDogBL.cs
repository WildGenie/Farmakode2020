using FarmaKode.Client.Model;
using FarmaKode.Client.Util;
using System;
using System.ComponentModel;
using System.IO;

namespace FarmaKode.Client.Business
{
    public class WatchDogBL
    {
        
        FileSystemWatcher fsw = null;
        string source = null;
        string destination = null;
        string extension = null;
        bool copyToDestination = false;

        [Browsable(true)]
        [Category("Olaylar")]
        [Description("Yeni bir dosya oluştuğunda dosya içeriği parse edilir")]
        public event EventHandler<ParseEventArgs> ParseFileEvent;

        public WatchDogBL(string source, string destination, string extension, bool copyToDestination)
        {
            this.source = source;
            this.extension = extension;
            this.destination = destination;
            this.copyToDestination = copyToDestination;
        }

        public void Start()
        {
            try
            {
                fsw = new FileSystemWatcher(source);
                fsw.Filter = extension;
                fsw.IncludeSubdirectories = true;
                fsw.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName;


                fsw.Created += new FileSystemEventHandler(Created);
                //fsw.Changed += new FileSystemEventHandler(Changed);
                //fsw.Renamed += new RenamedEventHandler(Renamed);
                fsw.Deleted += new FileSystemEventHandler(Deleted);
                //
                fsw.EnableRaisingEvents = true;
                Logger.GetInstance().Info(string.Format("[{0}] Klasöründe dosya izleme basladi", source));
            }
            catch
            {
                Logger.GetInstance().Error("Yol adını giriniz.örnek,C:\\dosya",null);
            }
        }

        public void Stop()
        {
            if (fsw != null)
            {
                fsw.EnableRaisingEvents = false;
                Logger.GetInstance().Info(string.Format("[{0}] Klasöründe dosya izleme durdu", source));
            }
        }

        void Created(object gelen, FileSystemEventArgs e)
        {
            Logger.GetInstance().Info(string.Format("{0} dizininde {1} adında yeni dosya olusturuldu", source, e.Name));
            CopyDestination(e.FullPath);

            ParseFileEvent?.Invoke(this, new ParseEventArgs(e.FullPath));
        }

        void Changed(object gelen, FileSystemEventArgs e)
        {
            Logger.GetInstance().Info(string.Format("{0} dizinindeki {1} dosyası degisti", source, e.Name));
            CopyDestination(e.FullPath);
        }

        void Renamed(object gelen, RenamedEventArgs e)
        {
            Logger.GetInstance().Info(string.Format("{0} dizinindeki '{1}' dosyasının ismi '{2}' olarak degisti", source, e.OldName, e.Name));
            CopyDestination(e.FullPath);
        }

        void Deleted(object gelen, FileSystemEventArgs e)
        {
            Logger.GetInstance().Info(string.Format("{0} dizinindeki {1} dosyası silindi", source, e.Name));
        }

        void CopyDestination(string source)
        {
            if (copyToDestination)
            {
                try
                {
                    string fileName = Path.GetFileName(source);
                    string destFileName = Path.Combine(this.destination, fileName);
                    File.Copy(source, destFileName, true);
                }
                catch (Exception ex)
                {
                    Logger.GetInstance().Error("Dosya hedef klasöre taşınamadı", ex);
                }
            }
        }

        

    }
}

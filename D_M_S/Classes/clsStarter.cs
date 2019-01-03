using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace D_M_S.Classes
{
    public class clsStarter
    {
        public void CreateFolderInMyDocuments()
        {
            string FolderName = "DMS Folder";
            string LocationPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), FolderName);
            if (!Directory.Exists(LocationPath))
            {
                Directory.CreateDirectory(LocationPath);
            }
        }
        public bool CheckMyAppConfig()
        {
            bool result = false;
            try
            {
                string AppName = System.AppDomain.CurrentDomain.FriendlyName;
             
                string ConfigFile = Environment.CurrentDirectory + "\\" + AppName.Replace(".exe", ".ini");
                if(File.Exists(ConfigFile))
                { 
                    result = true;
                }
            }
            catch
            {
            }
            return result;
        }
    }
}

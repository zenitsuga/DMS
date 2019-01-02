using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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

    }
}

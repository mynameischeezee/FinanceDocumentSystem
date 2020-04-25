using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FinanceDocumentSystem.Business_Logic.Class;

namespace FinanceDocumentSystem.Data_Access
{
    public static class CleanDocumentFolder
    {
        private static DirectoryInfo Directory = new DirectoryInfo(DataSettings.DocumentFolderPath);
        public static void DeleteDocuments()
        {
            foreach (FileInfo file in Directory.GetFiles())
            {
                file.Delete();
            }
        }
    }
}
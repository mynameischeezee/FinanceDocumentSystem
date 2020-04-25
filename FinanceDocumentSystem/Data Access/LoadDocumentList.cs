using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FinanceDocumentSystem.Business_Logic.Class;


namespace FinanceDocumentSystem.Data_Access
{
    public static class LoadDocumentList
    {
        private static DirectoryInfo Directory = new DirectoryInfo(DataSettings.DocumentFolderPath);
        private static FileInfo[] Files = Directory.GetFiles("*.json");

        public static void LoadDocuments()
        {
            foreach (FileInfo file in Files)
            {
                MainDocumentLogic.AddDocument(JsonDeserialization.DeSerializeObject<Document>(file.FullName));
            }
        }

    }
}

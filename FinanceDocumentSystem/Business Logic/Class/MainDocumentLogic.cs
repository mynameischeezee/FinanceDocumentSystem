using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FinanceDocumentSystem.Data_Access;

namespace FinanceDocumentSystem.Business_Logic.Class
{
   public static class MainDocumentLogic
    {
        public static DocumentLogic logic;

        public static List<Document> DocumentList = new List<Document>();

        public static void AddDocument(Document document)
        {
            DocumentList.Add(document);
        }
        public static void DeleteDocument(Document document)
        {
            DocumentList.Remove(document);

        }

        public static void SerializeDocumentList()
        {
            foreach (Document document in DocumentList)
            {
                
                JsonSerialization.SerializeObject(document, DataSettings.DocumentFolderPath, Convert.ToString(document.ID));
            }
        }
    }
}

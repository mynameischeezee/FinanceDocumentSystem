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
        public static DocumentIDLogic logic;

        public static List<Document> DocumentList = new List<Document>();

        public static void AddDocument(Document document)
        {
            DocumentList.Add(document);
        }
        public static void DeleteDocument(Document document)
        {
            DocumentList.Remove(document);

        }
    }
}

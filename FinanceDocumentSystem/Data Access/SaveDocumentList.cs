using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FinanceDocumentSystem.Business_Logic.Class;

namespace FinanceDocumentSystem.Data_Access
{
   public static class SaveDocumentList
    {
        public static void SerializeDocumentList()
        {
            foreach (Document document in MainDocumentLogic.DocumentList)
            {

                JsonSerialization.SerializeObject(document, DataSettings.DocumentFolderPath, Convert.ToString(document.ID));
            }
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FinanceDocumentSystem.Data_Access
{
   public static class JsonSerialization
    {
        public static void SerializeObject(object Obj, string Path, string FileName)
        {
            string SerializeResult = JsonConvert.SerializeObject(Obj);
            File.WriteAllText(Path + @"\" + FileName + ".json", SerializeResult);
            
        }

    }
}

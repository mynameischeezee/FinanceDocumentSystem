using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace FinanceDocumentSystem.Data_Access
{
    public static class JsonDeserialization
    {
        public static T DeSerializeObject<T>(object Obj, string Path, string FileName)
        {
            string ReadFile = File.ReadAllText(Path + @"\" + FileName + ".json");
            //return (object)JsonConvert.DeserializeObject(ReadFile);
            return (T)JsonConvert.DeserializeObject<T>(ReadFile); 
            
        }
        public static object DeSerializeObject( string Path, string FileName)
        {
            string ReadFile = File.ReadAllText(Path + @"\" + FileName + ".json");
            return JsonConvert.DeserializeObject(ReadFile);


        }
        public static T DeSerializeObject<T>(string Path)
        {
            string ReadFile = File.ReadAllText(Path);
            return (T)JsonConvert.DeserializeObject<T>(ReadFile);


        }
    }
}

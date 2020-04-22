using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FinanceDocumentSystem.Data_Access
{
    static class DataSettings
    {
        private static string _MainFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\FDS\Data\";
        private static string _DocumentFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\FDS\Data\Documents";
        private static string _SettingsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\FDS\Data\Settings";



        public static string MainFolderPath
        {
            get { return _MainFolderPath; }
            private set { MainFolderPath = value; }
        }

        public static string DocumentFolderPath
        {
            get { return _DocumentFolderPath; }
            private set { DocumentFolderPath = value; }
        }
        public static string SettingsFolderPath
        {
            get { return _SettingsFolderPath; }
            private set { SettingsFolderPath = value; }
        }

        public static void CreateSettingsFile()
        {
            if (!File.Exists(SettingsFolderPath + @"\" + "DocumentSettings" + ".json "))
            {
                FileStream FileCreate = File.Create(SettingsFolderPath + @"\" + "DocumentSettings" + ".json");
                FileCreate.Close();
                File.WriteAllText(SettingsFolderPath + @"\" + "DocumentSettings" + ".json", "{\"CurrentID\":1}");
            }
        }

        public static void CheckIfMainFolderExists()
        {
            if (!Directory.Exists(MainFolderPath))
            {
                Directory.CreateDirectory(MainFolderPath);
            }
        }
        public static void CheckDocumentnFolderExists()
        {
            if (!Directory.Exists(DocumentFolderPath))
            {
                Directory.CreateDirectory(DocumentFolderPath);
            }
        }
        public static void CheckSettingsFolderExists()
        {
            if (!Directory.Exists(SettingsFolderPath))
            {
                Directory.CreateDirectory(SettingsFolderPath);
            }
        }
    }

}

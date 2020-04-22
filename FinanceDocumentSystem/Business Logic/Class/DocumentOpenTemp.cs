using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceDocumentSystem.Data_Access;
using FinanceDocumentSystem.Business_Logic.Enum;
using FinanceDocumentSystem.Presentation.User_Controls;

namespace FinanceDocumentSystem.Business_Logic.Class
{
   public static class DocumentOpenTemp
    {
        private static string Path = DataSettings.SettingsFolderPath + @"\" + "DocumentSettings" + ".json ";
        private static string Name = "";
        private static string Text = "";
        private static string Sender = "";
        private static bool Status = false;
        private static int ID = 0;
        private static string Date = DateTime.Now.Date.ToString("d");
        private static DocumentType Type;

        public static string DocumentPath
        {
            get { return Path; }
            private set { DocumentPath = value; }
        }
        public static string DocumentName
        {
            get { return Name; }
            private set { DocumentName = value; }
        }
        public static string DocumentText
        {
            get { return Text; }
            private set { DocumentText = value; }
        }
        public static string DocumentSender
        {
            get { return Sender; }
            private set { DocumentSender = value; }
        }
        public static bool DocumentStatus
        {
            get { return Status; }
            private set { DocumentStatus = value; }
        }
        public static int DocumentID
        {
            get { return ID; }
            private set { DocumentID = value; }
        }
        public static string DocumentDate
        {
            get { return Date; }
            private set { DocumentDate = value; }
        }
        public static DocumentType TypeOfDocument
        {
            get { return Type; }
            private set { TypeOfDocument = value; }
        }
        public static void SetDocumentPath(string FilePath)
        {
            Path = FilePath;
        }

        public static void SetDocumentName(string FileName)
        {
            Name = FileName;
        }

        public static void SetDocumentText(string FileText)
        {
            Text = FileText;
        }

        public static void SetDocumentSender(string FileSender)
        {
            Sender = FileSender;
        }
        public static void SetDocumentStatus(bool FileStatus)
        {
            Status = FileStatus;
        }

        public static void SetDocumentID(int FileID)
        {
            ID = FileID;
        }
        public static void SetDocumentType(DocumentType documentType)
        {
            Type = documentType;
        }
        public static string OpenDocument()
        {
            string FileRead = File.ReadAllText(Path);
            return FileRead;
        }
        public static void ResetValues()
        {
            Path = DataSettings.SettingsFolderPath + @"\" + "DocumentSettings" + ".json ";
            Name = "";
            Sender = "";
            Text = "";
            Status = false;


        }
    }
}

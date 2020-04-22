using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceDocumentSystem.Data_Access;
using FinanceDocumentSystem.Business_Logic.Enum;
using FinanceDocumentSystem.Presentation.User_Controls;

namespace FinanceDocumentSystem.Business_Logic.Class
{
    public class Document
    {
        public string Path;
        public string Name;
        public string Text;
        public string Sender;
        public bool Status;
        public int ID;
        public string Date;
        public DocumentType Type;

        public Document()
        {
            Path = DocumentOpenTemp.DocumentPath;
            Name = DocumentOpenTemp.DocumentName;
            Text = DocumentOpenTemp.DocumentText;
            Sender = DocumentOpenTemp.DocumentSender;
            Status = DocumentOpenTemp.DocumentStatus;
            ID = DocumentOpenTemp.DocumentID;
            Date = DocumentOpenTemp.DocumentDate;
            Type = DocumentOpenTemp.TypeOfDocument;
        } 
    }
}

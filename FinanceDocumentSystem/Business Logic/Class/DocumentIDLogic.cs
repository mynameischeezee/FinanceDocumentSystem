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
   public class DocumentIDLogic
    {
        public int CurrentID;

        public void AddAnID()
        {
            CurrentID += 1;
        }
    }
}

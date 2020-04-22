using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceDocumentSystem.Business_Logic.Enum;

namespace FinanceDocumentSystem.Business_Logic.Class
{
    public static class SelectType
    {
        public static DocumentType SelectDocumentType(int number)
        {
            if (number == 0)
            {
                return DocumentType.Inner;
            }
            else
            {
                return DocumentType.External;
            }
        }
    }
     
}

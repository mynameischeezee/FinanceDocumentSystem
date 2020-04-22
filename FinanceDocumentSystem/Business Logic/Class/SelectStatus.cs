using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceDocumentSystem.Business_Logic.Class
{
    public static class SelectStatus
    {
        public static bool SelectDocumentStatus(int number)
        {
            if (number == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

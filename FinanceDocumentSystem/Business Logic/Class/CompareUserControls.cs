using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceDocumentSystem.Data_Access;
using FinanceDocumentSystem.Business_Logic.Class;
using FinanceDocumentSystem.Business_Logic.Enum;
using FinanceDocumentSystem.Presentation.User_Controls;
using System.Configuration;

namespace FinanceDocumentSystem.Business_Logic.Class
{
    public static class CompareUserControls
    {
        public static bool Compare(UserControl ActiveUserControl, UserControl FutureUserControl)
        {
            if (ActiveUserControl == FutureUserControl)
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceDocumentSystem.Presentation.User_Controls
{
    public partial class UsrCtrlOpenFile : UserControl
    {
        public UsrCtrlOpenFile()
        {
            InitializeComponent();
        }

        private void pnl_DragAndDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void pnl_DragAndDrop_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])(e.Data.GetData(DataFormats.FileDrop, false));
            foreach (string file in files)
            {
                MessageBox.Show(file);
            }
        }

        private void btn_FileOpen_Click(object sender, EventArgs e)
        {
            if (OpenWindow.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(OpenWindow.FileName);
            }
        }

        private void UsrtCtrlOpenFile_Load(object sender, EventArgs e)
        {

        }
    }
}

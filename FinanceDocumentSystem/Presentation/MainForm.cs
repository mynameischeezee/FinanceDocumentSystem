using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceDocumentSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HoverPanel.Height = btn_AddFile.Height;
            HoverPanel.Top = btn_AddFile.Top;
        }

        private void btn_AddFile_Click(object sender, EventArgs e)
        {
            HoverPanel.Height = btn_AddFile.Height;
            HoverPanel.Top = btn_AddFile.Top;
        }

        private void btn_FileList_Click(object sender, EventArgs e)
        {
            HoverPanel.Height = btn_FileList.Height;
            HoverPanel.Top = btn_FileList.Top;
        }
    }
}

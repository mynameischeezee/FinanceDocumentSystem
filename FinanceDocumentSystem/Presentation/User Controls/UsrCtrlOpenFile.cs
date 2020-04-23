using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceDocumentSystem.Data_Access;
using FinanceDocumentSystem.Business_Logic.Class;
using FinanceDocumentSystem.Business_Logic.Enum;
using System.Windows.Forms;

namespace FinanceDocumentSystem.Presentation.User_Controls
{
    public partial class UsrCtrlOpenFile : UserControl
    {
        public string FilePath;
        public UsrCtrlSetDocumentInfo UsrCtrl { get; set; }

        public UsrCtrlOpenFile()
        {
            InitializeComponent();
            
        }
        public void ResetFormValues()
        {
            FilePath = "";
            lbl_DocumentPath.Text = "";
        }
        private void pnl_DragAndDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void pnl_DragAndDrop_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])(e.Data.GetData(DataFormats.FileDrop, false));

            try
            {
                if (files.Length > 1)
                {
                    throw new InvalidOperationException("More than 1 file are been added.");

                }
                
                foreach (string file in files)
                {
                    lbl_DocumentPath.Text = "Шлях до фалу: " + file;
                    FilePath = files[0];
                }

            }
            catch
            {
                MessageBox.Show("Обрано більше одного файлу ! Будь ласка, оберіть один файл !", "Увага !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
      
            }
            
        }

        private void btn_FileOpen_Click(object sender, EventArgs e)
        {
            if (OpenWindow.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbl_DocumentPath.Text = "Шлях до фалу: " + OpenWindow.FileName;
                FilePath = OpenWindow.FileName;
            }
        }

        private void UsrtCtrlOpenFile_Load(object sender, EventArgs e)
        {

        }

        private void btn_FileAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string fileExt = FilePath.Substring(FilePath.IndexOf('.'));
            }
            catch
            {
                MessageBox.Show("Помилка при роботі з файлом ! Можливо файл не було обрано. Будь ласка, оберіть інший файл !", "Увага !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
           
            try
            {
                string fileExt = FilePath.Substring(FilePath.IndexOf('.'));
                if (fileExt == ".docx" || fileExt == ".doc" || fileExt == ".txt")
                {
                    UsrCtrl?.BringToFront();
                    DocumentOpenTemp.SetDocumentPath(FilePath);

                    UsrCtrl.rchTxtBox_DocumentText.Text = DocumentOpenTemp.OpenDocument();
                    UsrCtrl.lbl_DocumentIDValue.Text = Convert.ToString(MainDocumentLogic.logic.CurrentID + 1);
                    UsrCtrl.txtBox_DocumentName.Text = "Назва документу";
                    UsrCtrl.txtBox_DocumentSender.Text = "Адресат";
                    
                    
                }
                else
                {
                    throw new InvalidOperationException("Wrong file extension.");
                }
            }
            catch
            {
                MessageBox.Show("Обраний файл не є текстовим ! Будь ласка, оберіть інший файл !", "Увага !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

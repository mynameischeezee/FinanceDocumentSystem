using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceDocumentSystem.Business_Logic.Class;

namespace FinanceDocumentSystem.Presentation.User_Controls
{
    public partial class UsrCtrlDocumentList : UserControl
    {
        public UsrCtrlDocumentList()
        {
            InitializeComponent();
        }

        private void UsrCtrlDocumentList_Load(object sender, EventArgs e)
        {
            
        }

        public void AddDocumentsToList()
        {
            listBoxDocuments.Items.Clear();   
            listBoxDocuments.Items.Add("Документ: ");
            foreach (Document document in MainDocumentLogic.DocumentList)
            {
                
                listBoxDocuments.Items.Add(document.Name);
            }
        }
    
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_FinishAddFile_Click(object sender, EventArgs e)
        {
            Document document = MainDocumentLogic.DocumentList.Find(x => x.Name.Contains(listBoxDocuments.SelectedIndex.ToString()));
            document.Name = txtBox_DocumentName.Text;
            document.Sender = txtBox_DocumentSender.Text;
            document.Text = rchTxtBox_DocumentText.Text;
            document.Type = SelectType.SelectDocumentType(cmbBoxDocumentType.SelectedIndex);
            document.Status = SelectStatus.SelectDocumentStatus(cmbBoxDocumentStatus.SelectedIndex);





        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBoxDocuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDocuments.SelectedIndex != 0)
            {
              Document document = MainDocumentLogic.DocumentList.Find(x => x.Name.Contains(listBoxDocuments.SelectedIndex.ToString()));
                txtBox_DocumentName.Text = document.Name;
                lbl_DocumentIDValue.Text = Convert.ToString(document.ID);
                txtBox_DocumentSender.Text = document.Sender;
                rchTxtBox_DocumentText.Text = document.Text;
                lbl_DocumentDateValue.Text = document.Date;
                cmbBoxDocumentType.SelectedIndex = (int)document.Type;
                if (document.Status == false)
                {
                    cmbBoxDocumentStatus.SelectedIndex = 1;
                }
                else
                {
                    cmbBoxDocumentStatus.SelectedIndex = 0;
                }

            }
            
        }
    }


}

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

        public void AddDocumentsToList()
        {
            listBoxDocuments.Items.Clear();
            listBoxDocuments.Items.Add("Документ: ");
            foreach (Document document in MainDocumentLogic.DocumentList)
            {
                listBoxDocuments.Items.Add(document.Name);
            }
        }


        private void btn_FinishAddFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxDocuments.SelectedIndex != 0)
                {
                    Document document = MainDocumentLogic.DocumentList[listBoxDocuments.SelectedIndex - 1];
                    document.Name = txtBox_DocumentName.Text;
                    document.Sender = txtBox_DocumentSender.Text;
                    document.Text = rchTxtBox_DocumentText.Text;
                    document.Type = SelectType.SelectDocumentType(cmbBoxDocumentType.SelectedIndex);
                    document.Status = SelectStatus.SelectDocumentStatus(cmbBoxDocumentStatus.SelectedIndex);

                    AddDocumentsToList();
                }
                else
                {
                    throw new InvalidOperationException("No files been selsected.");
                }
            }
            catch
            {
                MessageBox.Show("Документ не обрано ! Будь ласка, оберіть документ !", "Увага !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBoxDocuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDocuments.SelectedIndex != 0)
            {
                
                Document document = MainDocumentLogic.DocumentList[listBoxDocuments.SelectedIndex-1];

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

        private void btn_DeleteDocument_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxDocuments.SelectedIndex != 0)
                {
                    Document document = MainDocumentLogic.DocumentList[listBoxDocuments.SelectedIndex - 1];
                    MainDocumentLogic.DeleteDocument(document);
                    AddDocumentsToList();
                    
                }
                else
                {
                    throw new InvalidOperationException("No files been selsected.");
                }
            }
            catch
            {
                MessageBox.Show("Документ не обрано ! Будь ласка, оберіть документ !", "Увага !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
            
        }
    }




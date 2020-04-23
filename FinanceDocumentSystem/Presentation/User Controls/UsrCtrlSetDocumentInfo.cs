using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceDocumentSystem.Data_Access;
using FinanceDocumentSystem.Business_Logic.Class;
using FinanceDocumentSystem.Business_Logic.Enum;

namespace FinanceDocumentSystem.Presentation.User_Controls
{
    public partial class UsrCtrlSetDocumentInfo : UserControl
    {
        public UsrCtrlOpenFile UsrCtrl { get; set; }
        public UsrCtrlSetDocumentInfo()
        {
            InitializeComponent();
            
        }
        
        private void txtBoxDocumentName_TextChanged(object sender, EventArgs e)
        {
            DocumentOpenTemp.SetDocumentName(txtBox_DocumentName.Text);
        }

        private void lbl_DocumentDateInfo_Click(object sender, EventArgs e)
        {
            DocumentOpenTemp.SetDocumentSender(txtBox_DocumentSender.Text);
        }

        

        private void UsrCtrlSetDocumentInfo_Load(object sender, EventArgs e)
        {
            lbl_DocumentDateValue.Text = DocumentOpenTemp.DocumentDate;
            cmbBoxDocumentStatus.SelectedIndex = 0;
            cmbBoxDocumentType.SelectedIndex = 0;


        }

        private void btn_FinishAddFile_Click(object sender, EventArgs e)
        {

            MainDocumentLogic.logic.AddAnID();
            DocumentOpenTemp.SetDocumentID(MainDocumentLogic.logic.CurrentID);
            DocumentOpenTemp.SetDocumentName(txtBox_DocumentName.Text);
            DocumentOpenTemp.SetDocumentSender(txtBox_DocumentSender.Text);
            DocumentOpenTemp.SetDocumentText(rchTxtBox_DocumentText.Text);
            DocumentOpenTemp.SetDocumentStatus(SelectStatus.SelectDocumentStatus(cmbBoxDocumentStatus.SelectedIndex));
            DocumentOpenTemp.SetDocumentType(SelectType.SelectDocumentType(cmbBoxDocumentType.SelectedIndex));

            Document document = new Document();
            MainDocumentLogic.AddDocument(document);
            
            DocumentOpenTemp.ResetValues();

            UsrCtrl?.BringToFront();


        }

        private void UsrCtrlSetDocumentInfo_VisibleChanged(object sender, EventArgs e)
        {

            rchTxtBox_DocumentText.Text = DocumentOpenTemp.OpenDocument();

        }
    }
}

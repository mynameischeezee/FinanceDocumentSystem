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

namespace FinanceDocumentSystem
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            usrCtrlOpenFile.UsrCtrl = usrCtrlSetDocumentInfo1;
            usrCtrlSetDocumentInfo1.UsrCtrl = usrCtrlOpenFile;

            DataSettings.CheckIfMainFolderExists();
            DataSettings.CheckDocumentnFolderExists();
            DataSettings.CheckSettingsFolderExists();
            DataSettings.CreateSettingsFile();


            MainDocumentLogic.logic = JsonDeserialization.DeSerializeObject<DocumentLogic>(MainDocumentLogic.logic, DataSettings.SettingsFolderPath, "DocumentSettings");
            LoadEveryDocument.LoadDocuments();


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HoverPanel.Height = btn_AddFile.Height;
            HoverPanel.Top = btn_AddFile.Top;
            usrCtrlOpenFile.BringToFront();

            

        }

        private void btn_AddFile_Click(object sender, EventArgs e)
        {
            HoverPanel.Height = btn_AddFile.Height;
            HoverPanel.Top = btn_AddFile.Top;
            usrCtrlOpenFile.BringToFront();
            usrCtrlOpenFile.ResetFormValues();
        }

        private void btn_FileList_Click(object sender, EventArgs e)
        {
            HoverPanel.Height = btn_FileList.Height;
            HoverPanel.Top = btn_FileList.Top;
            usrCtrlDocumentList1.BringToFront();
            usrCtrlDocumentList1.AddDocumentsToList();
            

        }

        private void usrCtrlSetDocumentInfo1_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine(MainDocumentLogic.DocumentList.Count);
            MainDocumentLogic.SerializeDocumentList();
            JsonSerialization.SerializeObject(MainDocumentLogic.logic, DataSettings.SettingsFolderPath, "DocumentSettings");
            
        }

        private void usrCtrlDocumentList1_Load(object sender, EventArgs e)
        {

        }
    }
}

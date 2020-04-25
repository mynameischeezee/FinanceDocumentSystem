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
        public static UserControl ActiveControl;

        public MainForm()
        {
            InitializeComponent();
            usrCtrlOpenFile.UsrCtrl = usrCtrlSetDocumentInfo1;
            usrCtrlSetDocumentInfo1.UsrCtrl = usrCtrlOpenFile;

            DataSettings.CheckIfMainFolderExists();
            DataSettings.CheckDocumentnFolderExists();
            DataSettings.CheckSettingsFolderExists();
            DataSettings.CreateSettingsFile();


            MainDocumentLogic.logic = JsonDeserialization.DeSerializeObject<DocumentIDLogic>(DataSettings.SettingsFolderPath, "DocumentSettings");
            LoadDocumentList.LoadDocuments();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HoverPanel.Height = btn_AddFile.Height;
            HoverPanel.Top = btn_AddFile.Top;

            ActiveControl = usrCtrlOpenFile;
            usrCtrlOpenFile.BringToFront();
            ActiveControl = usrCtrlOpenFile;
        }

        private void btn_AddFile_Click(object sender, EventArgs e)
        {
            if (CompareUserControls.Compare(ActiveControl, usrCtrlOpenFile))
            {

            }
            else
            {
              DialogResult result =   MessageBox.Show("Зміни не будуть збережені, перейти ?", "Увага !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    ActiveControl = usrCtrlOpenFile;
                    HoverPanel.Height = btn_AddFile.Height;
                    HoverPanel.Top = btn_AddFile.Top;
                    usrCtrlOpenFile.BringToFront();
                    usrCtrlOpenFile.ResetFormValues();
                    ActiveControl = usrCtrlOpenFile;

                }
            }
                
        }

        private void btn_FileList_Click(object sender, EventArgs e)
        {
            if (CompareUserControls.Compare(ActiveControl, usrCtrlDocumentList1))
            {

            }
            else if (ActiveControl != usrCtrlOpenFile || ActiveControl == usrCtrlSetDocumentInfo1)
            {
                DialogResult result = MessageBox.Show("Зміни не будуть збережені, перейти ?", "Увага !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    ActiveControl = usrCtrlDocumentList1;
                    HoverPanel.Height = btn_FileList.Height;
                    HoverPanel.Top = btn_FileList.Top;
                    usrCtrlDocumentList1.BringToFront();
                    usrCtrlDocumentList1.AddDocumentsToList();

                }
            }
            else
            {
                ActiveControl = usrCtrlDocumentList1;
                HoverPanel.Height = btn_FileList.Height;
                HoverPanel.Top = btn_FileList.Top;
                usrCtrlDocumentList1.BringToFront();
                usrCtrlDocumentList1.AddDocumentsToList();

            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CleanDocumentFolder.DeleteDocuments();
            SaveDocumentList.SerializeDocumentList();
            JsonSerialization.SerializeObject(MainDocumentLogic.logic, DataSettings.SettingsFolderPath, "DocumentSettings");
        }
    }
}

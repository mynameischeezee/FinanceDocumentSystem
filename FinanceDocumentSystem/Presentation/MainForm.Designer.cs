namespace FinanceDocumentSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Background = new System.Windows.Forms.Panel();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.HoverPanel = new System.Windows.Forms.Panel();
            this.btn_AddFile = new System.Windows.Forms.Button();
            this.btn_FileList = new System.Windows.Forms.Button();
            this.pctr_Logo = new System.Windows.Forms.PictureBox();
            this.usrCtrlDocumentList1 = new FinanceDocumentSystem.Presentation.User_Controls.UsrCtrlDocumentList();
            this.usrCtrlSetDocumentInfo1 = new FinanceDocumentSystem.Presentation.User_Controls.UsrCtrlSetDocumentInfo();
            this.usrCtrlOpenFile = new FinanceDocumentSystem.Presentation.User_Controls.UsrCtrlOpenFile();
            this.pnl_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Background
            // 
            this.pnl_Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnl_Background.Controls.Add(this.lbl_Info);
            this.pnl_Background.Controls.Add(this.HoverPanel);
            this.pnl_Background.Controls.Add(this.btn_AddFile);
            this.pnl_Background.Controls.Add(this.btn_FileList);
            this.pnl_Background.Controls.Add(this.pctr_Logo);
            this.pnl_Background.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Background.Location = new System.Drawing.Point(0, 0);
            this.pnl_Background.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Background.Name = "pnl_Background";
            this.pnl_Background.Size = new System.Drawing.Size(220, 681);
            this.pnl_Background.TabIndex = 0;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.lbl_Info.Location = new System.Drawing.Point(15, 612);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(182, 34);
            this.lbl_Info.TabIndex = 1;
            this.lbl_Info.Text = "Finance Document System \r\nVer. 1.0";
            this.lbl_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Info.UseMnemonic = false;
            // 
            // HoverPanel
            // 
            this.HoverPanel.BackColor = System.Drawing.Color.White;
            this.HoverPanel.Location = new System.Drawing.Point(0, 240);
            this.HoverPanel.Name = "HoverPanel";
            this.HoverPanel.Size = new System.Drawing.Size(8, 40);
            this.HoverPanel.TabIndex = 1;
            // 
            // btn_AddFile
            // 
            this.btn_AddFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_AddFile.FlatAppearance.BorderSize = 0;
            this.btn_AddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddFile.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddFile.ForeColor = System.Drawing.Color.White;
            this.btn_AddFile.Image = global::FinanceDocumentSystem.Properties.Resources.Folder40;
            this.btn_AddFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddFile.Location = new System.Drawing.Point(14, 240);
            this.btn_AddFile.Name = "btn_AddFile";
            this.btn_AddFile.Size = new System.Drawing.Size(200, 40);
            this.btn_AddFile.TabIndex = 2;
            this.btn_AddFile.Text = "Відкрити файл";
            this.btn_AddFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddFile.UseVisualStyleBackColor = false;
            this.btn_AddFile.Click += new System.EventHandler(this.btn_AddFile_Click);
            // 
            // btn_FileList
            // 
            this.btn_FileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_FileList.FlatAppearance.BorderSize = 0;
            this.btn_FileList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FileList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_FileList.ForeColor = System.Drawing.Color.White;
            this.btn_FileList.Image = global::FinanceDocumentSystem.Properties.Resources.list40;
            this.btn_FileList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FileList.Location = new System.Drawing.Point(14, 290);
            this.btn_FileList.Name = "btn_FileList";
            this.btn_FileList.Size = new System.Drawing.Size(200, 40);
            this.btn_FileList.TabIndex = 3;
            this.btn_FileList.Text = "Список Файлів";
            this.btn_FileList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_FileList.UseVisualStyleBackColor = false;
            this.btn_FileList.Click += new System.EventHandler(this.btn_FileList_Click);
            // 
            // pctr_Logo
            // 
            this.pctr_Logo.Image = global::FinanceDocumentSystem.Properties.Resources.Logo;
            this.pctr_Logo.Location = new System.Drawing.Point(12, 12);
            this.pctr_Logo.Name = "pctr_Logo";
            this.pctr_Logo.Size = new System.Drawing.Size(184, 93);
            this.pctr_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctr_Logo.TabIndex = 1;
            this.pctr_Logo.TabStop = false;
            // 
            // usrCtrlDocumentList1
            // 
            this.usrCtrlDocumentList1.BackColor = System.Drawing.Color.White;
            this.usrCtrlDocumentList1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.usrCtrlDocumentList1.Location = new System.Drawing.Point(220, 0);
            this.usrCtrlDocumentList1.Name = "usrCtrlDocumentList1";
            this.usrCtrlDocumentList1.Size = new System.Drawing.Size(1040, 680);
            this.usrCtrlDocumentList1.TabIndex = 3;
            // 
            // usrCtrlSetDocumentInfo1
            // 
            this.usrCtrlSetDocumentInfo1.BackColor = System.Drawing.Color.White;
            this.usrCtrlSetDocumentInfo1.Location = new System.Drawing.Point(220, 0);
            this.usrCtrlSetDocumentInfo1.Name = "usrCtrlSetDocumentInfo1";
            this.usrCtrlSetDocumentInfo1.Size = new System.Drawing.Size(1040, 680);
            this.usrCtrlSetDocumentInfo1.TabIndex = 2;
            this.usrCtrlSetDocumentInfo1.UsrCtrl = null;
            // 
            // usrCtrlOpenFile
            // 
            this.usrCtrlOpenFile.BackColor = System.Drawing.Color.White;
            this.usrCtrlOpenFile.Location = new System.Drawing.Point(220, 0);
            this.usrCtrlOpenFile.Name = "usrCtrlOpenFile";
            this.usrCtrlOpenFile.Size = new System.Drawing.Size(1040, 680);
            this.usrCtrlOpenFile.TabIndex = 1;
            this.usrCtrlOpenFile.UsrCtrl = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.usrCtrlDocumentList1);
            this.Controls.Add(this.usrCtrlSetDocumentInfo1);
            this.Controls.Add(this.usrCtrlOpenFile);
            this.Controls.Add(this.pnl_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Finance Document System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnl_Background.ResumeLayout(false);
            this.pnl_Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Background;
        private System.Windows.Forms.PictureBox pctr_Logo;
        private System.Windows.Forms.Button btn_AddFile;
        private System.Windows.Forms.Button btn_FileList;
        private System.Windows.Forms.Panel HoverPanel;
        private System.Windows.Forms.Label lbl_Info;
        private Presentation.User_Controls.UsrCtrlOpenFile usrCtrlOpenFile;
        private Presentation.User_Controls.UsrCtrlSetDocumentInfo usrCtrlSetDocumentInfo1;
        private Presentation.User_Controls.UsrCtrlDocumentList usrCtrlDocumentList1;
    }
}


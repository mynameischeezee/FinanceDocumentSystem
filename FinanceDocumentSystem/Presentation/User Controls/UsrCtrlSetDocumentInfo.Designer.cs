namespace FinanceDocumentSystem.Presentation.User_Controls
{
    partial class UsrCtrlSetDocumentInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_DocumentNameInfo = new System.Windows.Forms.Label();
            this.lbl_DocumentIDInfo = new System.Windows.Forms.Label();
            this.lbl_DocumentSenderInfo = new System.Windows.Forms.Label();
            this.lbl_DocumentStatusInfo = new System.Windows.Forms.Label();
            this.lbl_DocumentDateInfo = new System.Windows.Forms.Label();
            this.lbl_DocumentTypeInfo = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cmbBoxDocumentStatus = new System.Windows.Forms.ComboBox();
            this.cmbBoxDocumentType = new System.Windows.Forms.ComboBox();
            this.lbl_DocumentIDValue = new System.Windows.Forms.Label();
            this.txtBox_DocumentName = new System.Windows.Forms.TextBox();
            this.txtBox_DocumentSender = new System.Windows.Forms.TextBox();
            this.lbl_DocumentDateValue = new System.Windows.Forms.Label();
            this.lbl_DocumentText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rchTxtBox_DocumentText = new System.Windows.Forms.RichTextBox();
            this.btn_FinishAddFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_DocumentNameInfo
            // 
            this.lbl_DocumentNameInfo.AutoSize = true;
            this.lbl_DocumentNameInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DocumentNameInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.lbl_DocumentNameInfo.Location = new System.Drawing.Point(29, 45);
            this.lbl_DocumentNameInfo.Name = "lbl_DocumentNameInfo";
            this.lbl_DocumentNameInfo.Size = new System.Drawing.Size(179, 22);
            this.lbl_DocumentNameInfo.TabIndex = 0;
            this.lbl_DocumentNameInfo.Text = "Назва документу:";
            // 
            // lbl_DocumentIDInfo
            // 
            this.lbl_DocumentIDInfo.AutoSize = true;
            this.lbl_DocumentIDInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DocumentIDInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.lbl_DocumentIDInfo.Location = new System.Drawing.Point(29, 67);
            this.lbl_DocumentIDInfo.Name = "lbl_DocumentIDInfo";
            this.lbl_DocumentIDInfo.Size = new System.Drawing.Size(142, 22);
            this.lbl_DocumentIDInfo.TabIndex = 1;
            this.lbl_DocumentIDInfo.Text = "ID документу:";
            // 
            // lbl_DocumentSenderInfo
            // 
            this.lbl_DocumentSenderInfo.AutoSize = true;
            this.lbl_DocumentSenderInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DocumentSenderInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.lbl_DocumentSenderInfo.Location = new System.Drawing.Point(29, 87);
            this.lbl_DocumentSenderInfo.Name = "lbl_DocumentSenderInfo";
            this.lbl_DocumentSenderInfo.Size = new System.Drawing.Size(99, 22);
            this.lbl_DocumentSenderInfo.TabIndex = 2;
            this.lbl_DocumentSenderInfo.Text = "Адресат:";
            // 
            // lbl_DocumentStatusInfo
            // 
            this.lbl_DocumentStatusInfo.AutoSize = true;
            this.lbl_DocumentStatusInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DocumentStatusInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.lbl_DocumentStatusInfo.Location = new System.Drawing.Point(29, 158);
            this.lbl_DocumentStatusInfo.Name = "lbl_DocumentStatusInfo";
            this.lbl_DocumentStatusInfo.Size = new System.Drawing.Size(182, 22);
            this.lbl_DocumentStatusInfo.TabIndex = 3;
            this.lbl_DocumentStatusInfo.Text = "Cтатус виконання:";
            // 
            // lbl_DocumentDateInfo
            // 
            this.lbl_DocumentDateInfo.AutoSize = true;
            this.lbl_DocumentDateInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DocumentDateInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.lbl_DocumentDateInfo.Location = new System.Drawing.Point(29, 111);
            this.lbl_DocumentDateInfo.Name = "lbl_DocumentDateInfo";
            this.lbl_DocumentDateInfo.Size = new System.Drawing.Size(62, 22);
            this.lbl_DocumentDateInfo.TabIndex = 4;
            this.lbl_DocumentDateInfo.Text = "Дата:";
            this.lbl_DocumentDateInfo.Click += new System.EventHandler(this.lbl_DocumentDateInfo_Click);
            // 
            // lbl_DocumentTypeInfo
            // 
            this.lbl_DocumentTypeInfo.AutoSize = true;
            this.lbl_DocumentTypeInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DocumentTypeInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.lbl_DocumentTypeInfo.Location = new System.Drawing.Point(29, 133);
            this.lbl_DocumentTypeInfo.Name = "lbl_DocumentTypeInfo";
            this.lbl_DocumentTypeInfo.Size = new System.Drawing.Size(156, 22);
            this.lbl_DocumentTypeInfo.TabIndex = 5;
            this.lbl_DocumentTypeInfo.Text = "Тип Документу:";
            // 
            // cmbBoxDocumentStatus
            // 
            this.cmbBoxDocumentStatus.BackColor = System.Drawing.Color.White;
            this.cmbBoxDocumentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxDocumentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBoxDocumentStatus.ForeColor = System.Drawing.Color.Black;
            this.cmbBoxDocumentStatus.FormattingEnabled = true;
            this.cmbBoxDocumentStatus.Items.AddRange(new object[] {
            "Виконано",
            "В процесі виконання"});
            this.cmbBoxDocumentStatus.Location = new System.Drawing.Point(217, 161);
            this.cmbBoxDocumentStatus.Name = "cmbBoxDocumentStatus";
            this.cmbBoxDocumentStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxDocumentStatus.TabIndex = 13;
            // 
            // cmbBoxDocumentType
            // 
            this.cmbBoxDocumentType.BackColor = System.Drawing.Color.White;
            this.cmbBoxDocumentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxDocumentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBoxDocumentType.ForeColor = System.Drawing.Color.Black;
            this.cmbBoxDocumentType.FormattingEnabled = true;
            this.cmbBoxDocumentType.Items.AddRange(new object[] {
            "Внутрішній",
            "Зовнішній"});
            this.cmbBoxDocumentType.Location = new System.Drawing.Point(191, 134);
            this.cmbBoxDocumentType.Name = "cmbBoxDocumentType";
            this.cmbBoxDocumentType.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxDocumentType.TabIndex = 14;
            // 
            // lbl_DocumentIDValue
            // 
            this.lbl_DocumentIDValue.AutoSize = true;
            this.lbl_DocumentIDValue.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DocumentIDValue.ForeColor = System.Drawing.Color.Black;
            this.lbl_DocumentIDValue.Location = new System.Drawing.Point(177, 67);
            this.lbl_DocumentIDValue.Name = "lbl_DocumentIDValue";
            this.lbl_DocumentIDValue.Size = new System.Drawing.Size(21, 22);
            this.lbl_DocumentIDValue.TabIndex = 7;
            this.lbl_DocumentIDValue.Text = "1";
            // 
            // txtBox_DocumentName
            // 
            this.txtBox_DocumentName.BackColor = System.Drawing.Color.White;
            this.txtBox_DocumentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_DocumentName.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtBox_DocumentName.ForeColor = System.Drawing.Color.Black;
            this.txtBox_DocumentName.Location = new System.Drawing.Point(214, 45);
            this.txtBox_DocumentName.Name = "txtBox_DocumentName";
            this.txtBox_DocumentName.Size = new System.Drawing.Size(211, 24);
            this.txtBox_DocumentName.TabIndex = 16;
            this.txtBox_DocumentName.Text = "Назва документу";
            this.txtBox_DocumentName.TextChanged += new System.EventHandler(this.txtBoxDocumentName_TextChanged);
            // 
            // txtBox_DocumentSender
            // 
            this.txtBox_DocumentSender.BackColor = System.Drawing.Color.White;
            this.txtBox_DocumentSender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_DocumentSender.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtBox_DocumentSender.ForeColor = System.Drawing.Color.Black;
            this.txtBox_DocumentSender.Location = new System.Drawing.Point(134, 87);
            this.txtBox_DocumentSender.Name = "txtBox_DocumentSender";
            this.txtBox_DocumentSender.Size = new System.Drawing.Size(235, 24);
            this.txtBox_DocumentSender.TabIndex = 17;
            this.txtBox_DocumentSender.Text = "Ім\'я Адресату";
            // 
            // lbl_DocumentDateValue
            // 
            this.lbl_DocumentDateValue.AutoSize = true;
            this.lbl_DocumentDateValue.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DocumentDateValue.ForeColor = System.Drawing.Color.Black;
            this.lbl_DocumentDateValue.Location = new System.Drawing.Point(97, 111);
            this.lbl_DocumentDateValue.Name = "lbl_DocumentDateValue";
            this.lbl_DocumentDateValue.Size = new System.Drawing.Size(0, 22);
            this.lbl_DocumentDateValue.TabIndex = 18;
            // 
            // lbl_DocumentText
            // 
            this.lbl_DocumentText.AutoSize = true;
            this.lbl_DocumentText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DocumentText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.lbl_DocumentText.Location = new System.Drawing.Point(445, 45);
            this.lbl_DocumentText.Name = "lbl_DocumentText";
            this.lbl_DocumentText.Size = new System.Drawing.Size(173, 22);
            this.lbl_DocumentText.TabIndex = 19;
            this.lbl_DocumentText.Text = "Вміст документу:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Location = new System.Drawing.Point(449, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 2);
            this.panel1.TabIndex = 20;
            // 
            // rchTxtBox_DocumentText
            // 
            this.rchTxtBox_DocumentText.BackColor = System.Drawing.Color.White;
            this.rchTxtBox_DocumentText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchTxtBox_DocumentText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rchTxtBox_DocumentText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.rchTxtBox_DocumentText.Location = new System.Drawing.Point(449, 74);
            this.rchTxtBox_DocumentText.Name = "rchTxtBox_DocumentText";
            this.rchTxtBox_DocumentText.Size = new System.Drawing.Size(588, 550);
            this.rchTxtBox_DocumentText.TabIndex = 21;
            this.rchTxtBox_DocumentText.Text = "";
            // 
            // btn_FinishAddFile
            // 
            this.btn_FinishAddFile.BackColor = System.Drawing.Color.Silver;
            this.btn_FinishAddFile.FlatAppearance.BorderSize = 0;
            this.btn_FinishAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FinishAddFile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_FinishAddFile.ForeColor = System.Drawing.Color.White;
            this.btn_FinishAddFile.Image = global::FinanceDocumentSystem.Properties.Resources.file30px;
            this.btn_FinishAddFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FinishAddFile.Location = new System.Drawing.Point(20, 584);
            this.btn_FinishAddFile.Name = "btn_FinishAddFile";
            this.btn_FinishAddFile.Size = new System.Drawing.Size(165, 40);
            this.btn_FinishAddFile.TabIndex = 22;
            this.btn_FinishAddFile.Text = "Додати файл";
            this.btn_FinishAddFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_FinishAddFile.UseVisualStyleBackColor = false;
            this.btn_FinishAddFile.Click += new System.EventHandler(this.btn_FinishAddFile_Click);
            // 
            // UsrCtrlSetDocumentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_FinishAddFile);
            this.Controls.Add(this.rchTxtBox_DocumentText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_DocumentText);
            this.Controls.Add(this.lbl_DocumentDateValue);
            this.Controls.Add(this.txtBox_DocumentSender);
            this.Controls.Add(this.txtBox_DocumentName);
            this.Controls.Add(this.cmbBoxDocumentType);
            this.Controls.Add(this.cmbBoxDocumentStatus);
            this.Controls.Add(this.lbl_DocumentIDValue);
            this.Controls.Add(this.lbl_DocumentTypeInfo);
            this.Controls.Add(this.lbl_DocumentDateInfo);
            this.Controls.Add(this.lbl_DocumentStatusInfo);
            this.Controls.Add(this.lbl_DocumentSenderInfo);
            this.Controls.Add(this.lbl_DocumentIDInfo);
            this.Controls.Add(this.lbl_DocumentNameInfo);
            this.Name = "UsrCtrlSetDocumentInfo";
            this.Size = new System.Drawing.Size(1040, 680);
            this.Load += new System.EventHandler(this.UsrCtrlSetDocumentInfo_Load);
            this.VisibleChanged += new System.EventHandler(this.UsrCtrlSetDocumentInfo_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DocumentNameInfo;
        private System.Windows.Forms.Label lbl_DocumentIDInfo;
        private System.Windows.Forms.Label lbl_DocumentSenderInfo;
        private System.Windows.Forms.Label lbl_DocumentStatusInfo;
        private System.Windows.Forms.Label lbl_DocumentDateInfo;
        private System.Windows.Forms.Label lbl_DocumentTypeInfo;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lbl_DocumentDateValue;
        private System.Windows.Forms.Label lbl_DocumentText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_FinishAddFile;
        public System.Windows.Forms.RichTextBox rchTxtBox_DocumentText;
        public System.Windows.Forms.Label lbl_DocumentIDValue;
        public System.Windows.Forms.ComboBox cmbBoxDocumentStatus;
        public System.Windows.Forms.ComboBox cmbBoxDocumentType;
        public System.Windows.Forms.TextBox txtBox_DocumentName;
        public System.Windows.Forms.TextBox txtBox_DocumentSender;
    }
}

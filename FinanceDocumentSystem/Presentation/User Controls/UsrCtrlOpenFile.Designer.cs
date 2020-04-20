namespace FinanceDocumentSystem.Presentation.User_Controls
{
    partial class UsrCtrlOpenFile
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
            this.pnl_DragAndDrop = new System.Windows.Forms.Panel();
            this.btn_FileOpen = new System.Windows.Forms.Button();
            this.OpenWindow = new System.Windows.Forms.OpenFileDialog();
            this.pnl_DragAndDrop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_DragAndDrop
            // 
            this.pnl_DragAndDrop.AllowDrop = true;
            this.pnl_DragAndDrop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_DragAndDrop.BackgroundImage = global::FinanceDocumentSystem.Properties.Resources.DragAndDropLightBorder;
            this.pnl_DragAndDrop.Controls.Add(this.btn_FileOpen);
            this.pnl_DragAndDrop.Location = new System.Drawing.Point(200, 70);
            this.pnl_DragAndDrop.Name = "pnl_DragAndDrop";
            this.pnl_DragAndDrop.Size = new System.Drawing.Size(638, 450);
            this.pnl_DragAndDrop.TabIndex = 0;
            this.pnl_DragAndDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnl_DragAndDrop_DragDrop);
            this.pnl_DragAndDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnl_DragAndDrop_DragEnter);
            // 
            // btn_FileOpen
            // 
            this.btn_FileOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_FileOpen.FlatAppearance.BorderSize = 0;
            this.btn_FileOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FileOpen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_FileOpen.ForeColor = System.Drawing.Color.White;
            this.btn_FileOpen.Location = new System.Drawing.Point(267, 368);
            this.btn_FileOpen.Name = "btn_FileOpen";
            this.btn_FileOpen.Size = new System.Drawing.Size(108, 25);
            this.btn_FileOpen.TabIndex = 0;
            this.btn_FileOpen.Text = "Обрати файл";
            this.btn_FileOpen.UseVisualStyleBackColor = false;
            this.btn_FileOpen.Click += new System.EventHandler(this.btn_FileOpen_Click);
            // 
            // OpenWindow
            // 
            this.OpenWindow.FileName = "openFileDialog1";
            // 
            // UsrtCtrlOpenFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_DragAndDrop);
            this.Name = "UsrtCtrlOpenFile";
            this.Size = new System.Drawing.Size(1040, 680);
            this.Load += new System.EventHandler(this.UsrtCtrlOpenFile_Load);
            this.pnl_DragAndDrop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_DragAndDrop;
        private System.Windows.Forms.Button btn_FileOpen;
        private System.Windows.Forms.OpenFileDialog OpenWindow;
    }
}

namespace SupportTools
{
    partial class XtraControl3
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
            this.rtbItemDetail = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simplebtnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rtbItemDetail
            // 
            this.rtbItemDetail.BackColor = System.Drawing.Color.White;
            this.rtbItemDetail.Location = new System.Drawing.Point(24, 43);
            this.rtbItemDetail.Name = "rtbItemDetail";
            this.rtbItemDetail.Size = new System.Drawing.Size(225, 377);
            this.rtbItemDetail.TabIndex = 5;
            this.rtbItemDetail.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(294, 24);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(135, 13);
            this.labelControl9.TabIndex = 53;
            this.labelControl9.Text = "Chọn loại vật tư cần chuyển";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(218, 13);
            this.labelControl1.TabIndex = 54;
            this.labelControl1.Text = "Mã vật tư (cách nhau bằng kí tự xuống dòng)";
            // 
            // simplebtnCapNhat
            // 
            this.simplebtnCapNhat.Location = new System.Drawing.Point(294, 70);
            this.simplebtnCapNhat.Name = "simplebtnCapNhat";
            this.simplebtnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.simplebtnCapNhat.TabIndex = 56;
            this.simplebtnCapNhat.Text = "Cập nhật";
            this.simplebtnCapNhat.Click += new System.EventHandler(this.simplebtnCapNhat_Click);
            // 
            // cbItem
            // 
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(294, 43);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(266, 21);
            this.cbItem.TabIndex = 57;
            // 
            // XtraControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.cbItem);
            this.Controls.Add(this.simplebtnCapNhat);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.rtbItemDetail);
            this.Name = "XtraControl3";
            this.Size = new System.Drawing.Size(1164, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbItemDetail;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simplebtnCapNhat;
        private System.Windows.Forms.ComboBox cbItem;
    }
}

namespace SupportTools
{
    partial class CapNhatMaVatTu
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.simplebtnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.rtbItemDetail = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.cbItem);
            this.groupControl1.Controls.Add(this.simplebtnCapNhat);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.rtbItemDetail);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1158, 694);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // cbItem
            // 
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(263, 42);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(266, 21);
            this.cbItem.TabIndex = 62;
            // 
            // simplebtnCapNhat
            // 
            this.simplebtnCapNhat.Location = new System.Drawing.Point(263, 69);
            this.simplebtnCapNhat.Name = "simplebtnCapNhat";
            this.simplebtnCapNhat.Size = new System.Drawing.Size(100, 40);
            this.simplebtnCapNhat.TabIndex = 61;
            this.simplebtnCapNhat.Text = "Cập nhật";
            this.simplebtnCapNhat.Click += new System.EventHandler(this.simplebtnCapNhat_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(218, 13);
            this.labelControl1.TabIndex = 60;
            this.labelControl1.Text = "Mã vật tư (cách nhau bằng kí tự xuống dòng)";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(263, 23);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(135, 13);
            this.labelControl9.TabIndex = 59;
            this.labelControl9.Text = "Chọn loại vật tư cần chuyển";
            // 
            // rtbItemDetail
            // 
            this.rtbItemDetail.BackColor = System.Drawing.Color.White;
            this.rtbItemDetail.Location = new System.Drawing.Point(17, 41);
            this.rtbItemDetail.Name = "rtbItemDetail";
            this.rtbItemDetail.Size = new System.Drawing.Size(225, 377);
            this.rtbItemDetail.TabIndex = 58;
            this.rtbItemDetail.Text = "";
            // 
            // CapNhatMaVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupControl1);
            this.Name = "CapNhatMaVatTu";
            this.Size = new System.Drawing.Size(1164, 700);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cbItem;
        private DevExpress.XtraEditors.SimpleButton simplebtnCapNhat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.RichTextBox rtbItemDetail;
    }
}

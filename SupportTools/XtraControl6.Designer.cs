namespace SupportTools
{
    partial class XtraControl6
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMSNV = new DevExpress.XtraEditors.TextEdit();
            this.simplebtnDangxuat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "MSNV:";
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(61, 21);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(100, 20);
            this.txtMSNV.TabIndex = 12;
            // 
            // simplebtnDangxuat
            // 
            this.simplebtnDangxuat.Location = new System.Drawing.Point(167, 19);
            this.simplebtnDangxuat.Name = "simplebtnDangxuat";
            this.simplebtnDangxuat.Size = new System.Drawing.Size(75, 23);
            this.simplebtnDangxuat.TabIndex = 14;
            this.simplebtnDangxuat.Text = "Đăng xuất";
            this.simplebtnDangxuat.Click += new System.EventHandler(this.simplebtnDangxuat_Click);
            // 
            // XtraControl6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.simplebtnDangxuat);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMSNV);
            this.Name = "XtraControl6";
            this.Size = new System.Drawing.Size(1164, 700);
            ((System.ComponentModel.ISupportInitialize)(this.txtMSNV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMSNV;
        private DevExpress.XtraEditors.SimpleButton simplebtnDangxuat;
    }
}

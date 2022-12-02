namespace SupportTools
{
    partial class XtraControl7
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
            this.txtMK = new DevExpress.XtraEditors.TextEdit();
            this.lbMes = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMSNV = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobtnITS = new System.Windows.Forms.RadioButton();
            this.radiobtnERP = new System.Windows.Forms.RadioButton();
            this.radiobtnAGP = new System.Windows.Forms.RadioButton();
            this.radiobtnWTS = new System.Windows.Forms.RadioButton();
            this.simplebtnLayMatKhau = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSNV.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(220, 114);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(100, 20);
            this.txtMK.TabIndex = 15;
            this.txtMK.Visible = false;
            // 
            // lbMes
            // 
            this.lbMes.Location = new System.Drawing.Point(183, 77);
            this.lbMes.Name = "lbMes";
            this.lbMes.Size = new System.Drawing.Size(0, 13);
            this.lbMes.TabIndex = 16;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(183, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "MSNV:";
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(220, 45);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(100, 20);
            this.txtMSNV.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobtnITS);
            this.groupBox1.Controls.Add(this.radiobtnERP);
            this.groupBox1.Controls.Add(this.radiobtnAGP);
            this.groupBox1.Controls.Add(this.radiobtnWTS);
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 140);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn hệ thống";
            // 
            // radiobtnITS
            // 
            this.radiobtnITS.AutoSize = true;
            this.radiobtnITS.Location = new System.Drawing.Point(21, 29);
            this.radiobtnITS.Name = "radiobtnITS";
            this.radiobtnITS.Size = new System.Drawing.Size(42, 17);
            this.radiobtnITS.TabIndex = 2;
            this.radiobtnITS.TabStop = true;
            this.radiobtnITS.Text = "ITS";
            this.radiobtnITS.UseVisualStyleBackColor = true;
            // 
            // radiobtnERP
            // 
            this.radiobtnERP.AutoSize = true;
            this.radiobtnERP.Location = new System.Drawing.Point(21, 52);
            this.radiobtnERP.Name = "radiobtnERP";
            this.radiobtnERP.Size = new System.Drawing.Size(47, 17);
            this.radiobtnERP.TabIndex = 3;
            this.radiobtnERP.TabStop = true;
            this.radiobtnERP.Text = "ERP";
            this.radiobtnERP.UseVisualStyleBackColor = true;
            // 
            // radiobtnAGP
            // 
            this.radiobtnAGP.AutoSize = true;
            this.radiobtnAGP.Location = new System.Drawing.Point(21, 98);
            this.radiobtnAGP.Name = "radiobtnAGP";
            this.radiobtnAGP.Size = new System.Drawing.Size(47, 17);
            this.radiobtnAGP.TabIndex = 5;
            this.radiobtnAGP.TabStop = true;
            this.radiobtnAGP.Text = "AGP";
            this.radiobtnAGP.UseVisualStyleBackColor = true;
            // 
            // radiobtnWTS
            // 
            this.radiobtnWTS.AutoSize = true;
            this.radiobtnWTS.Location = new System.Drawing.Point(21, 75);
            this.radiobtnWTS.Name = "radiobtnWTS";
            this.radiobtnWTS.Size = new System.Drawing.Size(50, 17);
            this.radiobtnWTS.TabIndex = 4;
            this.radiobtnWTS.TabStop = true;
            this.radiobtnWTS.Text = "WTS";
            this.radiobtnWTS.UseVisualStyleBackColor = true;
            // 
            // simplebtnLayMatKhau
            // 
            this.simplebtnLayMatKhau.Location = new System.Drawing.Point(326, 43);
            this.simplebtnLayMatKhau.Name = "simplebtnLayMatKhau";
            this.simplebtnLayMatKhau.Size = new System.Drawing.Size(75, 23);
            this.simplebtnLayMatKhau.TabIndex = 13;
            this.simplebtnLayMatKhau.Text = "Lấy mật khẩu";
            this.simplebtnLayMatKhau.Click += new System.EventHandler(this.simplebtnLayMatKhau_Click);
            // 
            // XtraControl7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.lbMes);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtMSNV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.simplebtnLayMatKhau);
            this.Name = "XtraControl7";
            this.Size = new System.Drawing.Size(863, 574);
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSNV.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMK;
        private DevExpress.XtraEditors.LabelControl lbMes;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMSNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobtnITS;
        private System.Windows.Forms.RadioButton radiobtnERP;
        private System.Windows.Forms.RadioButton radiobtnAGP;
        private System.Windows.Forms.RadioButton radiobtnWTS;
        private DevExpress.XtraEditors.SimpleButton simplebtnLayMatKhau;
    }
}

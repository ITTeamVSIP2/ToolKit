namespace SupportTools
{
    partial class XtraControl4
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
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Invoice = new DevExpress.XtraEditors.TextEdit();
            this.simplebtnTruyVan = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDongBoInvoice = new DevExpress.XtraEditors.SimpleButton();
            this.dgInvoice = new System.Windows.Forms.DataGridView();
            this.InvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportPassel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalYards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Invoice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(24, 24);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(67, 13);
            this.labelControl9.TabIndex = 53;
            this.labelControl9.Text = "Nhập Invoice:";
            // 
            // txt_Invoice
            // 
            this.txt_Invoice.EditValue = "";
            this.txt_Invoice.Location = new System.Drawing.Point(97, 21);
            this.txt_Invoice.Name = "txt_Invoice";
            this.txt_Invoice.Size = new System.Drawing.Size(162, 20);
            this.txt_Invoice.TabIndex = 54;
            // 
            // simplebtnTruyVan
            // 
            this.simplebtnTruyVan.Location = new System.Drawing.Point(265, 19);
            this.simplebtnTruyVan.Name = "simplebtnTruyVan";
            this.simplebtnTruyVan.Size = new System.Drawing.Size(75, 23);
            this.simplebtnTruyVan.TabIndex = 55;
            this.simplebtnTruyVan.Text = "Truy vấn";
            this.simplebtnTruyVan.Click += new System.EventHandler(this.simplebtnTruyVan_Click);
            // 
            // simpleButtonDongBoInvoice
            // 
            this.simpleButtonDongBoInvoice.Location = new System.Drawing.Point(346, 19);
            this.simpleButtonDongBoInvoice.Name = "simpleButtonDongBoInvoice";
            this.simpleButtonDongBoInvoice.Size = new System.Drawing.Size(101, 23);
            this.simpleButtonDongBoInvoice.TabIndex = 56;
            this.simpleButtonDongBoInvoice.Text = "Đồng bộ invoice";
            this.simpleButtonDongBoInvoice.Click += new System.EventHandler(this.simpleButtonDongBoInvoice_Click);
            // 
            // dgInvoice
            // 
            this.dgInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceNo,
            this.CustomerName,
            this.UserName,
            this.CreateDate,
            this.ImportPassel,
            this.TotalYards,
            this.TotalRoll,
            this.ScheduleCode});
            this.dgInvoice.Location = new System.Drawing.Point(24, 48);
            this.dgInvoice.Name = "dgInvoice";
            this.dgInvoice.Size = new System.Drawing.Size(1117, 632);
            this.dgInvoice.TabIndex = 57;
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.DataPropertyName = "InvoiceNo";
            this.InvoiceNo.HeaderText = "Invoice";
            this.InvoiceNo.Name = "InvoiceNo";
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Nhà cung cấp";
            this.CustomerName.Name = "CustomerName";
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Người đổ";
            this.UserName.Name = "UserName";
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "Ngày đổ";
            this.CreateDate.Name = "CreateDate";
            // 
            // ImportPassel
            // 
            this.ImportPassel.DataPropertyName = "ImportPassel";
            this.ImportPassel.HeaderText = "Mã lô";
            this.ImportPassel.Name = "ImportPassel";
            // 
            // TotalYards
            // 
            this.TotalYards.DataPropertyName = "TotalYards";
            this.TotalYards.HeaderText = "Tổng yards";
            this.TotalYards.Name = "TotalYards";
            // 
            // TotalRoll
            // 
            this.TotalRoll.DataPropertyName = "TotalRoll";
            this.TotalRoll.HeaderText = "Tổng roll";
            this.TotalRoll.Name = "TotalRoll";
            // 
            // ScheduleCode
            // 
            this.ScheduleCode.DataPropertyName = "ScheduleCode";
            this.ScheduleCode.HeaderText = "Tình Trạng";
            this.ScheduleCode.Name = "ScheduleCode";
            // 
            // XtraControl4
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(225)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgInvoice);
            this.Controls.Add(this.simpleButtonDongBoInvoice);
            this.Controls.Add(this.simplebtnTruyVan);
            this.Controls.Add(this.txt_Invoice);
            this.Controls.Add(this.labelControl9);
            this.Name = "XtraControl4";
            this.Size = new System.Drawing.Size(1164, 700);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Invoice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txt_Invoice;
        private DevExpress.XtraEditors.SimpleButton simplebtnTruyVan;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDongBoInvoice;
        private System.Windows.Forms.DataGridView dgInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportPassel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalYards;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleCode;
    }
}

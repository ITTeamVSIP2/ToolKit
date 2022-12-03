namespace SupportTools
{
    partial class CapNhatQCMPQ
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgInvoice = new System.Windows.Forms.DataGridView();
            this.InvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportPassel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalYards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simpleButtonDongBoInvoice = new DevExpress.XtraEditors.SimpleButton();
            this.simplebtnTruyVan = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Invoice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Invoice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.dgInvoice);
            this.groupControl1.Controls.Add(this.simpleButtonDongBoInvoice);
            this.groupControl1.Controls.Add(this.simplebtnTruyVan);
            this.groupControl1.Controls.Add(this.txt_Invoice);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1158, 694);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgInvoice.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgInvoice.Location = new System.Drawing.Point(21, 66);
            this.dgInvoice.Name = "dgInvoice";
            this.dgInvoice.Size = new System.Drawing.Size(1116, 612);
            this.dgInvoice.TabIndex = 62;
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
            // simpleButtonDongBoInvoice
            // 
            this.simpleButtonDongBoInvoice.Location = new System.Drawing.Point(380, 6);
            this.simpleButtonDongBoInvoice.Margin = new System.Windows.Forms.Padding(0);
            this.simpleButtonDongBoInvoice.Name = "simpleButtonDongBoInvoice";
            this.simpleButtonDongBoInvoice.Size = new System.Drawing.Size(100, 40);
            this.simpleButtonDongBoInvoice.TabIndex = 61;
            this.simpleButtonDongBoInvoice.Text = "Đồng bộ invoice";
            // 
            // simplebtnTruyVan
            // 
            this.simplebtnTruyVan.Location = new System.Drawing.Point(274, 6);
            this.simplebtnTruyVan.Name = "simplebtnTruyVan";
            this.simplebtnTruyVan.Size = new System.Drawing.Size(100, 40);
            this.simplebtnTruyVan.TabIndex = 60;
            this.simplebtnTruyVan.Text = "Truy vấn";
            // 
            // txt_Invoice
            // 
            this.txt_Invoice.EditValue = "";
            this.txt_Invoice.Location = new System.Drawing.Point(96, 7);
            this.txt_Invoice.Name = "txt_Invoice";
            this.txt_Invoice.Size = new System.Drawing.Size(162, 20);
            this.txt_Invoice.TabIndex = 59;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(23, 10);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(67, 13);
            this.labelControl9.TabIndex = 58;
            this.labelControl9.Text = "Nhập Invoice:";
            // 
            // CapNhatQCMPQ
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "CapNhatQCMPQ";
            this.Size = new System.Drawing.Size(1164, 700);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Invoice.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportPassel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalYards;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleCode;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDongBoInvoice;
        private DevExpress.XtraEditors.SimpleButton simplebtnTruyVan;
        private DevExpress.XtraEditors.TextEdit txt_Invoice;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.DataGridView dgInvoice;
    }
}

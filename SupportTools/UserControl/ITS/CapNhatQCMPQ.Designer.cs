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
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapNhatQCMPQ));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgInvoice = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImportPassel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalYards = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalRoll = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScheduleCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButtonDongBoInvoice = new DevExpress.XtraEditors.SimpleButton();
            this.simplebtnTruyVan = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Invoice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.collectionDataSource1 = new DevExpress.Persistent.Base.ReportsV2.CollectionDataSource();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Invoice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSource1)).BeginInit();
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
            this.dgInvoice.DataMember = "Query";
            this.dgInvoice.DataSource = this.sqlDataSource3;
            this.dgInvoice.Location = new System.Drawing.Point(13, 62);
            this.dgInvoice.MainView = this.gridView1;
            this.dgInvoice.Name = "dgInvoice";
            this.dgInvoice.Size = new System.Drawing.Size(1132, 615);
            this.dgInvoice.TabIndex = 63;
            this.dgInvoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.ConnectionName = "localhost_FEAERP_VN_Connection";
            this.sqlDataSource3.Name = "sqlDataSource3";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSource3.ResultSchemaSerializable = resources.GetString("sqlDataSource3.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvoiceNo,
            this.colCustomerID,
            this.colCustomerName,
            this.colUserID,
            this.colUserName,
            this.colCreateDate,
            this.colImportPassel,
            this.colTotalYards,
            this.colTotalRoll,
            this.colScheduleCode});
            this.gridView1.GridControl = this.dgInvoice;
            this.gridView1.Name = "gridView1";
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.Caption = "Invoice";
            this.colInvoiceNo.FieldName = "InvoiceNo";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.Visible = true;
            this.colInvoiceNo.VisibleIndex = 0;
            // 
            // colCustomerID
            // 
            this.colCustomerID.Caption = "Mã nhà cung cấp";
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Visible = true;
            this.colCustomerID.VisibleIndex = 1;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Tên nhà cung cấp";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 2;
            // 
            // colUserID
            // 
            this.colUserID.FieldName = "UserID";
            this.colUserID.Name = "colUserID";
            this.colUserID.Visible = true;
            this.colUserID.VisibleIndex = 3;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "Người đổ";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 4;
            // 
            // colCreateDate
            // 
            this.colCreateDate.Caption = "Ngày đổ";
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 5;
            // 
            // colImportPassel
            // 
            this.colImportPassel.Caption = "Mã lô";
            this.colImportPassel.FieldName = "ImportPassel";
            this.colImportPassel.Name = "colImportPassel";
            this.colImportPassel.Visible = true;
            this.colImportPassel.VisibleIndex = 6;
            // 
            // colTotalYards
            // 
            this.colTotalYards.Caption = "Tổng yards";
            this.colTotalYards.FieldName = "TotalYards";
            this.colTotalYards.Name = "colTotalYards";
            this.colTotalYards.Visible = true;
            this.colTotalYards.VisibleIndex = 7;
            // 
            // colTotalRoll
            // 
            this.colTotalRoll.Caption = "Tổng roll";
            this.colTotalRoll.FieldName = "TotalRoll";
            this.colTotalRoll.Name = "colTotalRoll";
            this.colTotalRoll.Visible = true;
            this.colTotalRoll.VisibleIndex = 8;
            // 
            // colScheduleCode
            // 
            this.colScheduleCode.Caption = "Tình trạng";
            this.colScheduleCode.FieldName = "ScheduleCode";
            this.colScheduleCode.Name = "colScheduleCode";
            this.colScheduleCode.Visible = true;
            this.colScheduleCode.VisibleIndex = 9;
            // 
            // simpleButtonDongBoInvoice
            // 
            this.simpleButtonDongBoInvoice.Location = new System.Drawing.Point(380, 6);
            this.simpleButtonDongBoInvoice.Margin = new System.Windows.Forms.Padding(0);
            this.simpleButtonDongBoInvoice.Name = "simpleButtonDongBoInvoice";
            this.simpleButtonDongBoInvoice.Size = new System.Drawing.Size(150, 40);
            this.simpleButtonDongBoInvoice.TabIndex = 61;
            this.simpleButtonDongBoInvoice.Text = "Đồng bộ invoice";
            this.simpleButtonDongBoInvoice.Click += new System.EventHandler(this.simpleButtonDongBoInvoice_Click);
            // 
            // simplebtnTruyVan
            // 
            this.simplebtnTruyVan.Location = new System.Drawing.Point(274, 6);
            this.simplebtnTruyVan.Name = "simplebtnTruyVan";
            this.simplebtnTruyVan.Size = new System.Drawing.Size(100, 40);
            this.simplebtnTruyVan.TabIndex = 60;
            this.simplebtnTruyVan.Text = "Truy vấn";
            this.simplebtnTruyVan.Click += new System.EventHandler(this.simplebtnTruyVan_Click);
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
            // collectionDataSource1
            // 
            this.collectionDataSource1.Name = "collectionDataSource1";
            this.collectionDataSource1.ObjectTypeName = null;
            this.collectionDataSource1.TopReturnedRecords = 0;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.Name = "sqlDataSource2";
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
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Invoice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDongBoInvoice;
        private DevExpress.XtraEditors.SimpleButton simplebtnTruyVan;
        private DevExpress.XtraEditors.TextEdit txt_Invoice;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.Persistent.Base.ReportsV2.CollectionDataSource collectionDataSource1;
        private DevExpress.XtraGrid.GridControl dgInvoice;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colImportPassel;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalYards;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalRoll;
        private DevExpress.XtraGrid.Columns.GridColumn colScheduleCode;
    }
}

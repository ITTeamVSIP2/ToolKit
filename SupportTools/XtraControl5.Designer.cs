namespace SupportTools
{
    partial class XtraControl5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraControl5));
            this.sBtnHoanThanh = new DevExpress.XtraEditors.SimpleButton();
            this.gctrlDR = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDR = new DevExpress.XtraEditors.TextEdit();
            this.sBtnTruyVan = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.memoFEPO = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sBtnChoPhepFEPO = new DevExpress.XtraEditors.SimpleButton();
            this.sBtnTruyVanFEPO = new DevExpress.XtraEditors.SimpleButton();
            this.gctrlListFEPO = new DevExpress.XtraGrid.GridControl();
            this.gridViewListFEPO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simplebtnPLDong = new DevExpress.XtraEditors.SimpleButton();
            this.simplebtnMRDong = new DevExpress.XtraEditors.SimpleButton();
            this.simplebtnPLMo = new DevExpress.XtraEditors.SimpleButton();
            this.simplebtnMRMo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gctrlDR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoFEPO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctrlListFEPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListFEPO)).BeginInit();
            this.SuspendLayout();
            // 
            // sBtnHoanThanh
            // 
            this.sBtnHoanThanh.Location = new System.Drawing.Point(291, 19);
            this.sBtnHoanThanh.Name = "sBtnHoanThanh";
            this.sBtnHoanThanh.Size = new System.Drawing.Size(75, 23);
            this.sBtnHoanThanh.TabIndex = 9;
            this.sBtnHoanThanh.Text = "Hoàn thành";
            this.sBtnHoanThanh.Click += new System.EventHandler(this.sBtnHoanThanh_Click);
            // 
            // gctrlDR
            // 
            this.gctrlDR.Location = new System.Drawing.Point(24, 85);
            this.gctrlDR.MainView = this.gridView1;
            this.gctrlDR.Name = "gctrlDR";
            this.gctrlDR.Size = new System.Drawing.Size(742, 163);
            this.gctrlDR.TabIndex = 8;
            this.gctrlDR.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn11,
            this.gridColumn3});
            this.gridView1.GridControl = this.gctrlDR;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "OrderCode";
            this.gridColumn1.FieldName = "OrderCode";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "FEPO";
            this.gridColumn2.FieldName = "FEPO";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Creator";
            this.gridColumn11.FieldName = "Creator";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "CreateDate";
            this.gridColumn3.FieldName = "CreateDate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // txtDR
            // 
            this.txtDR.EditValue = "";
            this.txtDR.Location = new System.Drawing.Point(69, 21);
            this.txtDR.Name = "txtDR";
            this.txtDR.Size = new System.Drawing.Size(135, 20);
            this.txtDR.TabIndex = 1;
            // 
            // sBtnTruyVan
            // 
            this.sBtnTruyVan.Location = new System.Drawing.Point(210, 19);
            this.sBtnTruyVan.Name = "sBtnTruyVan";
            this.sBtnTruyVan.Size = new System.Drawing.Size(75, 23);
            this.sBtnTruyVan.TabIndex = 6;
            this.sBtnTruyVan.Text = "Truy vấn";
            this.sBtnTruyVan.Click += new System.EventHandler(this.sBtnTruyVan_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(24, 24);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(39, 13);
            this.labelControl9.TabIndex = 53;
            this.labelControl9.Text = "Mã đơn:";
            // 
            // memoEdit1
            // 
            this.memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue");
            this.memoEdit1.Location = new System.Drawing.Point(220, 311);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(546, 144);
            this.memoEdit1.TabIndex = 59;
            // 
            // memoFEPO
            // 
            this.memoFEPO.Location = new System.Drawing.Point(24, 286);
            this.memoFEPO.Name = "memoFEPO";
            this.memoFEPO.Size = new System.Drawing.Size(109, 169);
            this.memoFEPO.TabIndex = 58;
            this.memoFEPO.TextChanged += new System.EventHandler(this.memoFEPO_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(220, 292);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 13);
            this.labelControl1.TabIndex = 57;
            this.labelControl1.Text = "Quy định: IT -> MR -> PL.";
            // 
            // sBtnChoPhepFEPO
            // 
            this.sBtnChoPhepFEPO.Enabled = false;
            this.sBtnChoPhepFEPO.Location = new System.Drawing.Point(139, 316);
            this.sBtnChoPhepFEPO.Name = "sBtnChoPhepFEPO";
            this.sBtnChoPhepFEPO.Size = new System.Drawing.Size(75, 23);
            this.sBtnChoPhepFEPO.TabIndex = 56;
            this.sBtnChoPhepFEPO.Text = "IT cho phép";
            this.sBtnChoPhepFEPO.Click += new System.EventHandler(this.sBtnChoPhepFEPO_Click);
            // 
            // sBtnTruyVanFEPO
            // 
            this.sBtnTruyVanFEPO.Location = new System.Drawing.Point(139, 287);
            this.sBtnTruyVanFEPO.Name = "sBtnTruyVanFEPO";
            this.sBtnTruyVanFEPO.Size = new System.Drawing.Size(75, 23);
            this.sBtnTruyVanFEPO.TabIndex = 55;
            this.sBtnTruyVanFEPO.Text = "Truy vấn";
            this.sBtnTruyVanFEPO.Click += new System.EventHandler(this.sBtnTruyVanFEPO_Click);
            // 
            // gctrlListFEPO
            // 
            this.gctrlListFEPO.Location = new System.Drawing.Point(24, 461);
            this.gctrlListFEPO.MainView = this.gridViewListFEPO;
            this.gctrlListFEPO.Name = "gctrlListFEPO";
            this.gctrlListFEPO.Size = new System.Drawing.Size(742, 223);
            this.gctrlListFEPO.TabIndex = 54;
            this.gctrlListFEPO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewListFEPO});
            // 
            // gridViewListFEPO
            // 
            this.gridViewListFEPO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn12,
            this.gridColumn8,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn9,
            this.gridColumn10});
            this.gridViewListFEPO.GridControl = this.gctrlListFEPO;
            this.gridViewListFEPO.Name = "gridViewListFEPO";
            this.gridViewListFEPO.OptionsSelection.MultiSelect = true;
            this.gridViewListFEPO.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewListFEPO.DoubleClick += new System.EventHandler(this.gridViewListFEPO_DoubleClick);
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "OrderID";
            this.gridColumn12.FieldName = "OrderID";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            this.gridColumn12.Width = 120;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "OrderType";
            this.gridColumn8.FieldName = "OrderType";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 85;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "FEPOCode";
            this.gridColumn4.FieldName = "FEPOCode";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 90;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "IT Request";
            this.gridColumn5.FieldName = "IT Request";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 100;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "IT";
            this.gridColumn6.FieldName = "IT";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 90;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "MR";
            this.gridColumn7.FieldName = "MR";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 70;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Planning";
            this.gridColumn9.FieldName = "Planning";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            this.gridColumn9.Width = 70;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "CloseDate";
            this.gridColumn10.FieldName = "CloseDate";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 7;
            this.gridColumn10.Width = 80;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(24, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(167, 16);
            this.labelControl2.TabIndex = 60;
            this.labelControl2.Text = "Thông tin đơn yêu cầu ITS";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(24, 264);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(153, 16);
            this.labelControl3.TabIndex = 61;
            this.labelControl3.Text = "Thông tin đóng mở FEPO";
            // 
            // simplebtnPLDong
            // 
            this.simplebtnPLDong.Enabled = false;
            this.simplebtnPLDong.Location = new System.Drawing.Point(139, 432);
            this.simplebtnPLDong.Name = "simplebtnPLDong";
            this.simplebtnPLDong.Size = new System.Drawing.Size(75, 23);
            this.simplebtnPLDong.TabIndex = 62;
            this.simplebtnPLDong.Text = "SX đóng";
            this.simplebtnPLDong.Click += new System.EventHandler(this.simplebtnPLDong_Click);
            // 
            // simplebtnMRDong
            // 
            this.simplebtnMRDong.Enabled = false;
            this.simplebtnMRDong.Location = new System.Drawing.Point(139, 403);
            this.simplebtnMRDong.Name = "simplebtnMRDong";
            this.simplebtnMRDong.Size = new System.Drawing.Size(75, 23);
            this.simplebtnMRDong.TabIndex = 63;
            this.simplebtnMRDong.Text = "MR đóng";
            this.simplebtnMRDong.Click += new System.EventHandler(this.simplebtnMRDong_Click);
            // 
            // simplebtnPLMo
            // 
            this.simplebtnPLMo.Enabled = false;
            this.simplebtnPLMo.Location = new System.Drawing.Point(139, 374);
            this.simplebtnPLMo.Name = "simplebtnPLMo";
            this.simplebtnPLMo.Size = new System.Drawing.Size(75, 23);
            this.simplebtnPLMo.TabIndex = 64;
            this.simplebtnPLMo.Text = "PL mở";
            this.simplebtnPLMo.Click += new System.EventHandler(this.simplebtnPLMo_Click);
            // 
            // simplebtnMRMo
            // 
            this.simplebtnMRMo.Enabled = false;
            this.simplebtnMRMo.Location = new System.Drawing.Point(139, 345);
            this.simplebtnMRMo.Name = "simplebtnMRMo";
            this.simplebtnMRMo.Size = new System.Drawing.Size(75, 23);
            this.simplebtnMRMo.TabIndex = 65;
            this.simplebtnMRMo.Text = "MR mở";
            this.simplebtnMRMo.Click += new System.EventHandler(this.simplebtnMRMo_Click);
            // 
            // XtraControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.simplebtnMRMo);
            this.Controls.Add(this.simplebtnPLMo);
            this.Controls.Add(this.simplebtnMRDong);
            this.Controls.Add(this.simplebtnPLDong);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.memoFEPO);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.sBtnChoPhepFEPO);
            this.Controls.Add(this.sBtnTruyVanFEPO);
            this.Controls.Add(this.gctrlListFEPO);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.sBtnHoanThanh);
            this.Controls.Add(this.gctrlDR);
            this.Controls.Add(this.txtDR);
            this.Controls.Add(this.sBtnTruyVan);
            this.Name = "XtraControl5";
            this.Size = new System.Drawing.Size(1164, 700);
            ((System.ComponentModel.ISupportInitialize)(this.gctrlDR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoFEPO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctrlListFEPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListFEPO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sBtnHoanThanh;
        private DevExpress.XtraGrid.GridControl gctrlDR;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.TextEdit txtDR;
        private DevExpress.XtraEditors.SimpleButton sBtnTruyVan;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.MemoEdit memoFEPO;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sBtnChoPhepFEPO;
        private DevExpress.XtraEditors.SimpleButton sBtnTruyVanFEPO;
        private DevExpress.XtraGrid.GridControl gctrlListFEPO;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewListFEPO;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simplebtnPLDong;
        private DevExpress.XtraEditors.SimpleButton simplebtnMRDong;
        private DevExpress.XtraEditors.SimpleButton simplebtnPLMo;
        private DevExpress.XtraEditors.SimpleButton simplebtnMRMo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}

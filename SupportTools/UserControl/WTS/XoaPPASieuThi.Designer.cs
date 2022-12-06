namespace SupportTools
{
    partial class XoaPPASieuThi
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
            this.compositeLink = new DevExpress.XtraPrintingLinks.CompositeLink(this.components);
            this.memoBarcode = new DevExpress.XtraEditors.MemoEdit();
            this.simpleButtonKiemTraInput = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonKiemTraPPA = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonXoaPPA = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonXuatExcel = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.memoBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // memoBarcode
            // 
            this.memoBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.memoBarcode.EditValue = "Nhập barcode:";
            this.memoBarcode.Location = new System.Drawing.Point(16, 6);
            this.memoBarcode.Name = "memoBarcode";
            this.memoBarcode.Size = new System.Drawing.Size(169, 539);
            this.memoBarcode.TabIndex = 67;
            // 
            // simpleButtonKiemTraInput
            // 
            this.simpleButtonKiemTraInput.Location = new System.Drawing.Point(188, 6);
            this.simpleButtonKiemTraInput.Name = "simpleButtonKiemTraInput";
            this.simpleButtonKiemTraInput.Size = new System.Drawing.Size(120, 40);
            this.simpleButtonKiemTraInput.TabIndex = 68;
            this.simpleButtonKiemTraInput.Text = "Kiểm tra input";
            this.simpleButtonKiemTraInput.Click += new System.EventHandler(this.simpleButtonKiemTraInput_Click);
            // 
            // simpleButtonKiemTraPPA
            // 
            this.simpleButtonKiemTraPPA.Location = new System.Drawing.Point(314, 6);
            this.simpleButtonKiemTraPPA.Name = "simpleButtonKiemTraPPA";
            this.simpleButtonKiemTraPPA.Size = new System.Drawing.Size(120, 40);
            this.simpleButtonKiemTraPPA.TabIndex = 69;
            this.simpleButtonKiemTraPPA.Text = "Kiểm tra PPA";
            this.simpleButtonKiemTraPPA.Click += new System.EventHandler(this.simpleButtonKiemTraPPA_Click);
            // 
            // simpleButtonXoaPPA
            // 
            this.simpleButtonXoaPPA.Location = new System.Drawing.Point(546, 6);
            this.simpleButtonXoaPPA.Name = "simpleButtonXoaPPA";
            this.simpleButtonXoaPPA.Size = new System.Drawing.Size(100, 40);
            this.simpleButtonXoaPPA.TabIndex = 70;
            this.simpleButtonXoaPPA.Text = "Xóa PPA";
            this.simpleButtonXoaPPA.Click += new System.EventHandler(this.simpleButtonXoaPPA_Click);
            // 
            // simpleButtonXuatExcel
            // 
            this.simpleButtonXuatExcel.Location = new System.Drawing.Point(440, 6);
            this.simpleButtonXuatExcel.Name = "simpleButtonXuatExcel";
            this.simpleButtonXuatExcel.Size = new System.Drawing.Size(100, 40);
            this.simpleButtonXuatExcel.TabIndex = 72;
            this.simpleButtonXuatExcel.Text = "Xuất excel";
            this.simpleButtonXuatExcel.Click += new System.EventHandler(this.simpleButtonXuatExcel_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(191, 52);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1100, 493);
            this.gridControl1.TabIndex = 73;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Controls.Add(this.simpleButtonXuatExcel);
            this.groupControl1.Controls.Add(this.simpleButtonXoaPPA);
            this.groupControl1.Controls.Add(this.simpleButtonKiemTraPPA);
            this.groupControl1.Controls.Add(this.simpleButtonKiemTraInput);
            this.groupControl1.Controls.Add(this.memoBarcode);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(10);
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1305, 559);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // XoaPPASieuThi
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "XoaPPASieuThi";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 4, 7);
            this.Size = new System.Drawing.Size(1311, 565);
            ((System.ComponentModel.ISupportInitialize)(this.memoBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraPrintingLinks.CompositeLink compositeLink;
        private DevExpress.XtraEditors.MemoEdit memoBarcode;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKiemTraInput;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKiemTraPPA;
        private DevExpress.XtraEditors.SimpleButton simpleButtonXoaPPA;
        private DevExpress.XtraEditors.SimpleButton simpleButtonXuatExcel;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}

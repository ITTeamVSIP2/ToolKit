namespace SupportTools
{
    partial class KhuVucBaoVe
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButtonThem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuyCach = new System.Windows.Forms.TextBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.txtTenVatPham = new System.Windows.Forms.TextBox();
            this.cbNhomHangMuc = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cbBoPhan = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbNguoiDuyet = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Controls.Add(this.simpleButtonThem);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtQuyCach);
            this.groupControl1.Controls.Add(this.cbUnit);
            this.groupControl1.Controls.Add(this.txtTenVatPham);
            this.groupControl1.Controls.Add(this.cbNhomHangMuc);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.cbBoPhan);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.cbNguoiDuyet);
            this.groupControl1.Location = new System.Drawing.Point(4, 3);
            this.groupControl1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1157, 694);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(14, 106);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1128, 573);
            this.gridControl1.TabIndex = 89;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            // 
            // simpleButtonThem
            // 
            this.simpleButtonThem.Location = new System.Drawing.Point(867, 15);
            this.simpleButtonThem.Name = "simpleButtonThem";
            this.simpleButtonThem.Size = new System.Drawing.Size(100, 40);
            this.simpleButtonThem.TabIndex = 87;
            this.simpleButtonThem.Text = "Thêm";
            this.simpleButtonThem.Click += new System.EventHandler(this.simpleButtonThem_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(530, 72);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 88;
            this.labelControl3.Text = "Quy cách:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(509, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.TabIndex = 85;
            this.labelControl2.Text = "Tên vật phẩm:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 13);
            this.labelControl1.TabIndex = 82;
            this.labelControl1.Text = "Nhóm hạng mục:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(544, 45);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(35, 13);
            this.labelControl9.TabIndex = 80;
            this.labelControl9.Text = "Đơn vị:";
            // 
            // txtQuyCach
            // 
            this.txtQuyCach.Location = new System.Drawing.Point(585, 69);
            this.txtQuyCach.Name = "txtQuyCach";
            this.txtQuyCach.Size = new System.Drawing.Size(251, 21);
            this.txtQuyCach.TabIndex = 86;
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(585, 42);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(251, 21);
            this.cbUnit.TabIndex = 84;
            this.cbUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbUnit_KeyDown);
            // 
            // txtTenVatPham
            // 
            this.txtTenVatPham.Location = new System.Drawing.Point(585, 15);
            this.txtTenVatPham.Name = "txtTenVatPham";
            this.txtTenVatPham.Size = new System.Drawing.Size(251, 21);
            this.txtTenVatPham.TabIndex = 83;
            // 
            // cbNhomHangMuc
            // 
            this.cbNhomHangMuc.FormattingEnabled = true;
            this.cbNhomHangMuc.Location = new System.Drawing.Point(100, 15);
            this.cbNhomHangMuc.Name = "cbNhomHangMuc";
            this.cbNhomHangMuc.Size = new System.Drawing.Size(347, 21);
            this.cbNhomHangMuc.TabIndex = 78;
            this.cbNhomHangMuc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbNhomHangMuc_KeyDown);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(51, 45);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(43, 13);
            this.labelControl8.TabIndex = 91;
            this.labelControl8.Text = "Bộ phận:";
            // 
            // cbBoPhan
            // 
            this.cbBoPhan.FormattingEnabled = true;
            this.cbBoPhan.Location = new System.Drawing.Point(100, 42);
            this.cbBoPhan.Name = "cbBoPhan";
            this.cbBoPhan.Size = new System.Drawing.Size(347, 21);
            this.cbBoPhan.TabIndex = 79;
            this.cbBoPhan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbBoPhan_KeyDown);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(17, 72);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(77, 13);
            this.labelControl6.TabIndex = 90;
            this.labelControl6.Text = "Người ký duyệt:";
            // 
            // cbNguoiDuyet
            // 
            this.cbNguoiDuyet.FormattingEnabled = true;
            this.cbNguoiDuyet.Location = new System.Drawing.Point(100, 69);
            this.cbNguoiDuyet.Name = "cbNguoiDuyet";
            this.cbNguoiDuyet.Size = new System.Drawing.Size(347, 21);
            this.cbNguoiDuyet.TabIndex = 81;
            this.cbNguoiDuyet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbNguoiDuyet_KeyDown);
            // 
            // KhuVucBaoVe
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "Office 2007 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "KhuVucBaoVe";
            this.Size = new System.Drawing.Size(1164, 700);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThem;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.TextBox txtQuyCach;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.TextBox txtTenVatPham;
        private System.Windows.Forms.ComboBox cbNhomHangMuc;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.ComboBox cbBoPhan;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ComboBox cbNguoiDuyet;
    }
}

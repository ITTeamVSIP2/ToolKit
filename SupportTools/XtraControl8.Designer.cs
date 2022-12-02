namespace SupportTools
{
    partial class XtraControl8
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonThem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbNguoiDuyet = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cbBoPhan = new System.Windows.Forms.ComboBox();
            this.cbNhomHangMuc = new System.Windows.Forms.ComboBox();
            this.txtTenVatPham = new System.Windows.Forms.TextBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.txtQuyCach = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(554, 51);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(35, 13);
            this.labelControl9.TabIndex = 60;
            this.labelControl9.Text = "Đơn vị:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 13);
            this.labelControl1.TabIndex = 61;
            this.labelControl1.Text = "Nhóm hạng mục:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(519, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.TabIndex = 63;
            this.labelControl2.Text = "Tên vật phẩm:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(540, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 65;
            this.labelControl3.Text = "Quy cách:";
            // 
            // simpleButtonThem
            // 
            this.simpleButtonThem.Location = new System.Drawing.Point(865, 73);
            this.simpleButtonThem.Name = "simpleButtonThem";
            this.simpleButtonThem.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonThem.TabIndex = 64;
            this.simpleButtonThem.Text = "Thêm";
            this.simpleButtonThem.Click += new System.EventHandler(this.simpleButtonThem_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(24, 112);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1128, 572);
            this.gridControl1.TabIndex = 69;
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
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(27, 78);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(77, 13);
            this.labelControl6.TabIndex = 73;
            this.labelControl6.Text = "Người ký duyệt:";
            // 
            // cbNguoiDuyet
            // 
            this.cbNguoiDuyet.FormattingEnabled = true;
            this.cbNguoiDuyet.Location = new System.Drawing.Point(110, 75);
            this.cbNguoiDuyet.Name = "cbNguoiDuyet";
            this.cbNguoiDuyet.Size = new System.Drawing.Size(347, 21);
            this.cbNguoiDuyet.TabIndex = 60;
            this.cbNguoiDuyet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbNguoiDuyet_KeyDown);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(61, 51);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(43, 13);
            this.labelControl8.TabIndex = 77;
            this.labelControl8.Text = "Bộ phận:";
            // 
            // cbBoPhan
            // 
            this.cbBoPhan.FormattingEnabled = true;
            this.cbBoPhan.Location = new System.Drawing.Point(110, 48);
            this.cbBoPhan.Name = "cbBoPhan";
            this.cbBoPhan.Size = new System.Drawing.Size(347, 21);
            this.cbBoPhan.TabIndex = 59;
            this.cbBoPhan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbBoPhan_KeyDown);
            // 
            // cbNhomHangMuc
            // 
            this.cbNhomHangMuc.FormattingEnabled = true;
            this.cbNhomHangMuc.Location = new System.Drawing.Point(110, 21);
            this.cbNhomHangMuc.Name = "cbNhomHangMuc";
            this.cbNhomHangMuc.Size = new System.Drawing.Size(347, 21);
            this.cbNhomHangMuc.TabIndex = 58;
            this.cbNhomHangMuc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbNhomHangMuc_KeyDown);
            // 
            // txtTenVatPham
            // 
            this.txtTenVatPham.Location = new System.Drawing.Point(595, 21);
            this.txtTenVatPham.Name = "txtTenVatPham";
            this.txtTenVatPham.Size = new System.Drawing.Size(251, 21);
            this.txtTenVatPham.TabIndex = 61;
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(595, 48);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(251, 21);
            this.cbUnit.TabIndex = 62;
            this.cbUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbUnit_KeyDown);
            // 
            // txtQuyCach
            // 
            this.txtQuyCach.Location = new System.Drawing.Point(595, 75);
            this.txtQuyCach.Name = "txtQuyCach";
            this.txtQuyCach.Size = new System.Drawing.Size(251, 21);
            this.txtQuyCach.TabIndex = 63;
            // 
            // XtraControl8
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(225)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtQuyCach);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.txtTenVatPham);
            this.Controls.Add(this.cbNhomHangMuc);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.cbBoPhan);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.cbNguoiDuyet);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButtonThem);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl9);
            this.Name = "XtraControl8";
            this.Size = new System.Drawing.Size(1164, 700);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ComboBox cbNguoiDuyet;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.ComboBox cbBoPhan;
        private System.Windows.Forms.ComboBox cbNhomHangMuc;
        private System.Windows.Forms.TextBox txtTenVatPham;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.TextBox txtQuyCach;
    }
}

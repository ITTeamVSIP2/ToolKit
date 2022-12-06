namespace SupportTools
{
    partial class Frm_EditERP
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbLoaiDon = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simplebtnKiemTra = new DevExpress.XtraEditors.SimpleButton();
            this.simplebtnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.txtTrangThai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaDon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLoaiDon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.cmbLoaiDon);
            this.groupControl1.Controls.Add(this.gridControl4);
            this.groupControl1.Controls.Add(this.simplebtnKiemTra);
            this.groupControl1.Controls.Add(this.simplebtnCapNhat);
            this.groupControl1.Controls.Add(this.txtTrangThai);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtMaDon);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(-1, 0);
            this.groupControl1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(530, 197);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // cmbLoaiDon
            // 
            this.cmbLoaiDon.Location = new System.Drawing.Point(128, 24);
            this.cmbLoaiDon.Name = "cmbLoaiDon";
            this.cmbLoaiDon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLoaiDon.Properties.Items.AddRange(new object[] {
            "Phiếu thanh toán từ ERP",
            "Phiếu yêu cầu vải (SX)",
            "Đơn xin gia công",
            "Phiếu đề nghị tiêu hủy",
            "Phiếu khác từ ERP"});
            this.cmbLoaiDon.Size = new System.Drawing.Size(185, 20);
            this.cmbLoaiDon.TabIndex = 73;
            // 
            // gridControl4
            // 
            this.gridControl4.Location = new System.Drawing.Point(319, 24);
            this.gridControl4.MainView = this.gridView4;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(187, 154);
            this.gridControl4.TabIndex = 72;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gridControl4;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.ReadOnly = true;
            this.gridView4.OptionsSelection.MultiSelect = true;
            this.gridView4.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            // 
            // simplebtnKiemTra
            // 
            this.simplebtnKiemTra.Location = new System.Drawing.Point(157, 103);
            this.simplebtnKiemTra.Name = "simplebtnKiemTra";
            this.simplebtnKiemTra.Size = new System.Drawing.Size(75, 23);
            this.simplebtnKiemTra.TabIndex = 71;
            this.simplebtnKiemTra.Text = "Kiểm tra";
            // 
            // simplebtnCapNhat
            // 
            this.simplebtnCapNhat.Location = new System.Drawing.Point(238, 103);
            this.simplebtnCapNhat.Name = "simplebtnCapNhat";
            this.simplebtnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.simplebtnCapNhat.TabIndex = 70;
            this.simplebtnCapNhat.Text = "Cập nhật";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.EditValue = "";
            this.txtTrangThai.Location = new System.Drawing.Point(128, 77);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(185, 20);
            this.txtTrangThai.TabIndex = 69;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(98, 13);
            this.labelControl3.TabIndex = 68;
            this.labelControl3.Text = "Trạng thái cập nhật:";
            // 
            // txtMaDon
            // 
            this.txtMaDon.EditValue = "";
            this.txtMaDon.Location = new System.Drawing.Point(128, 51);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Size = new System.Drawing.Size(185, 20);
            this.txtMaDon.TabIndex = 67;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(83, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 66;
            this.labelControl1.Text = "Mã đơn:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(78, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 65;
            this.labelControl2.Text = "Loại đơn:";
            // 
            // Frm_EditERP
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 195);
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Frm_EditERP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_EditERP";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLoaiDon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDon.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbLoaiDon;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.SimpleButton simplebtnKiemTra;
        private DevExpress.XtraEditors.SimpleButton simplebtnCapNhat;
        private DevExpress.XtraEditors.TextEdit txtTrangThai;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMaDon;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}
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
            this.cmbLoaiDon = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaDon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTrangThai = new DevExpress.XtraEditors.TextEdit();
            this.simplebtnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.simplebtnKiemTra = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLoaiDon
            // 
            this.cmbLoaiDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiDon.FormattingEnabled = true;
            this.cmbLoaiDon.Items.AddRange(new object[] {
            "Phiếu thanh toán từ ERP",
            "Phiếu yêu cầu vải (SX)",
            "Đơn xin gia công",
            "Phiếu đề nghị tiêu hủy",
            "Phiếu khác từ ERP"});
            this.cmbLoaiDon.Location = new System.Drawing.Point(128, 21);
            this.cmbLoaiDon.Name = "cmbLoaiDon";
            this.cmbLoaiDon.Size = new System.Drawing.Size(185, 21);
            this.cmbLoaiDon.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(78, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Loại đơn:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(83, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Mã đơn:";
            // 
            // txtMaDon
            // 
            this.txtMaDon.EditValue = "";
            this.txtMaDon.Location = new System.Drawing.Point(128, 48);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Size = new System.Drawing.Size(185, 20);
            this.txtMaDon.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(98, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Trạng thái cập nhật:";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.EditValue = "";
            this.txtTrangThai.Location = new System.Drawing.Point(128, 74);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(185, 20);
            this.txtTrangThai.TabIndex = 17;
            // 
            // simplebtnCapNhat
            // 
            this.simplebtnCapNhat.Location = new System.Drawing.Point(238, 100);
            this.simplebtnCapNhat.Name = "simplebtnCapNhat";
            this.simplebtnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.simplebtnCapNhat.TabIndex = 18;
            this.simplebtnCapNhat.Text = "Cập nhật";
            this.simplebtnCapNhat.Click += new System.EventHandler(this.simplebtnCapNhat_Click);
            // 
            // simplebtnKiemTra
            // 
            this.simplebtnKiemTra.Location = new System.Drawing.Point(157, 100);
            this.simplebtnKiemTra.Name = "simplebtnKiemTra";
            this.simplebtnKiemTra.Size = new System.Drawing.Size(75, 23);
            this.simplebtnKiemTra.TabIndex = 62;
            this.simplebtnKiemTra.Text = "Kiểm tra";
            this.simplebtnKiemTra.Click += new System.EventHandler(this.simplebtnKiemTra_Click);
            // 
            // gridControl4
            // 
            this.gridControl4.Location = new System.Drawing.Point(319, 21);
            this.gridControl4.MainView = this.gridView4;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(187, 154);
            this.gridControl4.TabIndex = 63;
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
            this.gridView4.Click += new System.EventHandler(this.gridView4_Click);
            // 
            // Frm_EditERP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 201);
            this.Controls.Add(this.gridControl4);
            this.Controls.Add(this.simplebtnKiemTra);
            this.Controls.Add(this.simplebtnCapNhat);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtMaDon);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmbLoaiDon);
            this.Name = "Frm_EditERP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_EditERP";
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLoaiDon;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaDon;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTrangThai;
        private DevExpress.XtraEditors.SimpleButton simplebtnCapNhat;
        private DevExpress.XtraEditors.SimpleButton simplebtnKiemTra;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
    }
}
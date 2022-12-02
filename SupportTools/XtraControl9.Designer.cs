namespace SupportTools
{
    partial class XtraControl9
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
            this.memoBarcode = new DevExpress.XtraEditors.MemoEdit();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.simpleButtonKiemTraInput = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonKiemTraPPA = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonXoaPPA = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonXuatExcel = new DevExpress.XtraEditors.SimpleButton();
            this.compositeLink = new DevExpress.XtraPrintingLinks.CompositeLink(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.memoBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // memoBarcode
            // 
            this.memoBarcode.EditValue = "";
            this.memoBarcode.Location = new System.Drawing.Point(24, 43);
            this.memoBarcode.Name = "memoBarcode";
            this.memoBarcode.Size = new System.Drawing.Size(133, 640);
            this.memoBarcode.TabIndex = 59;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(172, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(983, 341);
            this.dataGridView1.TabIndex = 60;
            // 
            // simpleButtonKiemTraInput
            // 
            this.simpleButtonKiemTraInput.Location = new System.Drawing.Point(172, 44);
            this.simpleButtonKiemTraInput.Name = "simpleButtonKiemTraInput";
            this.simpleButtonKiemTraInput.Size = new System.Drawing.Size(81, 23);
            this.simpleButtonKiemTraInput.TabIndex = 61;
            this.simpleButtonKiemTraInput.Text = "Kiểm tra input";
            this.simpleButtonKiemTraInput.Click += new System.EventHandler(this.simpleButtonKiemTraInput_Click);
            // 
            // simpleButtonKiemTraPPA
            // 
            this.simpleButtonKiemTraPPA.Location = new System.Drawing.Point(259, 44);
            this.simpleButtonKiemTraPPA.Name = "simpleButtonKiemTraPPA";
            this.simpleButtonKiemTraPPA.Size = new System.Drawing.Size(81, 23);
            this.simpleButtonKiemTraPPA.TabIndex = 62;
            this.simpleButtonKiemTraPPA.Text = "Kiểm tra PPA";
            this.simpleButtonKiemTraPPA.Click += new System.EventHandler(this.simpleButtonKiemTraPPA_Click);
            // 
            // simpleButtonXoaPPA
            // 
            this.simpleButtonXoaPPA.Location = new System.Drawing.Point(433, 44);
            this.simpleButtonXoaPPA.Name = "simpleButtonXoaPPA";
            this.simpleButtonXoaPPA.Size = new System.Drawing.Size(81, 23);
            this.simpleButtonXoaPPA.TabIndex = 63;
            this.simpleButtonXoaPPA.Text = "Xóa PPA";
            this.simpleButtonXoaPPA.Click += new System.EventHandler(this.simpleButtonXoaPPA_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(24, 24);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(71, 13);
            this.labelControl9.TabIndex = 64;
            this.labelControl9.Text = "Nhập barcode:";
            // 
            // simpleButtonXuatExcel
            // 
            this.simpleButtonXuatExcel.Location = new System.Drawing.Point(346, 44);
            this.simpleButtonXuatExcel.Name = "simpleButtonXuatExcel";
            this.simpleButtonXuatExcel.Size = new System.Drawing.Size(81, 23);
            this.simpleButtonXuatExcel.TabIndex = 65;
            this.simpleButtonXuatExcel.Text = "Xuất excel";
            this.simpleButtonXuatExcel.Click += new System.EventHandler(this.simpleButtonXuatExcel_Click);
            // 
            // compositeLink
            // 
            this.compositeLink.PrintingSystemBase = null;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(172, 73);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(960, 510);
            this.gridControl1.TabIndex = 66;
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
            // XtraControl9
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(225)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButtonXuatExcel);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.simpleButtonXoaPPA);
            this.Controls.Add(this.simpleButtonKiemTraPPA);
            this.Controls.Add(this.simpleButtonKiemTraInput);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.memoBarcode);
            this.Name = "XtraControl9";
            this.Size = new System.Drawing.Size(1164, 700);
            ((System.ComponentModel.ISupportInitialize)(this.memoBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit memoBarcode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKiemTraInput;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKiemTraPPA;
        private DevExpress.XtraEditors.SimpleButton simpleButtonXoaPPA;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton simpleButtonXuatExcel;
        private DevExpress.XtraPrintingLinks.CompositeLink compositeLink;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}

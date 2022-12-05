﻿
namespace SupportTools
{
    partial class ThemTickGP
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnCapNhatTick0 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnCapNhatTick = new DevExpress.XtraEditors.SimpleButton();
            this.memoBarcode = new DevExpress.XtraEditors.MemoEdit();
            this.bthKiemTraTick = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoBarcode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(756, 276);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl2.Controls.Add(this.btnCapNhatTick0);
            this.groupControl2.Controls.Add(this.gridControl2);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.btnCapNhatTick);
            this.groupControl2.Controls.Add(this.memoBarcode);
            this.groupControl2.Controls.Add(this.bthKiemTraTick);
            this.groupControl2.Location = new System.Drawing.Point(14, 12);
            this.groupControl2.LookAndFeel.SkinName = "Office 2010 Blue";
            this.groupControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(732, 256);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Thêm dấu tick GP";
            // 
            // btnCapNhatTick0
            // 
            this.btnCapNhatTick0.Location = new System.Drawing.Point(390, 15);
            this.btnCapNhatTick0.Name = "btnCapNhatTick0";
            this.btnCapNhatTick0.Size = new System.Drawing.Size(129, 37);
            this.btnCapNhatTick0.TabIndex = 60;
            this.btnCapNhatTick0.Text = "Chưa đẩy ERP";
            this.btnCapNhatTick0.Click += new System.EventHandler(this.btnCapNhatTick0_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(167, 58);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(560, 194);
            this.gridControl2.TabIndex = 6;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(340, -2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(0, 13);
            this.labelControl4.TabIndex = 8;
            // 
            // btnCapNhatTick
            // 
            this.btnCapNhatTick.Location = new System.Drawing.Point(273, 15);
            this.btnCapNhatTick.Name = "btnCapNhatTick";
            this.btnCapNhatTick.Size = new System.Drawing.Size(111, 37);
            this.btnCapNhatTick.TabIndex = 7;
            this.btnCapNhatTick.Text = "Đã đẩy ERP";
            this.btnCapNhatTick.Click += new System.EventHandler(this.btnCapNhatTick_Click);
            // 
            // memoBarcode
            // 
            this.memoBarcode.EditValue = "Nhập barcode:";
            this.memoBarcode.Location = new System.Drawing.Point(5, 16);
            this.memoBarcode.Name = "memoBarcode";
            this.memoBarcode.Size = new System.Drawing.Size(156, 236);
            this.memoBarcode.TabIndex = 59;
            // 
            // bthKiemTraTick
            // 
            this.bthKiemTraTick.Location = new System.Drawing.Point(167, 15);
            this.bthKiemTraTick.Name = "bthKiemTraTick";
            this.bthKiemTraTick.Size = new System.Drawing.Size(100, 37);
            this.bthKiemTraTick.TabIndex = 6;
            this.bthKiemTraTick.Text = "Kiểm tra";
            this.bthKiemTraTick.Click += new System.EventHandler(this.bthKiemTraTick_Click);
            // 
            // ThemTickGP
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ThemTickGP";
            this.Size = new System.Drawing.Size(756, 285);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoBarcode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatTick0;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatTick;
        private DevExpress.XtraEditors.MemoEdit memoBarcode;
        private DevExpress.XtraEditors.SimpleButton bthKiemTraTick;
    }
}


namespace SupportTools
{
    partial class KhoThanhPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoThanhPham));
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnCheck3 = new DevExpress.XtraEditors.SimpleButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlListPDO = new DevExpress.XtraGrid.GridControl();
            this.gridViewListPDO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnDeletePDO1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCheckPDO1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSyncPDO1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.gridViewDataStaging = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlDataStaging = new DevExpress.XtraGrid.GridControl();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txtSaE = new DevExpress.XtraEditors.TextEdit();
            this.txtDaySync1 = new DevExpress.XtraEditors.TextEdit();
            this.txtPDO = new DevExpress.XtraEditors.TextEdit();
            this.memoSQL = new DevExpress.XtraEditors.MemoEdit();
            this.txtPDO3 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlListPDO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListPDO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataStaging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataStaging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaySync1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPDO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoSQL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPDO3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            // 
            // btnCheck3
            // 
            this.btnCheck3.Location = new System.Drawing.Point(272, 49);
            this.btnCheck3.Name = "btnCheck3";
            this.btnCheck3.Size = new System.Drawing.Size(62, 23);
            this.btnCheck3.TabIndex = 34;
            this.btnCheck3.Text = "Kiểm tra";
            this.btnCheck3.Click += new System.EventHandler(this.btnCheck3_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tabPage1.Controls.Add(this.txtSaE);
            this.tabPage1.Controls.Add(this.txtDaySync1);
            this.tabPage1.Controls.Add(this.groupControl1);
            this.tabPage1.Controls.Add(this.txtPDO);
            this.tabPage1.Controls.Add(this.btnDeletePDO1);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.labelControl1);
            this.tabPage1.Controls.Add(this.btnCheckPDO1);
            this.tabPage1.Controls.Add(this.btnSyncPDO1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 557);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đồng bộ Barcode";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlListPDO);
            this.groupControl1.Location = new System.Drawing.Point(6, 77);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(782, 474);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Danh sách";
            // 
            // gridControlListPDO
            // 
            this.gridControlListPDO.Location = new System.Drawing.Point(5, 23);
            this.gridControlListPDO.MainView = this.gridViewListPDO;
            this.gridControlListPDO.Name = "gridControlListPDO";
            this.gridControlListPDO.Size = new System.Drawing.Size(772, 446);
            this.gridControlListPDO.TabIndex = 11;
            this.gridControlListPDO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewListPDO});
            // 
            // gridViewListPDO
            // 
            this.gridViewListPDO.GridControl = this.gridControlListPDO;
            this.gridViewListPDO.Name = "gridViewListPDO";
            this.gridViewListPDO.OptionsBehavior.Editable = false;
            this.gridViewListPDO.OptionsView.ShowGroupPanel = false;
            // 
            // btnDeletePDO1
            // 
            this.btnDeletePDO1.Location = new System.Drawing.Point(439, 49);
            this.btnDeletePDO1.Name = "btnDeletePDO1";
            this.btnDeletePDO1.Size = new System.Drawing.Size(62, 23);
            this.btnDeletePDO1.TabIndex = 42;
            this.btnDeletePDO1.Text = "Xóa";
            this.btnDeletePDO1.Click += new System.EventHandler(this.btnDeletePDO1_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(262, 16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(271, 19);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "ĐỒNG BỘ BARCODE TỪ STAGING";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 39;
            this.labelControl1.Text = "Mã phiếu:";
            // 
            // btnCheckPDO1
            // 
            this.btnCheckPDO1.Location = new System.Drawing.Point(371, 49);
            this.btnCheckPDO1.Name = "btnCheckPDO1";
            this.btnCheckPDO1.Size = new System.Drawing.Size(62, 23);
            this.btnCheckPDO1.TabIndex = 40;
            this.btnCheckPDO1.Text = "Kiểm tra";
            this.btnCheckPDO1.Click += new System.EventHandler(this.btnCheckPDO1_Click);
            // 
            // btnSyncPDO1
            // 
            this.btnSyncPDO1.Location = new System.Drawing.Point(541, 49);
            this.btnSyncPDO1.Name = "btnSyncPDO1";
            this.btnSyncPDO1.Size = new System.Drawing.Size(62, 23);
            this.btnSyncPDO1.TabIndex = 41;
            this.btnSyncPDO1.Text = "Đồng bộ";
            this.btnSyncPDO1.Click += new System.EventHandler(this.btnSyncPDO1_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(310, 15);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(163, 19);
            this.labelControl7.TabIndex = 39;
            this.labelControl7.Text = "KIỂM TRA STAGING";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(6, 54);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(47, 13);
            this.labelControl8.TabIndex = 33;
            this.labelControl8.Text = "Mã phiếu:";
            // 
            // gridViewDataStaging
            // 
            this.gridViewDataStaging.GridControl = this.gridControlDataStaging;
            this.gridViewDataStaging.Name = "gridViewDataStaging";
            this.gridViewDataStaging.OptionsBehavior.Editable = false;
            this.gridViewDataStaging.OptionsView.ShowGroupPanel = false;
            // 
            // gridControlDataStaging
            // 
            this.gridControlDataStaging.Location = new System.Drawing.Point(5, 23);
            this.gridControlDataStaging.MainView = this.gridViewDataStaging;
            this.gridControlDataStaging.Name = "gridControlDataStaging";
            this.gridControlDataStaging.Size = new System.Drawing.Size(318, 446);
            this.gridControlDataStaging.TabIndex = 22;
            this.gridControlDataStaging.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDataStaging});
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.gridControlDataStaging);
            this.groupControl6.Location = new System.Drawing.Point(6, 77);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(328, 474);
            this.groupControl6.TabIndex = 40;
            this.groupControl6.Text = "Dữ liệu Staging";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.memoSQL);
            this.groupControl4.Location = new System.Drawing.Point(340, 77);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(448, 474);
            this.groupControl4.TabIndex = 41;
            this.groupControl4.Text = "Kiểm tra SQL";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(287, 16);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(210, 19);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "CẬP NHẬT BARCODE MỚI";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tabPage2.Controls.Add(this.labelControl4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 557);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Barcode mới";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tabPage3.Controls.Add(this.groupControl4);
            this.tabPage3.Controls.Add(this.groupControl6);
            this.tabPage3.Controls.Add(this.labelControl7);
            this.tabPage3.Controls.Add(this.labelControl8);
            this.tabPage3.Controls.Add(this.btnCheck3);
            this.tabPage3.Controls.Add(this.txtPDO3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(794, 557);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kiểm tra Staging";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(95, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 583);
            this.tabControl1.TabIndex = 7;
            // 
            // txtSaE
            // 
            this.txtSaE.EditValue = "";
            this.txtSaE.Location = new System.Drawing.Point(272, 51);
            this.txtSaE.Name = "txtSaE";
            this.txtSaE.Size = new System.Drawing.Size(93, 20);
            this.txtSaE.TabIndex = 45;
            // 
            // txtDaySync1
            // 
            this.txtDaySync1.Location = new System.Drawing.Point(507, 51);
            this.txtDaySync1.Name = "txtDaySync1";
            this.txtDaySync1.Size = new System.Drawing.Size(28, 20);
            this.txtDaySync1.TabIndex = 44;
            // 
            // txtPDO
            // 
            this.txtPDO.EditValue = "";
            this.txtPDO.Location = new System.Drawing.Point(59, 51);
            this.txtPDO.Name = "txtPDO";
            this.txtPDO.Size = new System.Drawing.Size(207, 20);
            this.txtPDO.TabIndex = 43;
            // 
            // memoSQL
            // 
            this.memoSQL.EditValue = resources.GetString("memoSQL.EditValue");
            this.memoSQL.Location = new System.Drawing.Point(5, 22);
            this.memoSQL.Name = "memoSQL";
            this.memoSQL.Size = new System.Drawing.Size(438, 447);
            this.memoSQL.TabIndex = 0;
            // 
            // txtPDO3
            // 
            this.txtPDO3.EditValue = "";
            this.txtPDO3.Location = new System.Drawing.Point(59, 51);
            this.txtPDO3.Name = "txtPDO3";
            this.txtPDO3.Size = new System.Drawing.Size(207, 20);
            this.txtPDO3.TabIndex = 37;
            // 
            // XtraControl15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "XtraControl15";
            this.Size = new System.Drawing.Size(992, 607);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlListPDO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListPDO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataStaging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataStaging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSaE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaySync1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPDO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoSQL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPDO3.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btnCheck3;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraEditors.TextEdit txtSaE;
        private DevExpress.XtraEditors.TextEdit txtDaySync1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlListPDO;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewListPDO;
        private DevExpress.XtraEditors.TextEdit txtPDO;
        private DevExpress.XtraEditors.SimpleButton btnDeletePDO1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCheckPDO1;
        private DevExpress.XtraEditors.SimpleButton btnSyncPDO1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtPDO3;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDataStaging;
        private DevExpress.XtraGrid.GridControl gridControlDataStaging;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.MemoEdit memoSQL;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

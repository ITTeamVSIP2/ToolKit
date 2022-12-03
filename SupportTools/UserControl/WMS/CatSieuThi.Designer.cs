
namespace SupportTools
{
    partial class CatSieuThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatSieuThi));
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlDataStaging = new DevExpress.XtraGrid.GridControl();
            this.gridViewDataStaging = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.btnCheckCardID2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.memoSQL = new DevExpress.XtraEditors.MemoEdit();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtCardID2 = new DevExpress.XtraEditors.TextEdit();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.memoSQLDataGongPion = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlDataGongPion = new DevExpress.XtraGrid.GridControl();
            this.gridViewDataGongPion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCardID1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnCheckCardID1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataStaging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataStaging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoSQL.Properties)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardID2.Properties)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoSQLDataGongPion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataGongPion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataGongPion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardID1.Properties)).BeginInit();
            this.SuspendLayout();
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
            // gridControlDataStaging
            // 
            this.gridControlDataStaging.Location = new System.Drawing.Point(5, 23);
            this.gridControlDataStaging.MainView = this.gridViewDataStaging;
            this.gridControlDataStaging.Name = "gridControlDataStaging";
            this.gridControlDataStaging.Size = new System.Drawing.Size(772, 134);
            this.gridControlDataStaging.TabIndex = 22;
            this.gridControlDataStaging.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDataStaging});
            // 
            // gridViewDataStaging
            // 
            this.gridViewDataStaging.GridControl = this.gridControlDataStaging;
            this.gridViewDataStaging.Name = "gridViewDataStaging";
            this.gridViewDataStaging.OptionsBehavior.Editable = false;
            this.gridViewDataStaging.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.gridControlDataStaging);
            this.groupControl6.Location = new System.Drawing.Point(6, 389);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(782, 162);
            this.groupControl6.TabIndex = 40;
            this.groupControl6.Text = "Dữ liệu Staging";
            // 
            // btnCheckCardID2
            // 
            this.btnCheckCardID2.Location = new System.Drawing.Point(208, 49);
            this.btnCheckCardID2.Name = "btnCheckCardID2";
            this.btnCheckCardID2.Size = new System.Drawing.Size(62, 23);
            this.btnCheckCardID2.TabIndex = 46;
            this.btnCheckCardID2.Text = "Kiểm tra";
            this.btnCheckCardID2.Click += new System.EventHandler(this.btnCheckCardID2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 54);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 45;
            this.labelControl3.Text = "Số thẻ:";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.memoSQL);
            this.groupControl4.Location = new System.Drawing.Point(6, 77);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(782, 306);
            this.groupControl4.TabIndex = 41;
            this.groupControl4.Text = "Kiểm tra SQL";
            // 
            // memoSQL
            // 
            this.memoSQL.EditValue = resources.GetString("memoSQL.EditValue");
            this.memoSQL.Location = new System.Drawing.Point(5, 22);
            this.memoSQL.Name = "memoSQL";
            this.memoSQL.Size = new System.Drawing.Size(772, 279);
            this.memoSQL.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tabPage3.Controls.Add(this.txtCardID2);
            this.tabPage3.Controls.Add(this.labelControl3);
            this.tabPage3.Controls.Add(this.groupControl4);
            this.tabPage3.Controls.Add(this.btnCheckCardID2);
            this.tabPage3.Controls.Add(this.groupControl6);
            this.tabPage3.Controls.Add(this.labelControl7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(794, 557);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kiểm tra Staging";
            // 
            // txtCardID2
            // 
            this.txtCardID2.EditValue = "";
            this.txtCardID2.Location = new System.Drawing.Point(47, 51);
            this.txtCardID2.Name = "txtCardID2";
            this.txtCardID2.Size = new System.Drawing.Size(155, 20);
            this.txtCardID2.TabIndex = 47;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(818, 600);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(810, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kiểm tra GongPion";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtCardID1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.btnCheckCardID1);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.LookAndFeel.SkinName = "Office 2007 Blue";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(810, 578);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.memoSQLDataGongPion);
            this.groupControl2.Location = new System.Drawing.Point(15, 68);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(782, 306);
            this.groupControl2.TabIndex = 53;
            this.groupControl2.Text = "Kiểm tra SQL";
            // 
            // memoSQLDataGongPion
            // 
            this.memoSQLDataGongPion.EditValue = resources.GetString("memoSQLDataGongPion.EditValue");
            this.memoSQLDataGongPion.Location = new System.Drawing.Point(5, 22);
            this.memoSQLDataGongPion.Name = "memoSQLDataGongPion";
            this.memoSQLDataGongPion.Size = new System.Drawing.Size(772, 279);
            this.memoSQLDataGongPion.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.gridControlDataGongPion);
            this.groupControl3.Location = new System.Drawing.Point(15, 380);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(782, 162);
            this.groupControl3.TabIndex = 52;
            this.groupControl3.Text = "Dữ liệu GongPion";
            // 
            // gridControlDataGongPion
            // 
            this.gridControlDataGongPion.Location = new System.Drawing.Point(5, 23);
            this.gridControlDataGongPion.MainView = this.gridViewDataGongPion;
            this.gridControlDataGongPion.Name = "gridControlDataGongPion";
            this.gridControlDataGongPion.Size = new System.Drawing.Size(772, 134);
            this.gridControlDataGongPion.TabIndex = 22;
            this.gridControlDataGongPion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDataGongPion});
            // 
            // gridViewDataGongPion
            // 
            this.gridViewDataGongPion.GridControl = this.gridControlDataGongPion;
            this.gridViewDataGongPion.Name = "gridViewDataGongPion";
            this.gridViewDataGongPion.OptionsBehavior.Editable = false;
            this.gridViewDataGongPion.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(319, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(177, 19);
            this.labelControl1.TabIndex = 51;
            this.labelControl1.Text = "KIỂM TRA GONGPION";
            // 
            // txtCardID1
            // 
            this.txtCardID1.EditValue = "";
            this.txtCardID1.Location = new System.Drawing.Point(59, 28);
            this.txtCardID1.Name = "txtCardID1";
            this.txtCardID1.Size = new System.Drawing.Size(155, 20);
            this.txtCardID1.TabIndex = 50;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 48;
            this.labelControl2.Text = "Số thẻ:";
            // 
            // btnCheckCardID1
            // 
            this.btnCheckCardID1.Location = new System.Drawing.Point(220, 25);
            this.btnCheckCardID1.Name = "btnCheckCardID1";
            this.btnCheckCardID1.Size = new System.Drawing.Size(95, 36);
            this.btnCheckCardID1.TabIndex = 49;
            this.btnCheckCardID1.Text = "Kiểm tra";
            // 
            // CatSieuThi
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "CatSieuThi";
            this.Size = new System.Drawing.Size(826, 606);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataStaging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataStaging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoSQL.Properties)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardID2.Properties)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoSQLDataGongPion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataGongPion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataGongPion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardID1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.GridControl gridControlDataStaging;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDataStaging;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.SimpleButton btnCheckCardID2;
        private DevExpress.XtraEditors.MemoEdit memoSQL;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.TabPage tabPage3;
        private DevExpress.XtraEditors.TextEdit txtCardID2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.MemoEdit memoSQLDataGongPion;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControlDataGongPion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDataGongPion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCardID1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCheckCardID1;
    }
}

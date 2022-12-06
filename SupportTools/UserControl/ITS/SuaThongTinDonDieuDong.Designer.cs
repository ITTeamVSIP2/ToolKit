
namespace SupportTools
{
    partial class SuaThongTinDonDieuDong
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaThongTinDonDieuDong));
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.txtNameLine = new DevExpress.XtraEditors.TextEdit();
            this.btnSelectLine = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dgvLine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.dgvAddLine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.dgvInsert = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.dgvIEAbnormalTime = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtInsertLine = new DevExpress.XtraEditors.TextEdit();
            this.txtAddLine = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.txtOrderCode = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameLine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIEAbnormalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInsertLine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddLine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ITS_Server";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "SELECT LineID, LineName FROM IESewingLine WHERE LineName LIKE \'VSIP2%\'";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlF1ZXJ5Ij48RmllbGQgTmFtZ" +
    "T0iTGluZUlEIiBUeXBlPSJTdHJpbmciIC8+PEZpZWxkIE5hbWU9IkxpbmVOYW1lIiBUeXBlPSJTdHJpb" +
    "mciIC8+PC9WaWV3PjwvRGF0YVNldD4=";
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.Name = "sqlDataSource2";
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.ConnectionName = "ITS_Server";
            this.sqlDataSource3.Name = "sqlDataSource3";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = "SELECT isls.SectionID, isls.SectionName, islsd.SectionDetailID\r\nFROM dbo.IESewing" +
    "LineSection AS isls\r\nINNER JOIN dbo.IESewingLineSectionDetail AS islsd ON islsd." +
    "SectionID = isls.SectionID";
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSource3.ResultSchemaSerializable = resources.GetString("sqlDataSource3.ResultSchemaSerializable");
            // 
            // txtNameLine
            // 
            this.txtNameLine.Location = new System.Drawing.Point(14, 6);
            this.txtNameLine.Name = "txtNameLine";
            this.txtNameLine.Size = new System.Drawing.Size(193, 20);
            this.txtNameLine.TabIndex = 2;
            // 
            // btnSelectLine
            // 
            this.btnSelectLine.Location = new System.Drawing.Point(213, 6);
            this.btnSelectLine.Name = "btnSelectLine";
            this.btnSelectLine.Size = new System.Drawing.Size(137, 34);
            this.btnSelectLine.TabIndex = 3;
            this.btnSelectLine.Text = "Select Line";
            this.btnSelectLine.Click += new System.EventHandler(this.btnSelectLine_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(14, 46);
            this.gridControl1.MainView = this.dgvLine;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(613, 430);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvLine,
            this.gridView1});
            // 
            // dgvLine
            // 
            this.dgvLine.GridControl = this.gridControl1;
            this.dgvLine.Name = "dgvLine";
            this.dgvLine.OptionsBehavior.Editable = false;
            this.dgvLine.OptionsBehavior.ReadOnly = true;
            this.dgvLine.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.dgvLine.OptionsSelection.MultiSelect = true;
            this.dgvLine.Click += new System.EventHandler(this.dgvLine_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.Location = new System.Drawing.Point(642, 48);
            this.gridControl2.MainView = this.dgvAddLine;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(444, 262);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvAddLine});
            // 
            // dgvAddLine
            // 
            this.dgvAddLine.GridControl = this.gridControl2;
            this.dgvAddLine.Name = "dgvAddLine";
            this.dgvAddLine.Click += new System.EventHandler(this.btnQueryAddLine_Click);
            // 
            // gridControl3
            // 
            this.gridControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl3.Location = new System.Drawing.Point(642, 360);
            this.gridControl3.MainView = this.dgvInsert;
            this.gridControl3.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(443, 203);
            this.gridControl3.TabIndex = 1;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvInsert});
            // 
            // dgvInsert
            // 
            this.dgvInsert.GridControl = this.gridControl3;
            this.dgvInsert.Name = "dgvInsert";
            // 
            // gridControl4
            // 
            this.gridControl4.Location = new System.Drawing.Point(14, 571);
            this.gridControl4.MainView = this.dgvIEAbnormalTime;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(1072, 200);
            this.gridControl4.TabIndex = 7;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvIEAbnormalTime});
            // 
            // dgvIEAbnormalTime
            // 
            this.dgvIEAbnormalTime.GridControl = this.gridControl4;
            this.dgvIEAbnormalTime.Name = "dgvIEAbnormalTime";
            // 
            // txtInsertLine
            // 
            this.txtInsertLine.Location = new System.Drawing.Point(642, 319);
            this.txtInsertLine.Name = "txtInsertLine";
            this.txtInsertLine.Size = new System.Drawing.Size(191, 20);
            this.txtInsertLine.TabIndex = 8;
            // 
            // txtAddLine
            // 
            this.txtAddLine.Location = new System.Drawing.Point(642, 8);
            this.txtAddLine.Name = "txtAddLine";
            this.txtAddLine.Size = new System.Drawing.Size(191, 20);
            this.txtAddLine.TabIndex = 9;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(839, 8);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(133, 34);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "Query Add Line";
            this.simpleButton2.Click += new System.EventHandler(this.btnQueryAddLine_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(839, 317);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(113, 37);
            this.simpleButton3.TabIndex = 11;
            this.simpleButton3.Text = "Check Query";
            this.simpleButton3.Click += new System.EventHandler(this.btnCheckQuery_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(958, 316);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(126, 38);
            this.simpleButton4.TabIndex = 11;
            this.simpleButton4.Text = "Insert Line Detail";
            this.simpleButton4.Click += new System.EventHandler(this.btnInsertLineDetail_Click);
            // 
            // txtOrderCode
            // 
            this.txtOrderCode.Location = new System.Drawing.Point(276, 497);
            this.txtOrderCode.Name = "txtOrderCode";
            this.txtOrderCode.Size = new System.Drawing.Size(193, 20);
            this.txtOrderCode.TabIndex = 12;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(476, 496);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(137, 38);
            this.simpleButton5.TabIndex = 13;
            this.simpleButton5.Text = "Select";
            this.simpleButton5.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.simpleButton5);
            this.groupControl1.Controls.Add(this.txtOrderCode);
            this.groupControl1.Controls.Add(this.simpleButton4);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.txtAddLine);
            this.groupControl1.Controls.Add(this.txtInsertLine);
            this.groupControl1.Controls.Add(this.gridControl4);
            this.groupControl1.Controls.Add(this.gridControl3);
            this.groupControl1.Controls.Add(this.gridControl2);
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Controls.Add(this.btnSelectLine);
            this.groupControl1.Controls.Add(this.txtNameLine);
            this.groupControl1.Location = new System.Drawing.Point(4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1101, 813);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // SuaThongTinDonDieuDong
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "SuaThongTinDonDieuDong";
            this.Size = new System.Drawing.Size(1108, 820);
            ((System.ComponentModel.ISupportInitialize)(this.txtNameLine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIEAbnormalTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInsertLine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddLine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraEditors.TextEdit txtNameLine;
        private DevExpress.XtraEditors.SimpleButton btnSelectLine;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvLine;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvAddLine;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvInsert;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvIEAbnormalTime;
        private DevExpress.XtraEditors.TextEdit txtInsertLine;
        private DevExpress.XtraEditors.TextEdit txtAddLine;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.TextEdit txtOrderCode;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}

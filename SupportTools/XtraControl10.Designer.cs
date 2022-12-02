namespace SupportTools
{
    partial class XtraControl10
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
            this.memoMSNV = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonTra = new DevExpress.XtraEditors.SimpleButton();
            this.gctrlDuLieuITS = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gctrlDuLieuHR = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.comboBoxEditCongTy = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.memoMSNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctrlDuLieuITS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctrlDuLieuHR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditCongTy.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(24, 24);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(59, 13);
            this.labelControl9.TabIndex = 66;
            this.labelControl9.Text = "Nhập MSNV:";
            // 
            // memoMSNV
            // 
            this.memoMSNV.EditValue = "";
            this.memoMSNV.Location = new System.Drawing.Point(24, 43);
            this.memoMSNV.Name = "memoMSNV";
            this.memoMSNV.Size = new System.Drawing.Size(133, 248);
            this.memoMSNV.TabIndex = 65;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(294, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 68;
            this.labelControl1.Text = "Công ty:";
            // 
            // dateEditDate
            // 
            this.dateEditDate.EditValue = null;
            this.dateEditDate.Location = new System.Drawing.Point(163, 43);
            this.dateEditDate.Name = "dateEditDate";
            this.dateEditDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDate.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.dateEditDate.Size = new System.Drawing.Size(125, 20);
            this.dateEditDate.TabIndex = 69;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(163, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 70;
            this.labelControl2.Text = "Ngày:";
            // 
            // simpleButtonTra
            // 
            this.simpleButtonTra.Location = new System.Drawing.Point(400, 41);
            this.simpleButtonTra.Name = "simpleButtonTra";
            this.simpleButtonTra.Size = new System.Drawing.Size(57, 23);
            this.simpleButtonTra.TabIndex = 71;
            this.simpleButtonTra.Text = "Tra";
            this.simpleButtonTra.Click += new System.EventHandler(this.simpleButtonTra_Click);
            // 
            // gctrlDuLieuITS
            // 
            this.gctrlDuLieuITS.Location = new System.Drawing.Point(163, 102);
            this.gctrlDuLieuITS.MainView = this.gridView1;
            this.gctrlDuLieuITS.Name = "gctrlDuLieuITS";
            this.gctrlDuLieuITS.Size = new System.Drawing.Size(990, 189);
            this.gctrlDuLieuITS.TabIndex = 72;
            this.gctrlDuLieuITS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gctrlDuLieuITS;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(163, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 16);
            this.labelControl3.TabIndex = 73;
            this.labelControl3.Text = "Dữ liệu ITS";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(24, 307);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(135, 16);
            this.labelControl4.TabIndex = 74;
            this.labelControl4.Text = "Dữ liệu công nhân sự";
            // 
            // gctrlDuLieuHR
            // 
            this.gctrlDuLieuHR.Location = new System.Drawing.Point(24, 329);
            this.gctrlDuLieuHR.MainView = this.gridView2;
            this.gctrlDuLieuHR.Name = "gctrlDuLieuHR";
            this.gctrlDuLieuHR.Size = new System.Drawing.Size(1129, 355);
            this.gctrlDuLieuHR.TabIndex = 75;
            this.gctrlDuLieuHR.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gctrlDuLieuHR;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // comboBoxEditCongTy
            // 
            this.comboBoxEditCongTy.Location = new System.Drawing.Point(294, 43);
            this.comboBoxEditCongTy.Name = "comboBoxEditCongTy";
            this.comboBoxEditCongTy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditCongTy.Properties.Items.AddRange(new object[] {
            "Vsip1",
            "Vsip2"});
            this.comboBoxEditCongTy.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEditCongTy.TabIndex = 76;
            // 
            // XtraControl10
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(225)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxEditCongTy);
            this.Controls.Add(this.gctrlDuLieuHR);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gctrlDuLieuITS);
            this.Controls.Add(this.simpleButtonTra);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dateEditDate);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.memoMSNV);
            this.Name = "XtraControl10";
            this.Size = new System.Drawing.Size(1164, 700);
            ((System.ComponentModel.ISupportInitialize)(this.memoMSNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctrlDuLieuITS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctrlDuLieuHR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditCongTy.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.MemoEdit memoMSNV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateEditDate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonTra;
        private DevExpress.XtraGrid.GridControl gctrlDuLieuITS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gctrlDuLieuHR;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditCongTy;
    }
}

namespace SupportTools
{
    partial class Frm_FEPODetail
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
            this.gctrlListFEPO = new DevExpress.XtraGrid.GridControl();
            this.gridViewListFEPO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbFEPO = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gctrlListFEPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListFEPO)).BeginInit();
            this.SuspendLayout();
            // 
            // gctrlListFEPO
            // 
            this.gctrlListFEPO.Location = new System.Drawing.Point(12, 30);
            this.gctrlListFEPO.MainView = this.gridViewListFEPO;
            this.gctrlListFEPO.Name = "gctrlListFEPO";
            this.gctrlListFEPO.Size = new System.Drawing.Size(622, 269);
            this.gctrlListFEPO.TabIndex = 9;
            this.gctrlListFEPO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewListFEPO});
            // 
            // gridViewListFEPO
            // 
            this.gridViewListFEPO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn9});
            this.gridViewListFEPO.GridControl = this.gctrlListFEPO;
            this.gridViewListFEPO.Name = "gridViewListFEPO";
            this.gridViewListFEPO.OptionsSelection.MultiSelect = true;
            this.gridViewListFEPO.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewListFEPO.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "FepoCode";
            this.gridColumn4.FieldName = "FepoCode";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 60;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "ActionCode";
            this.gridColumn5.FieldName = "ActionCode";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 60;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Operator";
            this.gridColumn6.FieldName = "Operator";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "OperateDateTime";
            this.gridColumn7.FieldName = "OperateDateTime";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "LastOperation";
            this.gridColumn9.FieldName = "LastOperation";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            // 
            // lbFEPO
            // 
            this.lbFEPO.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFEPO.Location = new System.Drawing.Point(12, 11);
            this.lbFEPO.Name = "lbFEPO";
            this.lbFEPO.Size = new System.Drawing.Size(76, 13);
            this.lbFEPO.TabIndex = 8;
            this.lbFEPO.Text = "Chi tiết FEPO: ";
            // 
            // Frm_FEPODetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 330);
            this.Controls.Add(this.gctrlListFEPO);
            this.Controls.Add(this.lbFEPO);
            this.Name = "Frm_FEPODetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết FEPO";
            ((System.ComponentModel.ISupportInitialize)(this.gctrlListFEPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListFEPO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gctrlListFEPO;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewListFEPO;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.LabelControl lbFEPO;
    }
}
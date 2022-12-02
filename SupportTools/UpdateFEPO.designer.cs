namespace SupportTools
{
    partial class UpdateFEPO
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
            this.txtFEPO = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnFindFEPO = new DevExpress.XtraEditors.SimpleButton();
            this.txtOrderID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnUpdateFEPO = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtFEPO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFEPO
            // 
            this.txtFEPO.EditValue = "";
            this.txtFEPO.Enabled = false;
            this.txtFEPO.Location = new System.Drawing.Point(111, 41);
            this.txtFEPO.Name = "txtFEPO";
            this.txtFEPO.Size = new System.Drawing.Size(222, 20);
            this.txtFEPO.TabIndex = 40;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(75, 44);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(30, 13);
            this.labelControl8.TabIndex = 38;
            this.labelControl8.Text = "FEPO:";
            // 
            // btnFindFEPO
            // 
            this.btnFindFEPO.Location = new System.Drawing.Point(339, 39);
            this.btnFindFEPO.Name = "btnFindFEPO";
            this.btnFindFEPO.Size = new System.Drawing.Size(79, 23);
            this.btnFindFEPO.TabIndex = 39;
            this.btnFindFEPO.Text = "Tìm FEPO";
            this.btnFindFEPO.Click += new System.EventHandler(this.btnFindFEPO_Click);
            // 
            // txtOrderID
            // 
            this.txtOrderID.EditValue = "";
            this.txtOrderID.Enabled = false;
            this.txtOrderID.Location = new System.Drawing.Point(111, 67);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(222, 20);
            this.txtOrderID.TabIndex = 42;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(62, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "OrderID:";
            // 
            // btnUpdateFEPO
            // 
            this.btnUpdateFEPO.Location = new System.Drawing.Point(339, 65);
            this.btnUpdateFEPO.Name = "btnUpdateFEPO";
            this.btnUpdateFEPO.Size = new System.Drawing.Size(79, 23);
            this.btnUpdateFEPO.TabIndex = 43;
            this.btnUpdateFEPO.Text = "Cập nhật";
            this.btnUpdateFEPO.Click += new System.EventHandler(this.btnUpdateFEPO_Click);
            // 
            // UpdateFEPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 143);
            this.Controls.Add(this.btnUpdateFEPO);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtFEPO);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.btnFindFEPO);
            this.Name = "UpdateFEPO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateFEPO";
            ((System.ComponentModel.ISupportInitialize)(this.txtFEPO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtFEPO;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnFindFEPO;
        private DevExpress.XtraEditors.TextEdit txtOrderID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnUpdateFEPO;
    }
}
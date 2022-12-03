using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace SupportTools
{
    public partial class DongMoDonHang : UserControl
    {
        string _fepo;
        string msnv = "";
        string UserID, UserName;
        public DongMoDonHang()
        {
            InitializeComponent();
            gridView1.OptionsView.ShowGroupPanel = false;
            gridViewListFEPO.OptionsView.ShowGroupPanel = false;
        }

        private string SplitSlot(string fepo)
        {
            string[] parts = fepo.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            string lits_fepo;

            lits_fepo = "";

            foreach (string item in parts)
                lits_fepo = lits_fepo + "'" + item + "',";
            lits_fepo = lits_fepo.Substring(0, lits_fepo.Length - 4);
            return lits_fepo;
        }
        private void LoaddataGridView(string fepo)
        {
            string connString = ConfigurationManager.ConnectionStrings["ERP_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            string Sql = "SELECT o.OrderID, o.OrderType, o.FEPOCode, o.RequestCodeCancelClose AS 'IT Request'," + " "
                         + "(CASE isAllowCancelClose WHEN 1 THEN N'Activated' WHEN 0 THEN N'Not activated' END) AS 'IT'," + " "
                         + "(CASE completeState WHEN 1 THEN N'Close' WHEN 0 THEN N'Open' END) AS 'MR'," + " "
                         + "(CASE OrderState WHEN 1 THEN N'Open' WHEN 0 THEN N'Close' END) AS 'Planning', o.CloseDate" + " "
                         + "FROM.dbo.[Order] AS o" + " "
                         + "WHERE o.FEPOCode  IN(" + fepo + ") AND Status ='ORDER.NORMAL'";
            try
            {
                connection.Open();
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(Sql, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                gctrlListFEPO.DataSource = dt;
                //gctrlListFEPO.Refresh();


                //for (int i = 0; i <= gridViewListFEPO.RowCount; i++)
                //{
                //    string IT = gridViewListFEPO.GetRowCellValue(i, "IT Active").ToString();
                //    string MR = gridViewListFEPO.GetRowCellValue(i, "MR").ToString();
                //    string PL = gridViewListFEPO.GetRowCellValue(i, "Planning").ToString();
                //}
            }
            catch// (Exception ex)
            {
                gctrlListFEPO.DataSource = null;
            }
        }
        private void UpdateIT(string fepo)
        {
            string connString = ConfigurationManager.ConnectionStrings["ERP_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            string Sql = "UPDATE dbo.[Order]" + " "
                        + "SET isAllowCancelClose='1', RequestCodeCancelClose='" + txtDR.Text + "'" + " "
                        + "WHERE FEPOCode  IN(" + fepo + ")" + " ";
            try
            {
                connection.Open();
                SqlCommand commandPrefix = new SqlCommand(Sql, connection);
                commandPrefix.ExecuteNonQuery();
                connection.Close();
                XtraMessageBox.Show("Cho phép mở đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch// (Exception ex)
            {

            }
        }
        private void OpenMR(string fepo)
        {
            //update Order
            string connString = ConfigurationManager.ConnectionStrings["ERP_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            string Sql = "UPDATE dbo.[Order]" + " "
                        + "SET completeState='0'" + " "
                        + "WHERE FEPOCode  IN(" + fepo + ")" + " ";
            
            try
            {
                connection.Open();
                SqlCommand commandPrefix = new SqlCommand(Sql, connection);
                commandPrefix.ExecuteNonQuery();
                //insert ActionLog
                int count = gridViewListFEPO.RowCount;
                for (int i = 0; i <= count - 1; i++)
                {
                    string OrderID = gridViewListFEPO.GetRowCellValue(i, "OrderID").ToString();
                    string OrderType = gridViewListFEPO.GetRowCellValue(i, "OrderType").ToString();
                    DateTime now = DateTime.Now;
                    string getdate = now.ToString("yyyy-MM-dd HH:mm:ss");
                    string Sql_insert = @"INSERT dbo.ActionLog
                                (
                                    ActionLogId,
                                    ObjectType,
                                    PropertyName,
                                    ObjectId,
                                    ActionCode,
                                    Operator,
                                    OperateDateTime,
                                    ObjectCurrentStatus
                                )
                                VALUES
                                (   NEWID(),
                                    N'" + OrderType + "',N'CompleteState',N'" + OrderID + "',N'UNCOMPLETE',N'admin','" + getdate + "',N'Normal')";
                    SqlCommand commandinsert = new SqlCommand(Sql_insert, connection);
                    commandinsert.ExecuteNonQuery();
                }
                connection.Close();
                XtraMessageBox.Show("Đã mở MR.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch //(Exception ex)
            {

            }
        }
        private void CloseMR(string fepo)
        {
            //update Order
            string connString = ConfigurationManager.ConnectionStrings["ERP_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            string Sql = "UPDATE dbo.[Order]" + " "
                        + "SET completeState='1'" + " "
                        + "WHERE FEPOCode  IN(" + fepo + ")" + " ";
            try
            {
                connection.Open();
                SqlCommand commandPrefix = new SqlCommand(Sql, connection);
                commandPrefix.ExecuteNonQuery();
                //insert ActionLog
                int count = gridViewListFEPO.RowCount;
                for (int i = 0; i <= count - 1; i++)
                {
                    string OrderID = gridViewListFEPO.GetRowCellValue(i, "OrderID").ToString();
                    string OrderType = gridViewListFEPO.GetRowCellValue(i, "OrderType").ToString();
                    DateTime now = DateTime.Now;
                    string getdate = now.ToString("yyyy-MM-dd HH:mm:ss");
                    string Sql_insert = @"INSERT dbo.ActionLog
                                (
                                    ActionLogId,
                                    ObjectType,
                                    PropertyName,
                                    ObjectId,
                                    ActionCode,
                                    Operator,
                                    OperateDateTime,
                                    ObjectCurrentStatus
                                )
                                VALUES
                                (   NEWID(),
                                    N'" + OrderType + "',N'CompleteState',N'" + OrderID + "',N'COMPLETE',N'admin','" + getdate + "',N'Normal')";
                    SqlCommand commandinsert = new SqlCommand(Sql_insert, connection);
                    commandinsert.ExecuteNonQuery();
                }
                connection.Close();
                XtraMessageBox.Show("Đã đóng MR.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch// (Exception ex)
            {

            }
        }
        private void OpenPL(string fepo)
        {
            //update Order
            string connString = ConfigurationManager.ConnectionStrings["ERP_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            string Sql = "UPDATE dbo.[Order]" + " "
                        + "SET OrderState='1'" + " "
                        + "WHERE FEPOCode  IN(" + fepo + ")" + " ";
            try
            {
                connection.Open();
                SqlCommand commandPrefix = new SqlCommand(Sql, connection);
                commandPrefix.ExecuteNonQuery();
                //insert ActionLog
                int count = gridViewListFEPO.RowCount;
                for (int i = 0; i <= count - 1; i++)
                {
                    string OrderID = gridViewListFEPO.GetRowCellValue(i, "OrderID").ToString();
                    string OrderType = gridViewListFEPO.GetRowCellValue(i, "OrderType").ToString();
                    DateTime now = DateTime.Now;
                    string getdate = now.ToString("yyyy-MM-dd HH:mm:ss");
                    string Sql_insert = @"INSERT dbo.ActionLog
                                (
                                    ActionLogId,
                                    ObjectType,
                                    PropertyName,
                                    ObjectId,
                                    ActionCode,
                                    Operator,
                                    OperateDateTime,
                                    ObjectCurrentStatus
                                )
                                VALUES
                                (   NEWID(),
                                    N'" + OrderType + "',N'OrderState',N'" + OrderID + "',N'OPEN',N'admin','" + getdate + "',N'Normal')";
                    SqlCommand commandinsert = new SqlCommand(Sql_insert, connection);
                    commandinsert.ExecuteNonQuery();
                }
                connection.Close();
                XtraMessageBox.Show("Đã mở PL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch// (Exception ex)
            {

            }
        }
        private void ClosePL(string fepo)
        {
            //update Order
            string connString = ConfigurationManager.ConnectionStrings["ERP_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            string Sql = "UPDATE dbo.[Order]" + " "
                        + "SET OrderState='0'" + " "
                        + "WHERE FEPOCode  IN(" + fepo + ")" + " ";
            try
            {
                connection.Open();
                SqlCommand commandPrefix = new SqlCommand(Sql, connection);
                commandPrefix.ExecuteNonQuery();
                //insert ActionLog
                int count = gridViewListFEPO.RowCount;
                for (int i = 0; i <= count - 1; i++)
                {
                    string OrderID = gridViewListFEPO.GetRowCellValue(i, "OrderID").ToString();
                    string OrderType = gridViewListFEPO.GetRowCellValue(i, "OrderType").ToString();
                    DateTime now = DateTime.Now;
                    string getdate = now.ToString("yyyy-MM-dd HH:mm:ss");
                    string Sql_insert = @"INSERT dbo.ActionLog
                                (
                                    ActionLogId,
                                    ObjectType,
                                    PropertyName,
                                    ObjectId,
                                    ActionCode,
                                    Operator,
                                    OperateDateTime,
                                    ObjectCurrentStatus
                                )
                                VALUES
                                (   NEWID(),
                                    N'" + OrderType + "',N'OrderState',N'" + OrderID + "',N'CLOSE',N'admin','" + getdate + "',N'Normal')";
                    SqlCommand commandinsert = new SqlCommand(Sql_insert, connection);
                    commandinsert.ExecuteNonQuery();
                }
                connection.Close();
                XtraMessageBox.Show("Đã đóng PL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch// (Exception ex)
            {

            }
        }
        private void gridViewListFEPO_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (hitInfo.InRow)
            {
                _fepo = view.GetRowCellValue(hitInfo.RowHandle, "FEPOCode").ToString();
            }
            Frm_FEPODetail fepo_form = new Frm_FEPODetail();
            fepo_form.Sender(_fepo);
            fepo_form.ShowDialog();
        }

        private void sBtnTruyVan_Click(object sender, EventArgs e)
        {
            if (txtDR.Text != "")
            {
                string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
                var connection = new SqlConnection(connString);
                string Sql = "SELECT dr.OrderCode, drd.Description AS 'FEPO', ismu.UserName AS Creator, dr.CreateDate" + " "
                     + "FROM dbo.DeviceRegistration AS dr" + " "
                     + "INNER JOIN dbo.DeviceRegistrationDetail AS drd ON drd.DeviceRegistrationID = dr.ID" + " "
                     + "INNER JOIN dbo.ISMobileUser AS ismu ON dr.CreatorID=ismu.UserID" + " "
                     + "WHERE dr.OrderCode='" + txtDR.Text + "'";
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter;
                    adapter = new SqlDataAdapter(Sql, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    connection.Close();
                    gctrlDR.DataSource = dt;
                    sBtnHoanThanh.Enabled = true;

                }
                catch //(Exception ex)
                {

                }
            }
            else
            { XtraMessageBox.Show("Vui lòng nhập thông tin đơn DR.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void sBtnHoanThanh_Click(object sender, EventArgs e)
        {
            if (LKInputBox_UserCodeID("Nhập MSNV người hoàn thành", "MSNV.", ref msnv) == DialogResult.OK)
            {
                string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
                var connection = new SqlConnection(connString);
                string sqlGetUserID = @"SELECT UserID, UserName
								FROM dbo.ISMobileUser
								WHERE UserCodeID='" + msnv + "'";
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlGetUserID, connection);
                    SqlDataReader sqlReader = cmd.ExecuteReader();

                    sqlReader.Read();
                    UserID = sqlReader["UserID"].ToString();
                    UserName = sqlReader["UserName"].ToString();
                    sqlReader.Close();
                    connection.Close();
                }
                catch// (Exception ex)
                {

                }
                string Sql = "UPDATE DeviceRegistration" + " "
                            + "SET Status =5, TechnicianID='" + UserID + "', CompleteDate=GETDATE(), ProcessedBy=N'" + UserName + "(" + msnv + ")', CompleteEstimateDate=GETDATE()" + " "
                            + "WHERE OrderCode='" + txtDR.Text + "'";
                try
                {
                    connection.Open();
                    SqlCommand commandPrefix = new SqlCommand(Sql, connection);
                    commandPrefix.ExecuteNonQuery();
                    connection.Close();
                    XtraMessageBox.Show("Đơn đã được hoàn thành.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch// (Exception ex)
                {

                }
            }
        }

        private void sBtnTruyVanFEPO_Click(object sender, EventArgs e)
        {
            if (memoFEPO.Text != "")
            {
                string _FEPO;
                _FEPO = SplitSlot(memoFEPO.Text);
                LoaddataGridView(_FEPO);
                if (gridViewListFEPO.RowCount > 0)
                {
                    sBtnChoPhepFEPO.Enabled = true;
                    simplebtnMRMo.Enabled = true;
                    simplebtnMRDong.Enabled = true;
                    simplebtnPLMo.Enabled = true;
                    simplebtnPLDong.Enabled = true;
                }
            }
            else
            { XtraMessageBox.Show("Vui lòng nhập FEPO.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void sBtnChoPhepFEPO_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn cập nhật dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.No)
            {
                string _FEPO;
                _FEPO = SplitSlot(memoFEPO.Text);
                UpdateIT(_FEPO);
            }
        }

        private void simplebtnMRMo_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn mở MR?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.No)
            {
                string _FEPO;
                _FEPO = SplitSlot(memoFEPO.Text);
                OpenMR(_FEPO);
            }
        }

        private void simplebtnPLMo_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn mở PL?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.No)
            {
                string _FEPO;
                _FEPO = SplitSlot(memoFEPO.Text);
                OpenPL(_FEPO);
            }
        }

        private void simplebtnMRDong_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn đóng MR?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.No)
            {
                string _FEPO;
                _FEPO = SplitSlot(memoFEPO.Text);
                CloseMR(_FEPO);
            }
            //if (LKInputBox_w("Nhập MSNV người hoàn thành", "MSNV.", ref msnv) == DialogResult.OK)
            //{

            //}
        }

        private void simplebtnPLDong_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn đóng PL?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.No)
            {
                string _FEPO;
                _FEPO = SplitSlot(memoFEPO.Text);
                ClosePL(_FEPO);
            }
        }

        private void memoFEPO_TextChanged(object sender, EventArgs e)
        {
            sBtnChoPhepFEPO.Enabled = false;
            simplebtnMRMo.Enabled = false;
            simplebtnMRDong.Enabled = false;
            simplebtnPLMo.Enabled = false;
            simplebtnPLDong.Enabled = false;
        }

        public static DialogResult LKInputBox_UserCodeID(string title, string promptText1, ref string value1)
        {
            DevExpress.XtraEditors.XtraForm form = new XtraForm();
            LabelControl label1 = new LabelControl();
            TextEdit textBox1 = new TextEdit();
            DevExpress.XtraEditors.SimpleButton buttonOk = new DevExpress.XtraEditors.SimpleButton();
            DevExpress.XtraEditors.SimpleButton buttonCancel = new DevExpress.XtraEditors.SimpleButton();

            form.Text = title;
            label1.Text = promptText1;
            textBox1.Text = value1;
            buttonOk.Text = "OK";
            buttonCancel.Text = "Hủy";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label1.SetBounds(12, 18, 120, 13);
            textBox1.SetBounds(12, 36, 80, 20);
            buttonOk.SetBounds(120, 34, 50, 23);
            buttonCancel.SetBounds(178, 34, 50, 23);


            form.ClientSize = new Size(250, 90);
            form.Controls.AddRange(new Control[] { label1, textBox1, buttonOk, buttonCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value1 = textBox1.Text;
            return dialogResult;
        }
        public static DialogResult LKInputBox_w(string title, string promptText1, ref string value1)
        {
            DevExpress.XtraEditors.XtraForm form = new XtraForm();
            LabelControl label1 = new LabelControl();
            TextEdit textBox1 = new TextEdit();
            
            DevExpress.XtraEditors.SimpleButton buttonOk = new DevExpress.XtraEditors.SimpleButton();
            DevExpress.XtraEditors.SimpleButton buttonCancel = new DevExpress.XtraEditors.SimpleButton();

            form.Text = title;
            label1.Text = promptText1;
            textBox1.Text = value1;
            buttonOk.Text = "OK";
            buttonCancel.Text = "Hủy";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label1.SetBounds(12, 18, 120, 13);
            textBox1.SetBounds(12, 36, 80, 20);
            buttonOk.SetBounds(120, 34, 50, 23);
            buttonCancel.SetBounds(178, 34, 50, 23);


            form.ClientSize = new Size(290, 90);
            form.Controls.AddRange(new Control[] { label1, textBox1, buttonOk, buttonCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value1 = textBox1.Text;
            return dialogResult;
        }
    }
}

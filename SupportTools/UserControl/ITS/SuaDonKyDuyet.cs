using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Data.SqlClient;
using System.Configuration;
using DevExpress.XtraGrid.Columns;

namespace SupportTools
{
    public partial class SuaDonKyDuyet : DevExpress.XtraEditors.XtraUserControl
    {
        string ID, OrderCode, Status, MainID, MainDetailID, CheckUserID, CheckDate, isFinished, Comment;
        int flag, flagtemp;
        string sqlUp;
        int a2, b2, c2;
        int flg;
        DataTable table = new DataTable();
        public SuaDonKyDuyet()
        {
            InitializeComponent();
            InitializeMenuItems();
            txtMaDon.Select();
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView2.OptionsView.ShowGroupPanel = false;
            gridView3.OptionsView.ShowGroupPanel = false;
            gridView4.OptionsView.ShowGroupPanel = false;
            //gridView4.OptionsView.ShowAutoFilterRow = true;
            LoadLoaiDon();
        }
        DXMenuItem[] menuItems;
        void InitializeMenuItems()
        {
            DXMenuItem itemEdit = new DXMenuItem("Update", ItemUpdate_Click, imageCollection1.Images[0]);
            DXMenuItem itemDelete = new DXMenuItem("Delete", ItemDelete_Click, imageCollection1.Images[1]);
            menuItems = new DXMenuItem[] { itemEdit, itemDelete };
        }
        private void ItemUpdate_Click(object sender, System.EventArgs e)
        {
            if (flag == 1)
            {
                string _OrderCode;
                _OrderCode = OrderCode;
                if (LKInputBox(ID, "Nhập mã đơn mới.", "Nhập trạng thái mới.", ref _OrderCode, ref Status) == DialogResult.OK)
                {
                    SQL_Control1 query = new SQL_Control1();
                    string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
                    var connection = new SqlConnection(connString);
                    try
                    {
                        query.SQLupdate_Main(connection, ID, OrderCode, _OrderCode, Status, flagtemp);
                        gridControl1.DataSource = query.SQLquery_Main(txtMaDon.Text, connString, flagtemp).Tables["tableMain"];
                    }
                    catch// (Exception ex)
                    {
                        connection.Close();
                    }
                }
            }
            if (flag == 2)
            {
                if (LKInputBox_WFMain(MainID, "Nhập isFinished.", ref isFinished) == DialogResult.OK)
                {
                    SQL_Control1 query = new SQL_Control1();
                    string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
                    var connection = new SqlConnection(connString);
                    try
                    {
                        query.SQLupdate_WFMain(connection, isFinished, MainID);
                        gridControl2.DataSource = query.SQLquery_WFMain(txtMaDon.Text, connString).Tables["tableWFMain"];
                    }
                    catch //(Exception ex)
                    {
                        connection.Close();
                    }
                }
            }
            if (flag == 3)
            {
                if (LKInputBox_WFMainDetail(MainDetailID, "Nhập CheckUserID.", "Nhập CheckDate.", "Nhập isFinished.", "Nhập Comment.", ref CheckUserID, ref CheckDate, ref isFinished, ref Comment) == DialogResult.OK)
                {
                    SQL_Control1 query = new SQL_Control1();
                    string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
                    var connection = new SqlConnection(connString);
                    try
                    {
                        query.SQLupdate_WFMainDetail(connection, CheckUserID, CheckDate, isFinished, Comment, MainDetailID, MainID);
                        gridControl3.DataSource = query.SQLquery_WFMainDetail(txtMaDon.Text, connString).Tables["tableWFMainDetail"];
                    }
                    catch //(Exception ex)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void txtMaDon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simplebtnKiemTra_1.PerformClick();
            }
        }

        private void txtIDNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
                var connection = new SqlConnection(connString);
                string sqlGetUserID = @"SELECT UserCodeID, UserName
								FROM dbo.ISMobileUser
								WHERE UserID='" + txtIDNV.Text + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlGetUserID, connection);
                SqlDataReader sqlReader = cmd.ExecuteReader();

                sqlReader.Read();
                txtMSNV.Text = sqlReader["UserCodeID"].ToString();
                labelControlName.Text = sqlReader["UserName"].ToString();
                sqlReader.Close();
                connection.Close();
            }
        }

        private void txtMSNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
                var connection = new SqlConnection(connString);
                string sqlGetUserID = @"SELECT UserID, UserName
								FROM dbo.ISMobileUser
								WHERE UserCodeID='" + txtMSNV.Text + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlGetUserID, connection);
                SqlDataReader sqlReader = cmd.ExecuteReader();

                sqlReader.Read();
                txtIDNV.Text = sqlReader["UserID"].ToString();
                labelControlName.Text = sqlReader["UserName"].ToString();
                sqlReader.Close();
                connection.Close();
            }
        }

        private void ItemDelete_Click(object sender, System.EventArgs e)
        {
            if (flag == 1)
            {
                if (labelControlLoaiDon.Text == "Đơn công tác")
                {
                    if (XtraMessageBox.Show("Bạn có muốn xóa đơn?\n" + ID, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                    {
                        SQL_Control1 query = new SQL_Control1();
                        string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
                        var connection = new SqlConnection(connString);
                        string ISBusinessTripReplacement = @"DELETE FROM dbo.ISBusinessTripReplacement WHERE BTID = '" + ID + "'";
                        string ISBusinessTripParticipant = @"DELETE FROM dbo.ISBusinessTripParticipant WHERE BTID = '" + ID + "'";
                        string ISBusinessTripDetail = @"DELETE FROM dbo.ISBusinessTripDetail WHERE BTID = '" + ID + "'";
                        string ISBusinessTrip = @"DELETE FROM dbo.ISBusinessTrip WHERE BTID = '" + ID + "'";
                        try
                        {
                            connection.Open();
                            SqlCommand commandPrefix1 = new SqlCommand(ISBusinessTripReplacement, connection);
                            commandPrefix1.ExecuteNonQuery();

                            SqlCommand commandPrefix2 = new SqlCommand(ISBusinessTripParticipant, connection);
                            commandPrefix2.ExecuteNonQuery();

                            SqlCommand commandPrefix3 = new SqlCommand(ISBusinessTripDetail, connection);
                            commandPrefix3.ExecuteNonQuery();

                            SqlCommand commandPrefix4 = new SqlCommand(ISBusinessTrip, connection);
                            commandPrefix4.ExecuteNonQuery();

                            connection.Close();
                            gridControl1.DataSource = query.SQLquery_Main(txtMaDon.Text, connString, flagtemp).Tables["tableMain"];
                            int count = gridView1.RowCount;
                            labelControl8.Text = "( " + count.ToString() + " )";
                        }
                        catch// (Exception ex)
                        {
                            connection.Close();
                        }
                    }
                }
                if (labelControlLoaiDon.Text == "Phiếu khác từ ERP")
                {
                    if (XtraMessageBox.Show("Bạn có muốn xóa đơn?\n" + ID, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                    {
                        SQL_Control1 query = new SQL_Control1();
                        string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
                        var connection = new SqlConnection(connString);
                        string ERPDocumentDetail = @"DELETE FROM dbo.ERPDocumentDetail WHERE ERPDocumentsID = '" + ID + "'";
                        string ERPDocument = @"DELETE FROM dbo.ERPDocument WHERE ID = '" + ID + "'";
                        try
                        {
                            connection.Open();
                            SqlCommand commandPrefix1 = new SqlCommand(ERPDocumentDetail, connection);
                            commandPrefix1.ExecuteNonQuery();

                            SqlCommand commandPrefix2 = new SqlCommand(ERPDocument, connection);
                            commandPrefix2.ExecuteNonQuery();

                            connection.Close();
                            gridControl1.DataSource = query.SQLquery_Main(txtMaDon.Text, connString, flagtemp).Tables["tableMain"];
                            int count = gridView1.RowCount;
                            labelControl8.Text = "( " + count.ToString() + " )";
                        }
                        catch// (Exception ex)
                        {
                            connection.Close();
                        }
                    }
                }
                //if (radioButton6.Checked == true)
                //{
                //    if (XtraMessageBox.Show("Ban có muốn xóa đơn?\n" + ID, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                //    {
                //        Query query = new Query();
                //        string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
                //        var connection = new SqlConnection(connString);
                //        string ISBusinessTripReplacement = @"DELETE FROM dbo.IEAbnormalTime WHERE ID = '" + ID + "'";
                //        try
                //        {
                //            connection.Open();
                //            SqlCommand commandPrefix1 = new SqlCommand(ISBusinessTripReplacement, connection);
                //            commandPrefix1.ExecuteNonQuery();

                //            connection.Close();
                //            gridControl1.DataSource = query.SQLquery_Main(txtOrderCode.Text, connString, flagtemp).Tables["tableMain"];
                //            int count = gridView1.RowCount;
                //            labelControl8.Text = "( " + count.ToString() + " )";
                //        }
                //        catch (Exception ex)
                //        {
                //            connection.Close();
                //        }
                //    }
                //}
                else
                {
                    XtraMessageBox.Show("Không thể xóa dữ liệu này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (flag == 2)
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa đơn?\n" + MainID, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    SQL_Control1 query = new SQL_Control1();
                    string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
                    var connection = new SqlConnection(connString);
                    string sqlDelMainID = @"DELETE dbo.WFMain
                                                WHERE MainID = '" + MainID + "'";
                    try
                    {
                        connection.Open();
                        SqlCommand commandPrefix = new SqlCommand(sqlDelMainID, connection);
                        commandPrefix.ExecuteNonQuery();

                        connection.Close();
                        gridControl2.DataSource = query.SQLquery_WFMain(txtMaDon.Text, connString).Tables["tableWFMain"];
                    }
                    catch// (Exception ex)
                    {
                        connection.Close();
                    }
                }
            }
            if (flag == 3)
            {
                if (XtraMessageBox.Show("Ban có muốn xóa đơn?\n" + MainDetailID, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    SQL_Control1 query = new SQL_Control1();
                    string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
                    var connection = new SqlConnection(connString);
                    string sqlDelMainDetailID = @"DELETE dbo.WFMainDetail
                                                WHERE MainDetailID = '" + MainDetailID + "' AND MainID = '" + MainID + "'";
                    try
                    {
                        connection.Open();
                        SqlCommand commandPrefix = new SqlCommand(sqlDelMainDetailID, connection);
                        commandPrefix.ExecuteNonQuery();

                        connection.Close();
                        gridControl3.DataSource = query.SQLquery_WFMainDetail(txtMaDon.Text, connString).Tables["tableWFMainDetail"];
                    }
                    catch //(Exception ex)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void gridView4_Click(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (hitInfo.InRow)
            {
                labelControlLoaiDon.Text = view.GetRowCellValue(hitInfo.RowHandle, "DocumentTypeName").ToString();
            }
        }

        private void simpleButtonCapNhatERP_Click(object sender, EventArgs e)
        {
            Frm_EditERP f = new Frm_EditERP();
            f.ShowDialog();
        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            flag = 1;
            if (e.HitInfo.InRow)
            {
                GridView view = (GridView)sender;
                GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

                if (hitInfo.InRow)
                {
                    if (flagtemp == 1)
                    {
                        ID = view.GetRowCellValue(hitInfo.RowHandle, "ID").ToString();
                        OrderCode = view.GetRowCellValue(hitInfo.RowHandle, "OrderCode").ToString();
                    }
                    if (flagtemp == 2)
                    {
                        ID = view.GetRowCellValue(hitInfo.RowHandle, "ID").ToString();
                        OrderCode = view.GetRowCellValue(hitInfo.RowHandle, "OrderCode").ToString();
                    }
                    if (flagtemp == 3)
                    {
                        ID = view.GetRowCellValue(hitInfo.RowHandle, "ID").ToString();
                        OrderCode = view.GetRowCellValue(hitInfo.RowHandle, "OrderCode").ToString();
                    }
                    if (flagtemp == 4)
                    {
                        ID = view.GetRowCellValue(hitInfo.RowHandle, "ID").ToString();
                        OrderCode = view.GetRowCellValue(hitInfo.RowHandle, "Code").ToString();
                    }
                    if (flagtemp == 5)
                    {
                        ID = view.GetRowCellValue(hitInfo.RowHandle, "LAID").ToString();
                        OrderCode = view.GetRowCellValue(hitInfo.RowHandle, "LACode").ToString();
                    }
                    if (flagtemp == 6)
                    {
                        ID = view.GetRowCellValue(hitInfo.RowHandle, "ID").ToString();
                        OrderCode = view.GetRowCellValue(hitInfo.RowHandle, "OrderCode").ToString();
                    }
                    if (flagtemp == 8)
                    {
                        ID = view.GetRowCellValue(hitInfo.RowHandle, "BTID").ToString();
                        OrderCode = view.GetRowCellValue(hitInfo.RowHandle, "BTCode").ToString();
                    }
                    if (flagtemp == 9)
                    {
                        ID = view.GetRowCellValue(hitInfo.RowHandle, "ID").ToString();
                        OrderCode = view.GetRowCellValue(hitInfo.RowHandle, "OrderCode").ToString();
                    }
                    if (flagtemp == 10)
                    {
                        ID = view.GetRowCellValue(hitInfo.RowHandle, "WSID").ToString();
                        OrderCode = view.GetRowCellValue(hitInfo.RowHandle, "WSCode").ToString();
                    }
                    if (flagtemp == 11)
                    {
                        ID = view.GetRowCellValue(hitInfo.RowHandle, "ID").ToString();
                        OrderCode = view.GetRowCellValue(hitInfo.RowHandle, "OrderCode").ToString();
                    }
                    if (flagtemp == 12)
                    {
                        ID = view.GetRowCellValue(hitInfo.RowHandle, "ID").ToString();
                        OrderCode = view.GetRowCellValue(hitInfo.RowHandle, "OrderCode").ToString();
                    }
                    if (flagtemp == 13)
                    {
                        ID = view.GetRowCellValue(hitInfo.RowHandle, "BookingID").ToString();
                        OrderCode = view.GetRowCellValue(hitInfo.RowHandle, "BookingCode").ToString();
                    }
                    Status = view.GetRowCellValue(hitInfo.RowHandle, "Status").ToString();
                }
                foreach (DXMenuItem item in menuItems)
                    e.Menu.Items.Add(item);
            }
        }
        private void gridView2_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            flag = 2;
            if (e.HitInfo.InRow)
            {
                GridView view = (GridView)sender;
                GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

                if (hitInfo.InRow)
                {
                    MainID = view.GetRowCellValue(hitInfo.RowHandle, "MainID").ToString();
                    isFinished = view.GetRowCellValue(hitInfo.RowHandle, "isFinished").ToString();
                }
                foreach (DXMenuItem item in menuItems)
                    e.Menu.Items.Add(item);
            }
        }
        private void gridView3_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            flag = 3;
            if (e.HitInfo.InRow)
            {
                GridView view = (GridView)sender;
                GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

                if (hitInfo.InRow)
                {
                    MainDetailID = view.GetRowCellValue(hitInfo.RowHandle, "MainDetailID").ToString();
                    MainID = view.GetRowCellValue(hitInfo.RowHandle, "MainID").ToString();
                    CheckUserID = view.GetRowCellValue(hitInfo.RowHandle, "CheckUserID").ToString();
                    if (view.GetRowCellValue(hitInfo.RowHandle, "CheckDate").ToString() == "")
                    {
                        CheckDate = "";
                    }
                    else
                    {
                        DateTime CheckDatetemp = Convert.ToDateTime(view.GetRowCellValue(hitInfo.RowHandle, "CheckDate"));
                        CheckDate = CheckDatetemp.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    }
                    isFinished = view.GetRowCellValue(hitInfo.RowHandle, "isFinished").ToString();
                    Comment = view.GetRowCellValue(hitInfo.RowHandle, "Comment").ToString();
                }
                foreach (DXMenuItem item in menuItems)
                    e.Menu.Items.Add(item);
            }
        }
        public static DialogResult LKInputBox(string title, string promptText1, string promptText2, ref string value1, ref string value2)
        {
            DevExpress.XtraEditors.XtraForm form = new XtraForm();
            LabelControl label1 = new LabelControl();
            LabelControl label2 = new LabelControl();
            TextEdit textBox1 = new TextEdit();
            TextEdit textBox2 = new TextEdit();
            DevExpress.XtraEditors.SimpleButton buttonOk = new DevExpress.XtraEditors.SimpleButton();
            DevExpress.XtraEditors.SimpleButton buttonCancel = new DevExpress.XtraEditors.SimpleButton();

            form.Text = title;
            label1.Text = promptText1;
            label2.Text = promptText2;
            textBox1.Text = value1;
            textBox2.Text = value2;
            buttonOk.Text = "OK";
            buttonCancel.Text = "Hủy";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label1.SetBounds(12, 18, 120, 13);
            textBox1.SetBounds(12, 36, 160, 20);
            label2.SetBounds(12, 65, 150, 13);
            textBox2.SetBounds(12, 83, 80, 20);
            buttonOk.SetBounds(120, 81, 50, 23);
            buttonCancel.SetBounds(178, 81, 50, 23);

            //label.AutoSize = true;
            //textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            //buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            //buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(290, 140);
            form.Controls.AddRange(new Control[] { label1, textBox1, label2, textBox2, buttonOk, buttonCancel });
            //form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value1 = textBox1.Text;
            value2 = textBox2.Text;
            return dialogResult;
        }
        public static DialogResult LKInputBox_WFMainDetail(string title, string promptText1, string promptText2, string promptText3, string promptText4, ref string value1, ref string value2, ref string value3, ref string value4)
        {
            DevExpress.XtraEditors.XtraForm form = new XtraForm();
            LabelControl label1 = new LabelControl();
            LabelControl label2 = new LabelControl();
            LabelControl label3 = new LabelControl();
            LabelControl label4 = new LabelControl();
            TextEdit textBox1 = new TextEdit();
            TextEdit textBox2 = new TextEdit();
            TextEdit textBox3 = new TextEdit();
            TextEdit textBox4 = new TextEdit();
            DevExpress.XtraEditors.SimpleButton buttonOk = new DevExpress.XtraEditors.SimpleButton();
            DevExpress.XtraEditors.SimpleButton buttonCancel = new DevExpress.XtraEditors.SimpleButton();

            form.Text = title;
            label1.Text = promptText1;
            label2.Text = promptText2;
            label3.Text = promptText3;
            label4.Text = promptText4;
            textBox1.Text = value1;
            textBox2.Text = value2;
            textBox3.Text = value3;
            textBox4.Text = value4;
            buttonOk.Text = "OK";
            buttonCancel.Text = "Hủy";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label1.SetBounds(12, 18, 120, 13);
            textBox1.SetBounds(12, 36, 80, 20);
            label2.SetBounds(12, 65, 150, 13);
            textBox2.SetBounds(12, 83, 160, 20);
            label3.SetBounds(12, 112, 150, 13);
            textBox3.SetBounds(12, 130, 80, 20);
            label4.SetBounds(12, 159, 150, 13);
            textBox4.SetBounds(12, 177, 160, 20);
            buttonOk.SetBounds(120, 210, 50, 23);
            buttonCancel.SetBounds(178, 210, 50, 23);


            form.ClientSize = new Size(290, 260);
            form.Controls.AddRange(new Control[] { label1, textBox1, label2, textBox2, label3, textBox3, label4, textBox4, buttonOk, buttonCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value1 = textBox1.Text;
            value2 = textBox2.Text;
            value3 = textBox3.Text;
            value4 = textBox4.Text;
            return dialogResult;
        }
        public static DialogResult LKInputBox_WFMain(string title, string promptText1, ref string value1)
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
        public void DesignGV2()
        {
            gridView2.Columns["CreateDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView2.Columns["CreateDate"].DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss.fff";
            gridView2.Columns["CreateUserID"].Width = 80;
            gridView2.Columns["isFinished"].Width = 80;
            gridView2.OptionsBehavior.Editable = false;
        }
        public void DesignGV3()
        {
            //ColumnAutoWidth = False
            gridView3.Columns["CheckDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView3.Columns["CheckDate"].DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss.fff";
            gridView3.Columns["MainDetailID"].Width = 100;
            gridView3.Columns["MainID"].Width = 100;
            gridView3.Columns["Sequence"].Width = 60;
            gridView3.Columns["NodeID"].Width = 100;
            gridView3.Columns["PostUserID"].Width = 80;
            gridView3.Columns["CheckUserID"].Width = 80;
            gridView3.Columns["CheckDate"].Width = 100;
            gridView3.Columns["Sequenceday"].Width = 60;
            gridView3.Columns["isFinished"].Width = 60;
            gridView3.Columns["Status"].Width = 80;
            gridView3.Columns["Signer"].Width = 120;
            gridView3.Columns["Comment"].Width = 150;
            gridView3.Columns.RemoveAt(7);
            //gridView3.OptionsBehavior.Editable = false;
        }
        private void simplebtnKiemTra_1_Click(object sender, EventArgs e)
        {
            MessageBoxx mes = new MessageBoxx();
            if (gridView1.RowCount != 0 || gridView2.RowCount >= 0 || gridView3.RowCount >= 0)
            {
                gridControl1.DataSource = null;
                gridView1.Columns.Clear();
                gridControl2.DataSource = null;
                gridView2.Columns.Clear();
                gridControl3.DataSource = null;
                gridView3.Columns.Clear();
            }
            string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
            SQL_Control1 query = new SQL_Control1();
            if (labelControlLoaiDon.Text== "Đơn mua VTTT")
            {
                flagtemp = 1;
            }
            if (labelControlLoaiDon.Text == "Phiếu đề nghị thanh toán")
            {
                flagtemp = 2;
            }
            if (labelControlLoaiDon.Text == "Đơn trình văn")
            {
                flagtemp = 3;
            }
            if (labelControlLoaiDon.Text == "Đơn đóng mộc")
            {
                flagtemp = 4;
            }
            if (labelControlLoaiDon.Text == "Đơn nghỉ phép")
            {
                flagtemp = 5;
            }
            if (labelControlLoaiDon.Text == "Phiếu sự cố điều động")
            {
                flagtemp = 6;
            }
            if (labelControlLoaiDon.Text == "Khác")
            {
                flagtemp = 7;
            }
            if (labelControlLoaiDon.Text == "Đơn công tác")
            {
                flagtemp = 8;
            }
            if (labelControlLoaiDon.Text == "Phiếu khác từ ERP")
            {
                flagtemp = 9;
            }
            if (labelControlLoaiDon.Text == "Phiếu báo giá")
            {
                flagtemp = 10;
            }
            if (labelControlLoaiDon.Text == "Phiếu thanh toán từ ERP")
            {
                flagtemp = 11;
            }
            if (labelControlLoaiDon.Text == "Đơn mua văn phòng phẩm")
            {
                flagtemp = 12;
            }
            if (labelControlLoaiDon.Text == "Đơn đặt xe")
            {
                flagtemp = 13;
            }

            try
            {
                if (flagtemp != 7)
                {
                    gridControl1.DataSource = query.SQLquery_Main(txtMaDon.Text, connString, flagtemp).Tables["tableMain"];
                    gridView1.Columns["CreateDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    gridView1.Columns["CreateDate"].DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss.fff";


                    string[] arrListStr = txtMaDon.Text.Split('/');
                    string _a = arrListStr[0];
                    if (flagtemp == 1)
                    {
                        sqlUp = @"SELECT TOP 1 OrderCode AS 'CodeA'
                            FROM dbo.PAOrder
                            WHERE OrderCode LIKE'" + _a + "%' ORDER BY OrderCode DESC";
                    }
                    if (flagtemp == 2)
                    {
                        sqlUp = @"SELECT TOP 1 OrderCode AS 'CodeA'
                            FROM dbo.PRPaymentRequest
                            WHERE OrderCode LIKE'" + _a + "%' ORDER BY OrderCode DESC";
                    }
                    if (flagtemp == 3)
                    {
                        sqlUp = @"SELECT TOP 1 OrderCode AS 'CodeA'
                            FROM dbo.PDApplicationRequest
                            WHERE OrderCode LIKE'" + _a + "%' ORDER BY OrderCode DESC";
                    }
                    if (flagtemp == 4)
                    {
                        sqlUp = @"SELECT TOP 1 Code AS 'CodeA'
                            FROM dbo.PDCarpentry
                            WHERE Code LIKE'" + _a + "%' ORDER BY Code DESC";
                    }
                    if (flagtemp == 5)
                    {
                        sqlUp = @"SELECT TOP 1 LACode AS 'CodeA'
                            FROM dbo.ISLeaveAbsence
                            WHERE LACode LIKE'" + _a + "%' ORDER BY LACode DESC";
                    }
                    if (flagtemp == 6)
                    {
                        sqlUp = @"SELECT TOP 1 OrderCode AS 'CodeA'
                            FROM dbo.IEAbnormalTime
                            WHERE OrderCode LIKE'" + _a + "%' ORDER BY OrderCode DESC";
                    }
                    if (flagtemp == 8)
                    {
                        sqlUp = @"SELECT TOP 1 ibt.BTCode AS 'CodeA'
                        FROM dbo.ISBusinessTrip AS ibt
                        WHERE ibt.BTCode LIKE'" + _a + "%' ORDER BY ibt.BTCode DESC";
                    }
                    if (flagtemp == 9)
                    {
                        sqlUp = @"SELECT TOP 1 OrderCode AS 'CodeA'
                        FROM dbo.ERPDocument
                        WHERE OrderCode LIKE'" + _a + "%' ORDER BY OrderCode DESC";
                    }
                    if (flagtemp == 10)
                    {
                        sqlUp = @"SELECT TOP 1 WSCode AS 'CodeA'
                        FROM dbo.PAWorkspace
                        WHERE WSCode LIKE'" + _a + "%' ORDER BY WSCode DESC";
                    }
                    if (flagtemp == 11)
                    {
                        sqlUp = @"SELECT TOP 1 OrderCode AS 'CodeA'
                        FROM dbo.ERPPurchaseInvoice
                        WHERE OrderCode LIKE'" + _a + "%' ORDER BY OrderCode DESC";
                    }
                    if (flagtemp == 12)
                    {
                        sqlUp = @"SELECT TOP 1 OrderCode AS 'CodeA'
                        FROM dbo.GAItem
                        WHERE OrderCode LIKE'" + _a + "%' ORDER BY OrderCode DESC";
                    }
                    if (flagtemp == 13)
                    {
                        sqlUp = @"SELECT TOP 1 BookingCode AS 'CodeA'
                        FROM dbo.ISCarBooking
                        WHERE BookingCode LIKE'" + _a + "%' ORDER BY BookingCode DESC";
                    }
                    var connection = new SqlConnection(connString);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlUp, connection);
                    SqlDataReader sqlReadersqlUp = cmd.ExecuteReader();
                    sqlReadersqlUp.Read();
                    string _b = sqlReadersqlUp["CodeA"].ToString();
                    sqlReadersqlUp.Close();
                    labelControl7.Text = "(Hiện tại: " + _b + ")";
                }
                gridControl2.DataSource = query.SQLquery_WFMain(txtMaDon.Text, connString).Tables["tableWFMain"];
                gridControl3.DataSource = query.SQLquery_WFMainDetail(txtMaDon.Text, connString).Tables["tableWFMainDetail"];

                DesignGV2();
                DesignGV3();

                // Make the grid read-only.
                gridView1.OptionsBehavior.Editable = false;
                // Prevent the focused cell from being highlighted.
                //gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;

                if (gridView1.RowCount == 0)
                {
                    if (flagtemp != 7)
                    {
                        gridControl1.DataSource = null;
                        gridView1.Columns.Clear();
                        gridControl2.DataSource = null;
                        gridView2.Columns.Clear();
                        gridControl3.DataSource = null;
                        gridView3.Columns.Clear();
                        XtraMessageBox.Show("Thông tin bạn nhập không đúng, hoặc không đúng loại đơn.", mes.thongbao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch// (Exception ex)
            {
                gridControl1.DataSource = null;
                gridView1.Columns.Clear();
                gridControl2.DataSource = null;
                gridView2.Columns.Clear();
                gridControl3.DataSource = null;
                gridView3.Columns.Clear();
                XtraMessageBox.Show("Thông tin bạn nhập không đúng, hoặc không đúng loại đơn.", mes.thongbao, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int count = gridView1.RowCount;
            if (labelControlLoaiDon.Text == "Đơn công tác" && count > 1)
            {
                simplebtnKiemTraChiTiet_1.Enabled = true;
            }
            else
            {
                simplebtnKiemTraChiTiet_1.Enabled = false;
            }
            if ((labelControlLoaiDon.Text == "Phiếu thanh toán từ ERP" && count > 0) || (labelControlLoaiDon.Text == "Phiếu khác từ ERP" && count > 0)) 
            {
                simpleButtonCapNhatERP.Enabled = true;
            }
            else
            {
                simpleButtonCapNhatERP.Enabled = false;
            }
            labelControl8.Text = "( " + count.ToString() + " )";
        }
        private void simplebtnKiemTraChiTiet_1_Click(object sender, EventArgs e)
        {
            flg = 0;
            int count = gridView1.RowCount;
            string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            connection.Open();
            for (int qi = 0; qi <= count - 1; qi++)
            {
                string row1 = gridView1.GetRowCellValue(qi, gridView1.Columns["BTID"]).ToString();
                string count_ISBusinessTripReplacement = @"SELECT COUNT(ReplacementID) AS 'tep1' FROM dbo.ISBusinessTripReplacement WHERE BTID = '" + row1 + "'";
                string count_ISBusinessTripParticipant = @"SELECT COUNT(ParticipantID) AS 'tep2' FROM dbo.ISBusinessTripParticipant WHERE BTID = '" + row1 + "'";
                string count_ISBusinessTripDetail = @"SELECT COUNT(BTDetailID) AS 'tep3' FROM dbo.ISBusinessTripDetail WHERE BTID = '" + row1 + "'";
                SqlCommand cmd1 = new SqlCommand(count_ISBusinessTripReplacement, connection);
                SqlCommand cmd2 = new SqlCommand(count_ISBusinessTripParticipant, connection);
                SqlCommand cmd3 = new SqlCommand(count_ISBusinessTripDetail, connection);
                SqlDataReader sqlReader1 = cmd1.ExecuteReader();
                sqlReader1.Read();
                //string sqi = qi.ToString();
                int a1 = int.Parse(sqlReader1["tep1"].ToString());
                sqlReader1.Close();
                SqlDataReader sqlReader2 = cmd2.ExecuteReader();
                sqlReader2.Read();
                int b1 = int.Parse(sqlReader2["tep2"].ToString());
                sqlReader2.Close();
                SqlDataReader sqlReader3 = cmd3.ExecuteReader();
                sqlReader3.Read();
                int c1 = int.Parse(sqlReader3["tep3"].ToString());
                sqlReader3.Close();
                if (qi != 0)
                {
                    if (a1 > a2 || b1 > b2 || c1 > c2)
                    {
                        string row1_1 = gridView1.GetRowCellValue(qi - 1, gridView1.Columns["BTID"]).ToString();
                        if (XtraMessageBox.Show("Có 1 số chi tiết khác nhau.\n" + "Bạn cần xóa: " + row1_1, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                        {
                            flg = 100;
                            SQL_Control1 query = new SQL_Control1();

                            string ISBusinessTripReplacement = @"DELETE FROM dbo.ISBusinessTripReplacement WHERE BTID = '" + row1_1 + "'";
                            string ISBusinessTripParticipant = @"DELETE FROM dbo.ISBusinessTripParticipant WHERE BTID = '" + row1_1 + "'";
                            string ISBusinessTripDetail = @"DELETE FROM dbo.ISBusinessTripDetail WHERE BTID = '" + row1_1 + "'";
                            string ISBusinessTrip = @"DELETE FROM dbo.ISBusinessTrip WHERE BTID = '" + row1_1 + "'";
                            try
                            {
                                //connection.Open();
                                SqlCommand commandPrefix1 = new SqlCommand(ISBusinessTripReplacement, connection);
                                commandPrefix1.ExecuteNonQuery();

                                SqlCommand commandPrefix2 = new SqlCommand(ISBusinessTripParticipant, connection);
                                commandPrefix2.ExecuteNonQuery();

                                SqlCommand commandPrefix3 = new SqlCommand(ISBusinessTripDetail, connection);
                                commandPrefix3.ExecuteNonQuery();

                                SqlCommand commandPrefix4 = new SqlCommand(ISBusinessTrip, connection);
                                commandPrefix4.ExecuteNonQuery();

                                //connection.Close();
                                gridControl1.DataSource = query.SQLquery_Main(txtMaDon.Text, connString, flagtemp).Tables["tableMain"];
                                int count_2 = gridView1.RowCount;
                                labelControl8.Text = "( " + count_2.ToString() + " )";
                                break;
                            }
                            catch
                            {

                            }
                        }
                    }
                    if (a1 < a2 || b1 < b2 || c1 < c2)
                    {
                        if (XtraMessageBox.Show("Các chi tiết khác nhau.\n" + "Bạn phải xóa: " + row1, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                        {
                            flg = 100;
                            SQL_Control1 query = new SQL_Control1();

                            string ISBusinessTripReplacement = @"DELETE FROM dbo.ISBusinessTripReplacement WHERE BTID = '" + row1 + "'";
                            string ISBusinessTripParticipant = @"DELETE FROM dbo.ISBusinessTripParticipant WHERE BTID = '" + row1 + "'";
                            string ISBusinessTripDetail = @"DELETE FROM dbo.ISBusinessTripDetail WHERE BTID = '" + row1 + "'";
                            string ISBusinessTrip = @"DELETE FROM dbo.ISBusinessTrip WHERE BTID = '" + row1 + "'";
                            try
                            {
                                //connection.Open();
                                SqlCommand commandPrefix1 = new SqlCommand(ISBusinessTripReplacement, connection);
                                commandPrefix1.ExecuteNonQuery();

                                SqlCommand commandPrefix2 = new SqlCommand(ISBusinessTripParticipant, connection);
                                commandPrefix2.ExecuteNonQuery();

                                SqlCommand commandPrefix3 = new SqlCommand(ISBusinessTripDetail, connection);
                                commandPrefix3.ExecuteNonQuery();

                                SqlCommand commandPrefix4 = new SqlCommand(ISBusinessTrip, connection);
                                commandPrefix4.ExecuteNonQuery();

                                //connection.Close();
                                gridControl1.DataSource = query.SQLquery_Main(txtMaDon.Text, connString, flagtemp).Tables["tableMain"];
                                int count_2 = gridView1.RowCount;
                                labelControl8.Text = "( " + count_2.ToString() + " )";
                                break;
                            }
                            catch
                            {

                            }
                        }
                    }

                }

                a2 = a1;
                b2 = b1;
                c2 = c1;
            }
            connection.Close();
            if (flg != 100)
            {
                XtraMessageBox.Show("Tất cả chi tiết đều giống nhau.\n" + "Bạn có thể bất cứ dòng nào.", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (flg == 100)
            {
                simplebtnKiemTraChiTiet_1.PerformClick();
            }
        }
        public void LoadLoaiDon()
        {
            table.Columns.Add("DocumentTypeName");
            table.Rows.Add("Đơn mua VTTT");
            table.Rows.Add("Phiếu đề nghị thanh toán");
            table.Rows.Add("Đơn trình văn");
            table.Rows.Add("Đơn đóng mộc");
            table.Rows.Add("Đơn nghỉ phép");
            table.Rows.Add("Phiếu sự cố điều động");
            table.Rows.Add("Đơn công tác");
            table.Rows.Add("Phiếu thanh toán từ ERP");
            table.Rows.Add("Phiếu báo giá");
            table.Rows.Add("Phiếu khác từ ERP");
            table.Rows.Add("Đơn mua văn phòng phẩm");
            table.Rows.Add("Đơn đặt xe");
            table.Rows.Add("Khác");
            gridControl4.DataSource = table;
        }
    }
}

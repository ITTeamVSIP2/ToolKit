using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace SupportTools
{
    public partial class Frm_EditERP : DevExpress.XtraEditors.XtraForm
    {
        string Sql_Update;
        string TableName;
        public Frm_EditERP()
        {
            InitializeComponent();
            gridView4.OptionsView.ShowGroupPanel = false;
            txtTrangThai.ReadOnly = true;
        }

        private void simplebtnCapNhat_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["ERP_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            if (cmbLoaiDon.Text == "Phiếu thanh toán từ ERP")
            {
                TableName = "dbo.CommonPurchaseInvoice";
            }
            if (cmbLoaiDon.Text == "Phiếu yêu cầu vải (SX)")
            {
                TableName = "dbo.MaterialRequestOrder";
            }
            if (cmbLoaiDon.Text == "Đơn xin gia công")
            {
                TableName = "dbo.OutwardRequestOrder";
            }
            if (cmbLoaiDon.Text == "Phiếu đề nghị tiêu hủy")
            {
                TableName = "dbo.SuggestRuinOut";
            }
            if (cmbLoaiDon.Text == "Phiếu khác từ ERP")
            {
                TableName = "dbo.MaterialStockOutOrder";
            }
            Sql_Update = @"UPDATE " + TableName
                        + " SET Status='" + txtTrangThai.Text + "'"
                        + " WHERE OrderCode ='" + txtMaDon.Text + "'";
            try
            {
                connection.Open();
                SqlCommand commandPrefix = new SqlCommand(Sql_Update, connection);
                commandPrefix.ExecuteNonQuery();
                connection.Close();
                XtraMessageBox.Show("Cập nhật trạng thái thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch// (Exception ex)
            {

            }
        }
        private void simplebtnKiemTra_Click(object sender, EventArgs e)
        {
            string[] arrListStr = txtMaDon.Text.Split('-');
            string _a = arrListStr[0];

            if (txtMaDon.Text != "")
            {
                if (cmbLoaiDon.Text == "Phiếu thanh toán từ ERP")
                {
                    TableName = "dbo.CommonPurchaseInvoice";
                }
                if (cmbLoaiDon.Text == "Phiếu yêu cầu vải (SX)")
                {
                    TableName = "dbo.MaterialRequestOrder";
                }
                if (cmbLoaiDon.Text == "Đơn xin gia công")
                {
                    TableName = "dbo.OutwardRequestOrder";
                }
                if (cmbLoaiDon.Text == "Phiếu đề nghị tiêu hủy")
                {
                    TableName = "dbo.SuggestRuinOut";
                }
                if (cmbLoaiDon.Text == "Phiếu khác từ ERP")
                {
                    TableName = "dbo.MaterialStockOutOrder";
                }
                string connString = ConfigurationManager.ConnectionStrings["ERP_Server"].ConnectionString;
                var connection = new SqlConnection(connString);
                string SqlGetStatus = @"SELECT Status
                                FROM " + TableName
                                + " WHERE OrderCode='" + txtMaDon.Text + "'";
                string SqlGetAllStatus = @"SELECT DISTINCT Status
                                FROM " + TableName
                                + " WHERE OrderCode LIKE '" + _a + "%'";
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(SqlGetStatus, connection);
                    SqlDataReader sqlReader = cmd.ExecuteReader();
                    sqlReader.Read();
                    txtTrangThai.Text = sqlReader["Status"].ToString();
                    sqlReader.Close();

                    SqlDataAdapter adapter;
                    adapter = new SqlDataAdapter(SqlGetAllStatus, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    connection.Close();
                    gridControl4.DataSource = dt;

                }
                catch //(Exception ex)
                {
                    XtraMessageBox.Show("Thông tin đơn sai hoặc sai loại đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            { XtraMessageBox.Show("Vui lòng nhập thông tin đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void gridView4_Click(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (hitInfo.InRow)
            {
                txtTrangThai.Text = view.GetRowCellValue(hitInfo.RowHandle, "Status").ToString();
            }
        }
    }
}
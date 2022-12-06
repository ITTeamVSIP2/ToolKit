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
using System.Configuration;
using System.Data.SqlClient;

namespace SupportTools
{
    
    public partial class KhoThanhPham : DevExpress.XtraEditors.XtraUserControl
    {
        string sqlPDO;
        string sqlStaging;
        public KhoThanhPham()
        {
            InitializeComponent();
        }
        private void btnCheckPDO1_Click(object sender, EventArgs e)
        {

            string connString = ConfigurationManager.ConnectionStrings["WMS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            if (txtSaE.Text == "")
            {
                sqlPDO = "SELECT OrderCode, CustomerName, StartNo, EndNo, CartonBarCodePrefix, BarcodeStart, BarcodeEnd FROM ProductPackageDetailItem WHERE OrderCode = 'PDO-" + txtPDO.Text + "'";
            }
            else
            {
                sqlPDO = "SELECT OrderCode, CustomerName, StartNo, EndNo, CartonBarCodePrefix, BarcodeStart, BarcodeEnd FROM ProductPackageDetailItem WHERE OrderCode = 'PDO-" + txtPDO.Text + "' AND '" + txtSaE.Text + "' BETWEEN StartNo  AND EndNo";
            }
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlPDO, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                gridControlListPDO.DataSource = dt;


            }
            catch (Exception ex)
            {
                txtPDO.Text = ex.Message;
            }
        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["WMS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            sqlStaging = memoSQL.Text + "'PDO-" + txtPDO3.Text + "'";
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStaging, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                gridControlDataStaging.DataSource = dt;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletePDO1_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["WMS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE ProductPackageDetailItem WHERE OrderCode = 'PDO-" + txtPDO.Text + "'", connection);
                command.ExecuteNonQuery();
                XtraMessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                txtPDO.Text = ex.Message;
            }
        }

        private void btnSyncPDO1_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(txtDaySync1.Text);
            if (day > 30)
            { XtraMessageBox.Show("Không thể đồng bộ lớn hơn 30 ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                string connString = ConfigurationManager.ConnectionStrings["WMS_Server"].ConnectionString;
                var connection = new SqlConnection(connString);
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("sp_SyncStockInProduct", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@pDifferenceDays", -day);
                    command.CommandTimeout = 0;
                    command.ExecuteNonQuery();
                    XtraMessageBox.Show("Đồng bộ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    txtPDO.Text = ex.Message;
                }
            }
        }
    }
}

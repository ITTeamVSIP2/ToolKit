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

namespace SupportTools
{
    public partial class UpdateFEPO : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SendMessager(string Messager);
        public SendMessager Sender;
        public UpdateFEPO()
        {
            InitializeComponent();
            Sender = new SendMessager(GetMessager);
        }
        private void GetMessager(string Messager)
        {
            txtOrderID.Text = Messager;
        }

        private void btnFindFEPO_Click(object sender, EventArgs e)
        {
            string connStringERP = ConfigurationManager.ConnectionStrings["ERP_Server"].ConnectionString;
            var connectionERP = new SqlConnection(connStringERP);
            string SqlERP_count = @"SELECT COUNT(FEPOCode) AS 'COUNT'
                            FROM dbo.[Order]
                            WHERE OrderID = '" + txtOrderID.Text + "'";
            string SqlERP = @"SELECT FEPOCode
                            FROM dbo.[Order]
                            WHERE OrderID = '" + txtOrderID.Text + "'";
            connectionERP.Open();
            SqlCommand cmd = new SqlCommand(SqlERP_count, connectionERP);
            SqlDataReader sqlReader = cmd.ExecuteReader();

            sqlReader.Read();
            string count = sqlReader["COUNT"].ToString();
            sqlReader.Close();
            int _count = int.Parse(count);
            if (_count == 1)
            {
                SqlCommand _cmd = new SqlCommand(SqlERP, connectionERP);
                SqlDataReader _sqlReader = _cmd.ExecuteReader();
                _sqlReader.Read();
                txtFEPO.Text = _sqlReader["FEPOCode"].ToString();
                _sqlReader.Close();
            }
            else
            {
                XtraMessageBox.Show("Lỗi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connectionERP.Close();
        }

        private void btnUpdateFEPO_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["WMS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            connection.Open();

            string SqlUpdate = @"UPDATE AccessoryInputOrderDtl
                    SET FEPOCode='"+ txtFEPO.Text + "' WHERE OrderID='" + txtOrderID.Text + "'";
            try
            {
                SqlCommand commandPrefix = new SqlCommand(SqlUpdate, connection);
                commandPrefix.ExecuteNonQuery();
                connection.Close();
                XtraMessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                txtFEPO.Text = ex.Message;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace SupportTools
{
    public partial class DangXuatITS : UserControl
    {
        public DangXuatITS()
        {
            InitializeComponent();
            txtMSNV.Select();
        }

        private void simplebtnDangxuat_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            string sqlID = @"UPDATE dbo.ISLoginDevices                                    SET sAccept = 0,                                    Status = 0                                    WHERE UserCode IN ('" + txtMSNV.Text + "') AND sAccept = 1 AND Status = 1";
            try
            {
                connection.Open();
                SqlCommand commandPrefix = new SqlCommand(sqlID, connection);
                commandPrefix.ExecuteNonQuery();
                connection.Close();
                XtraMessageBox.Show("Thành công nhé ^_^", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch// (Exception ex)
            {
                connection.Close();
            }
        }
    }
}

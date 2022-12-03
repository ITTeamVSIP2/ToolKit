using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SupportTools
{
    public partial class LayMatKhauMoi : UserControl
    {
        public LayMatKhauMoi()
        {
            InitializeComponent();
        }

        private void simplebtnLayMatKhau_Click(object sender, EventArgs e)
        {
            if (radiobtnITS.Checked == true)
            {
                string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
                var connection = new SqlConnection(connString);
                string sql_ITS = "UPDATE dbo.[User] SET UserPass='b3de3e6c7809dd37bb24233fd2ad60c4', UserExpired=DATEADD(month, 1, GETDATE()) WHERE UserCodeID= '" + txtMSNV.Text + "' AND Enabled=1";
                string sql_ITSuper = "UPDATE ITSuper.dbo.[User] SET Password='b3de3e6c7809dd37bb24233fd2ad60c4' WHERE UserCode= '" + txtMSNV.Text + "' AND Enabled=1";
                string sql_Select = "SELECT UserName FROM dbo.[User] WHERE UserCodeID= '" + txtMSNV.Text + "' AND Enabled=1";
                try
                {
                    connection.Open();
                    // update dbo.[User]
                    SqlCommand commandsql_ITS = new SqlCommand(sql_ITS, connection);
                    commandsql_ITS.ExecuteNonQuery();
                    // update ITSuper.dbo.[User]
                    SqlCommand commandsql_ITSuper = new SqlCommand(sql_ITSuper, connection);
                    commandsql_ITSuper.ExecuteNonQuery();
                    // hiện tên user
                    SqlCommand command = new SqlCommand(sql_Select, connection);
                    string name = command.ExecuteScalar().ToString();
                    connection.Close();
                    txtMK.Visible = true;
                    txtMK.Text = "%its123";
                    lbMes.Text = "Bạn vừa lấy mật khẩu " + radiobtnITS.Text + " của nhân viên " + name + "." + "\nMật khẩu mới là:";
                }
                catch// (Exception ex)
                {
                    lbMes.Text = "Không tìm thấy user này.";
                }
            }

            else if (radiobtnERP.Checked == true)
            {
                string connString = ConfigurationManager.ConnectionStrings["ERP_Server"].ConnectionString;
                var connection = new SqlConnection(connString);
                string sql_ERP = "UPDATE dbo.[SystemUser] SET Password='alHFcYu2sLKtZ+yhOfajSw==', ChangePwdDate=GETDATE() WHERE UserCode= '" + txtMSNV.Text + "' AND InActive=1";
                string sql_Select = "SELECT UserName FROM dbo.[SystemUser] WHERE UserCode= '" + txtMSNV.Text + "'";
                try
                {
                    connection.Open();
                    // update dbo.[SystemUser]
                    SqlCommand commandsql_ERP = new SqlCommand(sql_ERP, connection);
                    commandsql_ERP.ExecuteNonQuery();
                    // hiện tên user
                    SqlCommand command = new SqlCommand(sql_Select, connection);
                    string name = command.ExecuteScalar().ToString();
                    connection.Close();
                    txtMK.Visible = true;
                    txtMK.Text = "feaerp9999";
                    lbMes.Text = "Bạn vừa lấy mật khẩu " + radiobtnERP.Text + " của nhân viên " + name + "." + "\nMật khẩu mới là:";
                }
                catch //(Exception ex)
                {
                    lbMes.Text = "Không tìm thấy user này.";
                }
            }
            else if (radiobtnWTS.Checked == true)
            {
                string connString = ConfigurationManager.ConnectionStrings["WTS_Server"].ConnectionString;
                var connection = new SqlConnection(connString);
                DateTime now = DateTime.Now;
                string getdate = now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string sql_WTS = "UPDATE dbo.[smUser] SET sPassword='2F230065C7B8B9', sPasswordMD5='9127e438ae23511f74098fdcdbc6764e', tChangePasswordTime='" + getdate + "' WHERE sUserID= '" + txtMSNV.Text + "'";
                string sql_Select = "SELECT sUserName FROM dbo.[smUser] WHERE sUserID= '" + txtMSNV.Text + "'";
                try
                {
                    connection.Open();
                    // update dbo.[smUser]
                    SqlCommand commandsql_WTS = new SqlCommand(sql_WTS, connection);
                    commandsql_WTS.ExecuteNonQuery();
                    //// hiện tên user
                    SqlCommand command = new SqlCommand(sql_Select, connection);
                    string name = command.ExecuteScalar().ToString();
                    connection.Close();
                    txtMK.Visible = true;
                    txtMK.Text = "111222";
                    lbMes.Text = "Bạn vừa lấy mật khẩu " + radiobtnWTS.Text + " của nhân viên " + name + "." + "\nMật khẩu mới là:";
                }
                catch //(Exception ex)
                {
                    lbMes.Text = "Không tìm thấy user này.";
                }
            }
            else if (radiobtnAGP.Checked == true)
            {
                string connString = ConfigurationManager.ConnectionStrings["AGP_Server"].ConnectionString;
                var connection = new SqlConnection(connString);
                string sql_AGP = "UPDATE dbo.[SYS_Users] SET Password='mtiZndu2nZG5' WHERE UserID= '" + txtMSNV.Text + "'";
                string sql_Select = "SELECT UserName FROM dbo.[SYS_Users] WHERE UserID= '" + txtMSNV.Text + "'";
                try
                {
                    connection.Open();
                    // update dbo.[SYS_Users]
                    SqlCommand commandsql_AGP = new SqlCommand(sql_AGP, connection);
                    commandsql_AGP.ExecuteNonQuery();
                    // hiện tên user
                    SqlCommand command = new SqlCommand(sql_Select, connection);
                    string name = command.ExecuteScalar().ToString();
                    connection.Close();
                    txtMK.Visible = true;
                    txtMK.Text = "123456789";
                    lbMes.Text = "Bạn vừa lấy mật khẩu " + radiobtnAGP.Text + " của nhân viên " + name + "." + "\nMật khẩu mới là:";
                }
                catch //(Exception ex)
                {
                    lbMes.Text = "Không tìm thấy user này.";
                }
            }
            else
            {
                lbMes.Text = "Vui lòng chọn hệ thống cần lấy mật khẩu.";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SupportTools
{
    public partial class TaoTaiKhoanAGP : DevExpress.XtraEditors.XtraUserControl
    {
        public TaoTaiKhoanAGP()
        {
            InitializeComponent();
        }

        private void simplebtnKiemTra_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["AGP_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            string sqlInsertUser = string.Format( @"SELECT UserID, UserName, Password, Email, UserGroupID, UserGroupName FROM dbo.SYS_Users WHERE UserID = '{0}'", txtNewUserID.Text);
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlInsertUser, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                gridControlList.DataSource = dt;
                if (gridViewList.RowCount == 0)
                { simplebtnThem.Enabled = true; }    
                else { simplebtnThem.Enabled = false; }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simplebtnThem_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["AGP_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            string sqlInsertUser = string.Format(@"INSERT INTO dbo.SYS_Users
	                                SELECT '{0}' AS UserID,'{1}' AS UserName,UserID_HR,Def_Lang,N'mtiZndu2nZG5',CompanyCode,DeptID,DeptName,Phone,'{2}' AS Email,UserGroupID,UserGroupName,
	                                CONVERT(VARCHAR(19),GETDATE(),120) AS Temp1,Temp2,CONVERT(VARCHAR(19),GETDATE(),120) AS Temp3,Temp4,Temp5,Temp6,Temp7,Temp8,Temp9,TempA,TempB,TempC,TempD,Sex,Birthday,IDCardNo,Extension 
	                                FROM dbo.SYS_Users WHERE UserID='{3}'
	                                INSERT INTO SYS_UserGroup_Users
	                                SELECT 'ST'+CONVERT(VARCHAR(10), GETDATE(), 12) + RIGHT('0000' +CONVERT(VARCHAR(4),ISNULL((SELECT MAX(CONVERT(INT,SUBSTRING(ID,9,4))) FROM SYS_UserGroup_Users WHERE ID LIKE 'ST'+CONVERT(VARCHAR(10), GETDATE(), 12)+'%'),0)+ROW_NUMBER() OVER(ORDER BY UserID)),4) as ID,SYS_UserGroupMainID,'{0}' AS UserID,'{1}' AS UserName,Temp1,Temp2,Temp3,Temp4 FROM SYS_UserGroup_Users dt1 WHERE dt1.UserID='{3}'
	                                INSERT INTO BusinessGroup_Detail
	                                SELECT LOWER(NEWID()) AS ItemID,ID,Code,'{0}' AS UserID,'{1}' AS UserName,[Status],CreateUserID,CONVERT(VARCHAR(19),GETDATE(),120) AS CreateDate,LastUpdateUserID,CONVERT(VARCHAR(19),GETDATE(),120) AS LastUpdateDate,NewStatus FROM BusinessGroup_Detail WHERE UserID='{3}'", txtNewUserID.Text, txtNewNameID.Text, txtNewEmailID.Text, txtOldUserID.Text);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlInsertUser, connection);
                command.ExecuteNonQuery();
                XtraMessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

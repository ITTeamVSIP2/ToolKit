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
    public partial class ThoiGianLamViec : DevExpress.XtraEditors.XtraUserControl
    {
        string AttDate;
        public ThoiGianLamViec()
        {
            InitializeComponent();
            dateEditDate.Properties.Mask.EditMask = "yyyy-MM-dd";
            dateEditDate.Properties.Mask.UseMaskAsDisplayFormat = true;
        }

        private void simpleButtonTra_Click(object sender, EventArgs e)
        {
            if (dateEditDate.Text == "")
            { XtraMessageBox.Show("Vui lòng chọn ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                AttDate = dateEditDate.Text;
                string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
                var connection = new SqlConnection(connString);
                string a = memoMSNV.Text.TrimEnd().ToString().Replace("\r\n", ",");
                string Sql = @"SELECT he.EmployeeID, he.EmployeeCode, he.EmployeeName, iaer.AttDate, iaer.BeginTime, iaer.EndTime, he.[Group], he.Status, he.CompanyCode
                           FROM dbo.SplitString('" + a + "', ',') AS ss"
                               + " INNER JOIN dbo.HREmployee AS he"
                               + " ON he.EmployeeCode = ss.s"
                               + " INNER JOIN dbo.IEAttEmloyeeRecord AS iaer"
                               + " ON iaer.EmployeeID = he.EmployeeID"
                               + " WHERE iaer.AttDate = '" + AttDate + "'";
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter;
                    adapter = new SqlDataAdapter(Sql, connection);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adapter.Fill(dt);
                    connection.Close();
                    gctrlDuLieuITS.DataSource = dt;
                    //gridView1.Columns["AttDate"].DisplayFormat.FormatString = "yyyy-MM-dd";
                    gridView1.Columns["EmployeeID"].Width = 80;
                    gridView1.Columns["EmployeeCode"].Width = 80;
                    gridView1.Columns["EmployeeName"].Width = 170;
                    gridView1.Columns["Status"].Width = 80;


                }
                catch// (Exception ex)
                {

                }
                if (comboBoxEditCongTy.Text == "Vsip1")
                {
                    string SqlV1 = @"SELECT adb.EmployeeId, adb.Name, adb.WorkDay, adb.WeekDay, adb.In1, adb.Out1, adb.AttendanceTimes, adb.Position
                           FROM dbo.SplitString('" + a + "', ',') AS ss"
                               + " INNER JOIN HRMVSIP1.Vietnam_HRMS.dbo.AC_DailyBalance AS adb (NOLOCK)"
                               + " ON adb.EmployeeId = ss.s COLLATE Chinese_PRC_CI_AS"
                               + " INNER JOIN HRMVSIP1.Vietnam_HRMS.dbo.AC_Ranks AS ar (NOLOCK)"
                               + " ON ar.RankID = adb.RankID"
                               + " WHERE CAST(adb.WorkDay AS DATE) = '" + AttDate + "'";
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter;
                        adapter = new SqlDataAdapter(SqlV1, connection);
                        System.Data.DataTable dt = new System.Data.DataTable();
                        adapter.Fill(dt);
                        connection.Close();
                        gctrlDuLieuHR.DataSource = dt;
                        gridView2.Columns["Name"].Width = 170;
                    }
                    catch// (Exception ex)
                    {

                    }
                }
                if (comboBoxEditCongTy.Text == "Vsip2")
                {
                    string SqlV2 = @"SELECT adb.EmployeeId, adb.Name, adb.WorkDay, adb.WeekDay, adb.In1, adb.Out1, adb.AttendanceTimes, adb.Position
                           FROM dbo.SplitString('" + a + "', ',') AS ss"
                               + " INNER JOIN HRMVSIP2.Vietnam_HRMS_VSIP2.dbo.AC_DailyBalance AS adb (NOLOCK)"
                               + " ON adb.EmployeeId = ss.s COLLATE Chinese_PRC_CI_AS"
                               + " INNER JOIN HRMVSIP2.Vietnam_HRMS_VSIP2.dbo.AC_Ranks AS ar (NOLOCK)"
                               + " ON ar.RankID = adb.RankID"
                               + " WHERE CAST(adb.WorkDay AS DATE) = '" + AttDate + "'";
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter;
                        adapter = new SqlDataAdapter(SqlV2, connection);
                        System.Data.DataTable dt = new System.Data.DataTable();
                        adapter.Fill(dt);
                        connection.Close();
                        gctrlDuLieuHR.DataSource = dt;
                        gridView2.Columns["Name"].Width = 170;
                    }
                    catch// (Exception ex)
                    {

                    }
                }
            }
        }

        private void simpleButtonDongbo_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("sp_IEUpdateAttRecord_VSIP2", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BeginDate", AttDate);
                command.Parameters.AddWithValue("@EndDate", AttDate);
                command.CommandTimeout = 0;
                command.ExecuteNonQuery();
                connection.Close();
                XtraMessageBox.Show("Đồng bộ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                connection.Close();
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SupportTools
{
    public partial class ThemTickGP : DevExpress.XtraEditors.XtraUserControl
    {
        public ThemTickGP()
        {
            InitializeComponent();
        }
        private void bthKiemTraTick_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["WTS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            string a = memoBarcode.Text.TrimEnd().ToString().Replace("\r\n", ",");
            string Sql = @"SELECT pcpd.bToERP , pcpd.sBarCode, pcpd.sCreator, pcpd.sSubFEPOCode, pcpd.sFEPoNo, pcpd.iPackageQty 
                           FROM STRING_SPLIT('" + a + "', ',') AS ss"
                           + " INNER JOIN dbo.ppCutPackageDtl AS pcpd ON ss.value=pcpd.sBarCode";
            try
            {
                connection.Open();
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(Sql, connection);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                connection.Close();
                gridControl2.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnCapNhatTick_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["WTS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            string a = memoBarcode.Text.TrimEnd().ToString().Replace("\r\n", ",");
            string Sql = @"UPDATE pcpd
                           SET pcpd.bToERP=1
                           FROM STRING_SPLIT('" + a + "', ',') AS ss"
                           + " INNER JOIN dbo.ppCutPackageDtl AS pcpd ON ss.value=pcpd.sBarCode";
            try
            {
                connection.Open();
                SqlCommand commandPrefix = new SqlCommand(Sql, connection);
                commandPrefix.ExecuteNonQuery();
                connection.Close();
                XtraMessageBox.Show("Đã đẩy ERP. OK.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bthKiemTraTick.PerformClick();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnCapNhatTick0_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["WTS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            string a = memoBarcode.Text.TrimEnd().ToString().Replace("\r\n", ",");
            string Sql = @"UPDATE pcpd
                           SET pcpd.bToERP=0
                           FROM STRING_SPLIT('" + a + "', ',') AS ss"
                           + " INNER JOIN dbo.ppCutPackageDtl AS pcpd ON ss.value=pcpd.sBarCode";
            try
            {
                connection.Open();
                SqlCommand commandPrefix = new SqlCommand(Sql, connection);
                commandPrefix.ExecuteNonQuery();
                connection.Close();
                XtraMessageBox.Show("Chưa đẩy ERP. OK.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bthKiemTraTick.PerformClick();
            }
            catch (Exception ex)
            {

            }
        }
    }
}

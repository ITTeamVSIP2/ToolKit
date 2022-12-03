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

    public partial class CatSieuThi : DevExpress.XtraEditors.XtraUserControl
    {
        string sqlGongPion, sqlStaging;
        public CatSieuThi()
        {
            InitializeComponent();
        }
        private void btnCheckCardID2_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["WMS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            sqlStaging = memoSQL.Text + "'" + txtCardID2.Text + "'" + " OR fcl.sRefBarCode = '" + txtCardID2.Text + "'";
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

        private void btnCheckCardID1_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["GP_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            sqlGongPion = memoSQLDataGongPion.Text + "'" + txtCardID1.Text + "'" + " OR fcl.sRefBarCode = '" + txtCardID1.Text + "'";
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlGongPion, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                gridControlDataGongPion.DataSource = dt;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

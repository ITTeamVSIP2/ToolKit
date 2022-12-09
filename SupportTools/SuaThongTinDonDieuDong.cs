using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace SupportTools
{
    public partial class SuaThongTinDonDieuDong : DevExpress.XtraEditors.XtraUserControl
    {
        string Sql;
        string SqlLike;
        public SuaThongTinDonDieuDong()
        {
            InitializeComponent();
        }
        private void btnSelectLine_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            Sql = "SELECT LineID, LineName FROM IESewingLine WHERE LineName LIKE 'VSIP2%'";
            SqlLike = "SELECT LineID, LineName FROM IESewingLine WHERE LineName LIKE '%" + txtNameLine.Text + "%' AND CompanyCode='79101'";
            try
            {
                connection.Open();
                SqlDataAdapter adapter;
                if (txtNameLine.Text == "")
                {
                    adapter = new SqlDataAdapter(Sql, connection);
                }
                else
                {
                    adapter = new SqlDataAdapter(SqlLike, connection);
                }
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                gcLine.DataSource = dt;
            }
            catch //(Exception ex)
            {
            }
        }
        private void btnQueryAddLine_Click(object sender, EventArgs e)
        {
            string Sql;
            string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            Sql = "SELECT isls.SectionID, isls.SectionName, islsd.SectionDetailID" + " "
                + "FROM dbo.IESewingLineSection AS isls" + " "
                + "INNER JOIN dbo.IESewingLineSectionDetail AS islsd ON islsd.SectionID = isls.SectionID" + " "
                + "WHERE LineID='" + txtAddLine.Text + "'";
            //SqlLike = "SELECT LineID, LineName FROM IESewingLine WHERE LineName LIKE '%" + txtNameLine.Text + "%' AND CompanyCode='79101'";
            try
            {
                connection.Open();
                SqlDataAdapter adapter;

                adapter = new SqlDataAdapter(Sql, connection);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                gcAddLine.DataSource = dt;


            }
            catch (Exception ex)
            {

            }

        }


        private void btnCheckQuery_Click(object sender, EventArgs e)
        {
            string Sql;
            string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            Sql = "SELECT islsd.SectionID, isls.SectionName, NEWID() AS SectionDetailID" + " "
                + "FROM dbo.IESewingLineSectionDetail AS islsd" + " "
                + "INNER JOIN dbo.IESewingLineSection AS isls ON isls.SectionID = islsd.SectionID" + " "
                + "WHERE islsd.LineID = 'C3A70FEC-F5DB-4D23-B0FF-566A6725479F' AND islsd.SectionID IN" + " "
                + "(SELECT SectionID FROM IESewingLineSectionDetail WHERE LineID = 'C3A70FEC-F5DB-4D23-B0FF-566A6725479F' AND SectionID NOT IN" + " "
                + "(SELECT SectionID FROM IESewingLineSectionDetail WHERE LineID = '" + txtInsertLine.Text + "'))";
            //SqlLike = "SELECT LineID, LineName FROM IESewingLine WHERE LineName LIKE '%" + txtNameLine.Text + "%' AND CompanyCode='79101'";
            try
            {
                connection.Open();
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(Sql, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                gcInsert.DataSource = dt;
            }
            catch (Exception ex)
            {
            }
        }

        private void btnInsertLineDetail_Click(object sender, EventArgs e)
        {
            string Sql;
            string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            Sql = "INSERT INTO dbo.IESewingLineSectionDetail" + " "
                            + "SELECT NEWID(), '" + txtInsertLine.Text + "', islsd.SectionID, islsd.Status, '25413', GETDATE(), '25413', GETDATE()" + " "
                            + "FROM dbo.IESewingLineSectionDetail AS islsd" + " "
                            + "WHERE islsd.LineID = 'C3A70FEC-F5DB-4D23-B0FF-566A6725479F' AND islsd.SectionID IN" + " "
                            + "(SELECT SectionID FROM IESewingLineSectionDetail WHERE LineID = 'C3A70FEC-F5DB-4D23-B0FF-566A6725479F' AND SectionID NOT IN" + " "
                            + "(SELECT SectionID FROM IESewingLineSectionDetail WHERE LineID = '" + txtInsertLine.Text + "'))";
            //SqlLike = "SELECT LineID, LineName FROM IESewingLine WHERE LineName LIKE '%" + txtNameLine.Text + "%' AND CompanyCode='79101'";
            try
            {
                connection.Open();
                SqlCommand commandINSERT = new SqlCommand(Sql, connection);
                commandINSERT.ExecuteNonQuery();
                MessageBox.Show("Insert successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string Sql;
            string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            Sql = @"SELECT ieat.ID, ieat.OrderCode, ieat.Description, ieat.Status, ieated.FromLineID, ieated.ToLineID, ieated.SectionDetailID, ieated.Description AS 'DescriptionDetail'
                    FROM dbo.IEAbnormalTime AS ieat
                    INNER JOIN dbo.IEAbnormalTimeEmployeeDetail AS ieated ON ieated.IEAbnormalTimeID = ieat.ID
                    WHERE ieat.OrderCode='" + txtOrderCode.Text + "'";
            //SqlLike = "SELECT LineID, LineName FROM IESewingLine WHERE LineName LIKE '%" + txtNameLine.Text + "%' AND CompanyCode='79101'";
            try
            {
                connection.Open();
                SqlDataAdapter adapter;

                adapter = new SqlDataAdapter(Sql, connection);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                gcIEAbnormalTime.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvLine_Click(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if (hitInfo.InRow)
            {
                txtAddLine.Text = dgvLine.GetRowCellValue(hitInfo.RowHandle, "LineID").ToString();
                txtInsertLine.Text = dgvLine.GetRowCellValue(hitInfo.RowHandle, "LineID").ToString();
            }
            string Sql;
            string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            Sql = "SELECT isls.SectionID, isls.SectionName, islsd.SectionDetailID" + " "
                + "FROM dbo.IESewingLineSection AS isls" + " "
                + "INNER JOIN dbo.IESewingLineSectionDetail AS islsd ON islsd.SectionID = isls.SectionID" + " "
                + "WHERE LineID='" + txtAddLine.Text + "'";
            //SqlLike = "SELECT LineID, LineName FROM IESewingLine WHERE LineName LIKE '%" + txtNameLine.Text + "%' AND CompanyCode='79101'";
            try
            {
                connection.Open();
                SqlDataAdapter adapter;

                adapter = new SqlDataAdapter(Sql, connection);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                gcAddLine.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }

        private void gcIEAbnormalTime_Load(object sender, EventArgs e)
        {
            gcIEAbnormalTime.EmbeddedNavigator.ButtonClick += EmbeddedNavigator_ButtonClick;
        }

        private void EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            /*int[] selectedRows = dgvIEAbnormalTime.GetSelectedRows();
            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                    var cellValue = dgvIEAbnormalTime.GetRowCellValue(rowHandle, "Order Code");
            }
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.EndEdit)
            {

                string a = dgvIEAbnormalTime.GetRowCellValue(Rơ)
                MessageBox.Show("Đã cập nhật thành công", a + "", MessageBoxButtons.OK);

            }*/
        }
    }
}

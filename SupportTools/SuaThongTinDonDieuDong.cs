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
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.EditForm.Helpers.Controls;


namespace SupportTools
{
    public partial class SuaThongTinDonDieuDong : DevExpress.XtraEditors.XtraUserControl
    {

        string Sql;
        string SqlLike;
        string idAfter, orderCodeAfter, desAfter, itemEmployeeIDAfter, employeeCodeAfter, toLineIDAfter, sectionDetailIDAfter, desDetailAfter;
        public SuaThongTinDonDieuDong()
        {
            InitializeComponent();

        }
        //
        private void BtnHienTra_Click(object sender, EventArgs e)
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









        private void btnConThieu_Click(object sender, EventArgs e)
        {
            string Sql;
            string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            Sql = "SELECT islsd.SectionID, isls.SectionName, NEWID() AS SectionDetailID" + " "
                + "FROM dbo.IESewingLineSectionDetail AS islsd" + " "
                + "INNER JOIN dbo.IESewingLineSection AS isls ON isls.SectionID = islsd.SectionID" + " "
                + "WHERE islsd.LineID = 'C3A70FEC-F5DB-4D23-B0FF-566A6725479F' AND islsd.SectionID IN" + " "
                + "(SELECT SectionID FROM IESewingLineSectionDetail WHERE LineID = 'C3A70FEC-F5DB-4D23-B0FF-566A6725479F' AND SectionID NOT IN" + " "
                + "(SELECT SectionID FROM IESewingLineSectionDetail WHERE LineID = '" + txtAddLine.Text + "'))";
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string Sql;
            string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            Sql = "INSERT INTO dbo.IESewingLineSectionDetail" + " "
                            + "SELECT NEWID(), '" + txtAddLine.Text + "', islsd.SectionID, islsd.Status, '25413', GETDATE(), '25413', GETDATE()" + " "
                            + "FROM dbo.IESewingLineSectionDetail AS islsd" + " "
                            + "WHERE islsd.LineID = 'C3A70FEC-F5DB-4D23-B0FF-566A6725479F' AND islsd.SectionID IN" + " "
                            + "(SELECT SectionID FROM IESewingLineSectionDetail WHERE LineID = 'C3A70FEC-F5DB-4D23-B0FF-566A6725479F' AND SectionID NOT IN" + " "
                            + "(SELECT SectionID FROM IESewingLineSectionDetail WHERE LineID = '" + txtAddLine.Text + "'))";
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

        private void btnHienThiAll_Click(object sender, EventArgs e)
        {
            string Sql;
            string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            Sql = @"SELECT ieat.ID, ieat.OrderCode, ieat.Description, ieated.ItemEmployeeID, HR.EmployeeCode, ieated.ToLineID, ieated.SectionDetailID, ieated.Description AS 'DescriptionDetail'
                    FROM dbo.IEAbnormalTime AS ieat
                    INNER JOIN dbo.IEAbnormalTimeEmployeeDetail AS ieated ON ieated.IEAbnormalTimeID = ieat.ID
					INNER JOIN dbo.HREmployee AS HR ON HR.EmployeeID = ieated.EmployeeID
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

        private void dgvLine_Click(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if (hitInfo.InRow)
            {
                txtAddLine.Text = dgvLine.GetRowCellValue(hitInfo.RowHandle, "LineID").ToString();
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
        private void dgvIEAbnormalTime_ShowingPopupEditForm(object sender, ShowingPopupEditFormEventArgs e)
        {
            foreach (Control control in e.EditForm.Controls)
            {
                if (!(control is EditFormContainer))
                {
                    continue;
                }
                foreach (Control nestedControl in control.Controls)
                {
                    if (!(nestedControl is PanelControl))
                    {
                        continue;
                    }
                    foreach (Control button in nestedControl.Controls)
                    {
                        if (button is SimpleButton)
                        {
                            var simpleButton = button as SimpleButton;
                            ChangeButtonCaption(simpleButton);
                        }
                    }
                }
            }
        }
        private void ChangeButtonCaption(SimpleButton simpleButton)
        {
            string newUpdateBtnText = "New Update";
            string newCancelBtnText = "New Cancel";
            string btnText = simpleButton.Text;
            switch (btnText)
            {
                case "Update":
                    simpleButton.Text = newUpdateBtnText;
                    break;
                case "Cancel":
                    simpleButton.Text = newCancelBtnText;
                    break;
            }
        }
        private void dgvIEAbnormalTime_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
                if (hitInfo.InRow)
                {
                    idAfter = System.Convert.ToString(dgvIEAbnormalTime.GetRowCellValue(hitInfo.RowHandle, "ID"));
                    orderCodeAfter = System.Convert.ToString(dgvIEAbnormalTime.GetRowCellValue(hitInfo.RowHandle, "OrderCode"));
                    desAfter = System.Convert.ToString(dgvIEAbnormalTime.GetRowCellValue(hitInfo.RowHandle, "Description"));
                    itemEmployeeIDAfter = System.Convert.ToString(dgvIEAbnormalTime.GetRowCellValue(hitInfo.RowHandle, "ItemEmployeeID"));
                    employeeCodeAfter = System.Convert.ToString(dgvIEAbnormalTime.GetRowCellValue(hitInfo.RowHandle, "EmployeeCode"));
                    toLineIDAfter = System.Convert.ToString(dgvIEAbnormalTime.GetRowCellValue(hitInfo.RowHandle, "ToLineID"));
                    sectionDetailIDAfter = System.Convert.ToString(dgvIEAbnormalTime.GetRowCellValue(hitInfo.RowHandle, "SectionDetailID"));
                    desDetailAfter = System.Convert.ToString(dgvIEAbnormalTime.GetRowCellValue(hitInfo.RowHandle, "DescriptionDetail"));
                }
                string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
                var connection = new SqlConnection(connString);
                if (checkEditThayDoiTatCa.Checked == true)
                {
                    string SqlMain = @"UPDATE IEAbnormalTime
                    SET Description = N'" + desAfter + "' WHERE ID = '" + idAfter + "' AND OrderCode = '" + orderCodeAfter + "'";
                    string SqlDetail = @"UPDATE dbo.IEAbnormalTimeEmployeeDetail
                    SET ToLineID='" + toLineIDAfter + "', SectionDetailID='" + sectionDetailIDAfter + "', Description=N'" + desDetailAfter + "' WHERE IEAbnormalTimeID='" + idAfter + "'";
                    DialogResult dialogResult = XtraMessageBox.Show("Bạn có chắc chắn muốn thay đổi tất cả?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        connection.Open();
                        SqlCommand commandMain = new SqlCommand(SqlMain, connection);
                        SqlCommand commandDetail = new SqlCommand(SqlDetail, connection);
                        commandMain.ExecuteNonQuery();
                        commandDetail.ExecuteNonQuery();
                        connection.Close();
                        btnHienThiAll_Click(sender, e);
                        XtraMessageBox.Show("Thay đổi tất cả thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        btnHienThiAll_Click(sender, e);
                    }

                }
                else
                {
                    string SqlMain = @"UPDATE IEAbnormalTime
                    SET Description = N'" + desAfter + "' WHERE ID = '" + idAfter + "' AND OrderCode = '" + orderCodeAfter + "'";
                    string SqlUpdateDetail = "UPDATE dbo.[IEAbnormalTimeEmployeeDetail]" + " "
                                + "SET ToLineID='" + toLineIDAfter + "', SectionDetailID='" + sectionDetailIDAfter + "', Description=N'" + desDetailAfter + "'" + " "
                                + "WHERE ItemEmployeeID = '" + itemEmployeeIDAfter + "'";
                    connection.Open();
                    SqlCommand commandPrefix = new SqlCommand(SqlUpdateDetail, connection);
                    SqlCommand commandMain = new SqlCommand(SqlMain, connection);
                    commandPrefix.ExecuteNonQuery();
                    commandMain.ExecuteNonQuery();
                    connection.Close();
                    btnHienThiAll_Click(sender, e);
                    XtraMessageBox.Show("Thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvIEAbnormalTime_Click(object sender, EventArgs e)
        {
            //GridView view = (GridView)sender;
            //GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            //if (hitInfo.InRow)
            //{
            //    string id = System.Convert.ToString(dgvIEAbnormalTime.GetRowCellValue(hitInfo.RowHandle, "ID"));
            //    string orderCode = System.Convert.ToString(dgvIEAbnormalTime.GetRowCellValue(hitInfo.RowHandle, "OrderCode"));
            //    string des = System.Convert.ToString(dgvIEAbnormalTime.GetRowCellValue(hitInfo.RowHandle, "Description"));
            //    string stt = System.Convert.ToString(dgvIEAbnormalTime.GetRowCellValue(hitInfo.RowHandle, "Status"));
            //    string fromLineID = System.Convert.ToString(dgvIEAbnormalTime.GetRowCellValue(hitInfo.RowHandle, "FromLineID"));
            //    string toLineID = System.Convert.ToString(dgvIEAbnormalTime.GetRowCellValue(hitInfo.RowHandle, "ToLineID"));
            //    string sectionDetailID = System.Convert.ToString(dgvIEAbnormalTime.GetRowCellValue(hitInfo.RowHandle, "SectionDetailID"));
            //    string desDetail = System.Convert.ToString(dgvIEAbnormalTime.GetRowCellValue(hitInfo.RowHandle, "DescriptionDetail"));
            //}

        }
    }
}

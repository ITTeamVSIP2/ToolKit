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
using SupportTools.Models;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Data.SqlClient;

namespace SupportTools
{
    public partial class ThietLapQuyenHan : DevExpress.XtraEditors.XtraUserControl
    {
        string SiteFunctionID;
        string ParentID;
        public ThietLapQuyenHan()
        {
            InitializeComponent();
            LoadSiteFunction();
        }
        public void LoadSiteFunction()
        {
            SQL_Control11 query = new SQL_Control11();
            string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
            try
            {
                gridControl1.DataSource = query.SQLquery_SiteFunction(connString).Tables["tableSiteFunction"];
                gridView1.Columns["SiteFunctionID"].Width = 100;
                gridView1.Columns["SiteFunctionName"].Width = 200;
                gridView1.Columns["ParentID"].Width = 70;
                gridView1.OptionsBehavior.Editable = false;
            }
            catch// (Exception ex)
            {
            }
        }

        private void simpleButtonTiep_Click(object sender, EventArgs e)
        {
            if (SiteFunctionID != "")
            {
                gridControl1.DataSource = null;
                SQL_Control11 query = new SQL_Control11();
                string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
                try
                {
                    gridControl1.DataSource = query.SQLquery_SiteFunction_Child(connString, SiteFunctionID).Tables["tableSiteFunction"];

                    gridView1.OptionsBehavior.Editable = false;
                }
                catch// (Exception ex)
                {
                }

                ParentID = gridView1.GetRowCellValue(1, "ParentID").ToString();
            }
        }
        private void simpleButtonLui_Click(object sender, EventArgs e)
        {
            
            if (ParentID == "0")
            {
                gridControl1.DataSource = null;
                LoadSiteFunction();
            }
            else
            {
                gridControl1.DataSource = null;
                SQL_Control11 query = new SQL_Control11();
                string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
                try
                {
                    gridControl1.DataSource = query.SQLquery_SiteFunction_Child(connString, ParentID).Tables["tableSiteFunction"];
                    
                    gridView1.OptionsBehavior.Editable = false;
                }
                catch// (Exception ex)
                {
                }
            }
            ParentID = gridView1.GetRowCellValue(1, "ParentID").ToString();
            SiteFunctionID = "";
        }
        private void gridView1_Click(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (hitInfo.InRow)
            {
                SiteFunctionID = view.GetRowCellValue(hitInfo.RowHandle, "SiteFunctionID").ToString();
                ParentID = view.GetRowCellValue(hitInfo.RowHandle, "ParentID").ToString();
            }

            gridControl2.DataSource = null;
            SQL_Control11 query = new SQL_Control11();
            string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
            try
            {
                gridControl2.DataSource = query.SQLquery_UserFunction(connString, SiteFunctionID).Tables["tableUserFunction"];

                gridView2.OptionsBehavior.Editable = false;
            }
            catch// (Exception ex)
            {
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            string sqlInsertFunc = memoInsertFunc.Text;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlInsertFunc, connection);
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

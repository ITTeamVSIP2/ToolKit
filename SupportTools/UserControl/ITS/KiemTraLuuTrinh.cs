using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Configuration;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Columns;

namespace SupportTools
{
    public partial class KiemTraLuuTrinh : UserControl
    {
        string ApproverID, NodeID, Sequence, CheckUserID, CheckUserName, DocumentTypeID, DocumentTypeName;
        int i;

        DataTable table = new DataTable();
        public KiemTraLuuTrinh()
        {
            InitializeComponent();
            LoadWFDocumentType();
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView2.OptionsView.ShowGroupPanel = false;
            gridView3.OptionsView.ShowGroupPanel = false;
            gridView4.OptionsView.ShowGroupPanel = false;
            gridView5.OptionsView.ShowGroupPanel = false;
            gridView2.ShowFindPanel();
            gridView4.ShowFindPanel();
            gridView5.ShowFindPanel();
            CreateTable();
            DesignGV1();
        }
        public void LoadWFDocumentType()
        {
            SQL_Control2 query = new SQL_Control2();
            string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
            try
            {
                gridControl2.DataSource = query.SQLquery_WFDocumentType(connString).Tables["tableWFDocumentType"];
                gridView2.Columns["DocumentTypeName"].Width = 50;
                gridView2.OptionsBehavior.Editable = false;
                gridControl4.DataSource = query.SQLquery_WFDocumentType(connString).Tables["tableWFDocumentType"];
                gridView4.Columns["DocumentTypeName"].Width = 50;
                gridView4.OptionsBehavior.Editable = false;
            }
            catch// (Exception ex)
            {
            }
        }
        public void LoadWFMain()
        {
            SQL_Control2 query = new SQL_Control2();
            string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
            try
            {
                gridControl3.DataSource = query.SQLquery_WFMain(txtMaDon.Text, connString).Tables["tableWFMain"];
                gridView3.Columns["CheckDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gridView3.Columns["CheckDate"].DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss.fff";
                DesignGV3();
            }

            catch// (Exception ex)
            {
            }
        }
        private void gridView2_Click(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (hitInfo.InRow)
            {
                labelControl.Text = view.GetRowCellValue(hitInfo.RowHandle, "DocumentTypeName").ToString();
            }
        }

        private void gridView4_Click(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (hitInfo.InRow)
            {
                DocumentTypeName = view.GetRowCellValue(hitInfo.RowHandle, "DocumentTypeName").ToString();
                LoadWorkFlow();
                string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
                var connection = new SqlConnection(connString);
                string sqlParameter = @"SELECT wfdt.Parameter
                                        FROM dbo.WFDocumentType AS wfdt
                                        WHERE DocumentTypeName = '" + DocumentTypeName + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlParameter, connection);
                SqlDataReader sqlReader = cmd.ExecuteReader();
                sqlReader.Read();
                txtBien.Text = sqlReader["Parameter"].ToString();
                sqlReader.Close();
                connection.Close();
            }
        }


        public void LoadWorkFlow()
        {
            SQL_Control2 query = new SQL_Control2();
            string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
            try
            {
                gridControl5.DataSource = query.SQLquery_WorkFlow(DocumentTypeName, connString).Tables["tableWorkFlow"];
                DesignGV5();
            }

            catch// (Exception ex)
            {
            }
        }
        private void simplebtnKiemTra_Click(object sender, EventArgs e)
        {
            LoadWFMain();
            for (int k2 = 0; k2 <= 12; k2++)
            {
                gridView1.SetRowCellValue(k2, "ApproverID", "");
                gridView1.SetRowCellValue(k2, "NodeID", "");
                gridView1.SetRowCellValue(k2, "Sequence", "");
                gridView1.SetRowCellValue(k2, "CheckUserID", "");
                gridView1.SetRowCellValue(k2, "CheckUserName", "");
                gridView1.SetRowCellValue(k2, "DocumentTypeID", "");
            }
            string connString = ConfigurationManager.ConnectionStrings["ITS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            try
            {
                connection.Open();
                for (i = 0; i <= 12; i++)
                {

                    SqlCommand cmd = new SqlCommand("sp_GetApprover", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DocumentTypeName", labelControl.Text);
                    cmd.Parameters.AddWithValue("@CostCenterCode", 0);
                    if (i == 0)
                    {
                        cmd.Parameters.AddWithValue("@NodeID", "");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@NodeID", NodeID);
                    }
                    cmd.Parameters.AddWithValue("@OrderCode", txtMaDon.Text);
                    cmd.Parameters.AddWithValue("@UserID", 0);
                    SqlDataReader sqlReader = cmd.ExecuteReader();

                    sqlReader.Read();
                    ApproverID = sqlReader["ApproverID"].ToString();
                    NodeID = sqlReader["NodeID"].ToString();
                    Sequence = sqlReader["Sequence"].ToString();
                    CheckUserID = sqlReader["CheckUserID"].ToString();
                    CheckUserName = sqlReader["CheckUserName"].ToString();
                    DocumentTypeID = sqlReader["DocumentTypeID"].ToString();

                    gridView1.SetRowCellValue(i, "ApproverID", ApproverID);
                    gridView1.SetRowCellValue(i, "NodeID", NodeID);
                    gridView1.SetRowCellValue(i, "Sequence", Sequence);
                    gridView1.SetRowCellValue(i, "CheckUserID", CheckUserID);
                    gridView1.SetRowCellValue(i, "CheckUserName", CheckUserName);
                    gridView1.SetRowCellValue(i, "DocumentTypeID", DocumentTypeID);
                    sqlReader.Close();
                }
                connection.Close();
            }
            catch //(Exception ex)
            {
                if (i == 0)
                {
                    for (int k = 0; k <= 12; k++)
                    {
                        gridView1.SetRowCellValue(k, "ApproverID", "");
                        gridView1.SetRowCellValue(k, "NodeID", "");
                        gridView1.SetRowCellValue(k, "Sequence", "");
                        gridView1.SetRowCellValue(k, "CheckUserID", "");
                        gridView1.SetRowCellValue(k, "CheckUserName", "");
                        gridView1.SetRowCellValue(k, "DocumentTypeID", "");
                    }
                    connection.Close();
                }
                else
                {
                    connection.Close();
                }
            }
        }
        public void DesignGV1()
        {
            gridView1.Columns["ApproverID"].Width = 70;
            gridView1.Columns["NodeID"].Width = 110;
            gridView1.Columns["Sequence"].Width = 60;
            gridView1.Columns["CheckUserID"].Width = 70;
            gridView1.Columns["CheckUserName"].Width = 110;
            //gridView1.OptionsBehavior.Editable = false;
        }
        public void DesignGV3()
        {
            gridView3.Columns.RemoveAt(5);
            gridView3.Columns["OrderCode"].Width = 100;
            gridView3.Columns["Sequence"].Width = 60;
            gridView3.Columns["NodeID"].Width = 150;
            gridView3.Columns["CheckUserName"].Width = 130;
        }
        public void DesignGV5()
        {
            gridView5.Columns["DocumentTypeName"].Width = 120;
            gridView5.Columns["Level"].Width = 70;
            gridView5.Columns["ApproverID"].Width = 70;
            gridView5.Columns["Condition"].Width = 200;
            gridView5.Columns["Department"].Width = 150;
            gridView5.Columns["SQL"].Width = 90;
        }
        public void CreateTable()
        {

            GridColumn column = gridView1.Columns.Add();
            column.Caption = "ApproverID";
            column.FieldName = "ApproverID";
            column.Visible = true;
            GridColumn column1 = gridView1.Columns.Add();
            column1.Caption = "NodeID";
            column1.FieldName = "NodeID";
            column1.Visible = true;

            GridColumn column2 = gridView1.Columns.Add();
            column2.Caption = "Sequence";
            column2.FieldName = "Sequence";
            column2.Visible = true;

            GridColumn column3 = gridView1.Columns.Add();
            column3.Caption = "CheckUserID";
            column3.FieldName = "CheckUserID";
            column3.Visible = true;

            GridColumn column4 = gridView1.Columns.Add();
            column4.Caption = "CheckUserName";
            column4.FieldName = "CheckUserName";
            column4.Visible = true;

            GridColumn column5 = gridView1.Columns.Add();
            column5.Caption = "DocumentTypeID";
            column5.FieldName = "DocumentTypeID";
            column5.Visible = true;


            table.Columns.Add("ApproverID");
            table.Columns.Add("NodeID");
            table.Columns.Add("Sequence");
            table.Columns.Add("CheckUserID");
            table.Columns.Add("CheckUserName");
            table.Columns.Add("DocumentTypeID");

            table.Rows.Add("");
            table.Rows.Add("");
            table.Rows.Add("");
            table.Rows.Add("");
            table.Rows.Add("");
            table.Rows.Add("");
            table.Rows.Add("");
            table.Rows.Add("");
            table.Rows.Add("");
            table.Rows.Add("");
            table.Rows.Add("");
            table.Rows.Add("");
            gridControl1.DataSource = table;
        }
    }
}

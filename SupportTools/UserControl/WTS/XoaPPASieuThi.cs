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
using app = Microsoft.Office.Interop.Excel.Application;
using Microsoft.Office.Interop.Excel;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;


namespace SupportTools
{
    public partial class XoaPPASieuThi : DevExpress.XtraEditors.XtraUserControl
    {
        int ColumnsCount, x;
        public XoaPPASieuThi()
        {
            InitializeComponent();
        }

        private void simpleButtonKiemTraInput_Click(object sender, EventArgs e)
        {
            if (gridControl1.DataSource != null)
            {
                ColumnsCount = gridView1.Columns.Count;
                gridControl1.DataSource = null;
                if (ColumnsCount == 37)
                {
                    for (int o = 1; o <= 37; o++)
                    {
                        gridView1.Columns.RemoveAt(0);
                    }
                }
            }
            string connString = ConfigurationManager.ConnectionStrings["WTS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            string a = memoBarcode.Text.TrimEnd().ToString().Replace("\r\n", ",");
            string Sql = @"SELECT ri.*
                           FROM dbo.SplitString('" + a + "', ',') AS ss"
                           + " INNER JOIN dbo.RFIDIn AS ri ON ri.sPackBarcode = ss.s";
            try
            {
                connection.Open();
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(Sql, connection);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                connection.Close();
                gridControl1.DataSource = dt;
                gridView1.Columns["tInTime"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gridView1.Columns["tInTime"].DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss.fff";
                x = gridView1.RowCount;
            }
            catch// (Exception ex)
            {

            }
        }

        private void simpleButtonKiemTraPPA_Click(object sender, EventArgs e)
        {
            if (gridControl1.DataSource != null)
            {
                ColumnsCount = gridView1.Columns.Count;
                gridControl1.DataSource = null;
                if (ColumnsCount == 40)
                {
                    for (int o = 1; o <= 40; o++)
                    {
                        gridView1.Columns.RemoveAt(0);
                    }
                }
            }
            string connString = ConfigurationManager.ConnectionStrings["WTS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            string a = memoBarcode.Text.TrimEnd().ToString().Replace("\r\n", ",");
            string Sql = @"SELECT ro.*
                           FROM dbo.SplitString('" + a + "', ',') AS ss"
                           + " INNER JOIN dbo.RFIDOutput AS ro ON ro.sPackBarcode = ss.s WHERE  ro.sProcedureName IN ('PPA IN','PPA OUT')";
            try
            {
                connection.Open();
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(Sql, connection);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                connection.Close();
                gridControl1.DataSource = dt;
                gridView1.Columns["tBegin"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gridView1.Columns["tEnd"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gridView1.Columns["dOutputDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gridView1.Columns["tCreateTime"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gridView1.Columns["tBegin"].DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss.fff";
                gridView1.Columns["tEnd"].DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss.fff";
                gridView1.Columns["dOutputDate"].DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss.fff";
                gridView1.Columns["tCreateTime"].DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss.fff";
                gridControl1.DataSource = dt;
                if (x == 1)
                {
                    simpleButtonXoaPPA.Enabled = false;
                }
                if (x != 1)
                {
                    simpleButtonXoaPPA.Enabled = true;
                }
            }
            catch //(Exception ex)
            {

            }
        }

        private void simpleButtonXuatExcel_Click(object sender, EventArgs e)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel Files|*.xlsx;*.xlsm|Excel Files|*.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                //string pathUser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                //string pathDownload = Path.Combine(filePath);
                //exportExcel(dataGridView1, pathDownload);
                gridControl1.ExportToXlsx(filePath);
                XtraMessageBox.Show("Lưu excel thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (filePath == "")
            { }

            //string path = "output.xlsx";
            
            // Open the created XLSX file with the default application.
            //System.Diagnostics.Process.Start(filePath);
        }
        private void exportExcel(DataGridView g, string duongDan)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 12;
            obj.Columns.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    { obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString(); }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan);
            obj.ActiveWorkbook.Saved = true;
        }

        private void simpleButtonXoaPPA_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.No)
            {
                string connString = ConfigurationManager.ConnectionStrings["WTS_Server"].ConnectionString;
                var connection = new SqlConnection(connString);
                string a = memoBarcode.Text.TrimEnd().ToString().Replace("\r\n", ",");
                string Sql = @"DELETE ro
                            FROM dbo.SplitString('" + a + "', ',') AS ss"
                            + " INNER JOIN dbo.RFIDOutput AS ro"
                            + " ON ss.s = ro.sPackBarcode"
                            + " WHERE ro.sProcedureName IN ('PPA IN', 'PPA OUT')";
                try
                {
                    connection.Open();
                    SqlCommand commandPrefix = new SqlCommand(Sql, connection);
                    commandPrefix.ExecuteNonQuery();
                    connection.Close();
                    XtraMessageBox.Show("Đã xóa dữ liệu PPA.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch //(Exception ex)
                {

                }
            }
        }
    }
}

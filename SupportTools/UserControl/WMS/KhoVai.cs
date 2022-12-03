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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;


namespace SupportTools
{
    public partial class KhoVai : DevExpress.XtraEditors.XtraUserControl
    {
        string Sql;
        string _MaterialCode;
        string _MaterialID;

        int flagdgv = 0;
        string Sqlbarcode;
        string Sqlbarcode1;
        string _FEPO;
        string FEPO1;
        string FEPO2;
        public KhoVai()
        {
            InitializeComponent();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["WMS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            Sql = "SELECT ms.MaterialCode, dtl.MaterialID AS 'MaterialIDdtl', ms.ColorCode, ms.ColorID, ms.MaterialID AS 'MaterialIDms' FROM FEWMS.dbo.FabricOutputOrderDtl dtl (NOLOCK)"
                + " " + "INNER JOIN FEWMS.dbo.MaterialStockFabric ms (NOLOCK) ON dtl.MaterialCode = ms.MaterialCode"
                + " " + "WHERE 1 = 1"
                + " " + "AND dtl.OrderCode = '" + txtOrderCode.Text + "'"
                + " " + "AND ms.MaterialID != dtl.MaterialID"
                + " " + "AND dtl.Quantity > dtl.DoQuantity";
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Sql, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                gridControlListOrderCode.DataSource = dt;

            }
            catch (Exception ex)
            {
                txtOrderCode.Text = ex.Message;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["WMS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            //Sql = "SELECT OrderCode, CustomerName, StartNo, EndNo, CartonBarCodePrefix, BarcodeStart, BarcodeEnd FROM ProductPackageDetailItem WHERE OrderCode = 'PDO-" + txtCodePDOOld.Text + "'";
            Sql = "SELECT DISTINCT MaterialCode, MaterialID AS 'MaterialIDdtl', ColorCode, ColorID FROM dbo.FabricOutputOrderDtl WHERE 1 = 1 AND OrderCode = '" + txtOrderCode.Text + "' AND Quantity > DoQuantity";
            //Sql = "SELECT OrderCode, StartNo, EndNo, CartonBarCodePrefix, BarcodeStart, BarcodeEnd FROM ProductPackageDetailItem WHERE OrderCode = '" + txtCodePDO.Text + "'";
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Sql, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                gridControlListOrderCode.DataSource = dt;
            }
            catch (Exception ex)
            {
                txtOrderCode.Text = ex.Message;
            }
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["WMS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            connection.Open();

            //Sql = "UPDATE RFIDEquipment SET iEquipmentGroupID = '" + txtiEquipmentGroupIDAfter.Text + "', iEquipmentID = '" + txtiEquipmentIDAfter.Text + "', sEquipmentName = '" + txtsEquipmentNameAfter.Text + "' WHERE iEquipmentGroupID = '" + txtiEquipmentGroupID.Text + "'" + " AND iEquipmentID = '" + txtiEquipmentID.Text + "'";+
            Sql = "UPDATE dbo.MaterialStockFabric SET MaterialID = '" + _MaterialID + "' WHERE 1 = 1 AND MaterialCode = '" + _MaterialCode + "'";
            try
            {
                SqlCommand commandPrefix = new SqlCommand(Sql, connection);
                commandPrefix.ExecuteNonQuery();
                connection.Close();
                XtraMessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                txtOrderCode.Text = ex.Message;
            }
        }

        private void gridViewListOrderCode_Click(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (hitInfo.InRow)
            {
                _MaterialCode = view.GetRowCellValue(hitInfo.RowHandle, "MaterialCode").ToString();
                _MaterialID = view.GetRowCellValue(hitInfo.RowHandle, "MaterialIDdtl").ToString();
                labelControl6.Text = _MaterialCode;
                labelControl5.Text = _MaterialID;
            }
        }

        private void btnShowFEPO_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["WMS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            Sqlbarcode = "IF OBJECT_ID('tempdb..#temp') IS NOT NULL"
                + " " + "DROP TABLE #temp;"
                + " " + "SELECT IDENTITY(int) AS 'ID', s AS 'FEPO'  INTO #temp"
                + " " + "FROM dbo.fn_SplitString('" + txtFEPO.Text + "', N'/') AS oppb2"
                + " " + "OPTION (MAXRECURSION 32767)";
            Sqlbarcode1 = "SELECT *"
                + " " + "FROM #temp";
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Sqlbarcode, connection);
                SqlDataAdapter adapter1 = new SqlDataAdapter(Sqlbarcode1, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                adapter1.Fill(dt);
                connection.Close();
                gridControlShowFEPO.DataSource = dt;
            }
            catch (Exception ex)
            {
                txtFEPO.Text = ex.Message;
            }
            for (int i = 0; i <= gridViewShowFEPO.RowCount - 2; i++)
            {
                //FEPO1 = gridViewShowFEPO.Rows[i].Cells["FEPO"].Value.ToString();
                FEPO1 = gridViewShowFEPO.GetRowCellValue(i, "FEPO").ToString();
                int _lenFEPO1 = FEPO1.Length;
                FEPO2 = gridViewShowFEPO.GetRowCellValue(i + 1, "FEPO").ToString();
                int _lenFEPO2 = FEPO2.Length;
                if (_lenFEPO1 > _lenFEPO2)
                {

                    int _len_lenFEPOtemp = _lenFEPO1 - _lenFEPO2;
                    string FEPO1temp = FEPO1.Substring(0, _len_lenFEPOtemp);
                    gridViewShowFEPO.SetRowCellValue(i + 1, "FEPO", FEPO1temp + FEPO2);
                }
            }
        }

        private void btnShowBarcode_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["WMS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            string sqlSN = "SELECT SN, BarCode, FEPOCode FROM MaterialStockFabric WHERE 1=1 AND FEPOCode='" + txtFEPO.Text + "'";

            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlSN, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            connection.Close();
            gridControlShowBarcode.DataSource = dt;
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            int countI = 0;
            if (flagdgv == 1)
            {
                string connString = ConfigurationManager.ConnectionStrings["WMS_Server"].ConnectionString;
                var connection = new SqlConnection(connString);
                //int o = dgvlistBarCode.Rows.Count;
                connection.Open();
                for (int i = 0; i <= gridViewShowBarcode.RowCount - 2; i++)
                {

                    string SN = gridViewShowBarcode.GetRowCellValue(i, "SN").ToString();
                    string BarCode = gridViewShowBarcode.GetRowCellValue(i, "BarCode").ToString();
                    string sqlFEPO = "SELECT * FROM MaterialStockFabricFepo WHERE 1=1 AND FEPOCode='" + _FEPO + "' AND SN='" + SN + "' AND BarCode='" + BarCode + "' ";

                    SqlDataAdapter adapter_sqlFEPO = new SqlDataAdapter(sqlFEPO, connection);
                    DataTable dt = new DataTable();
                    adapter_sqlFEPO.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        string sqlINSERT = "INSERT INTO [dbo].[MaterialStockFabricFepo]"
                               + " " + "([ID]"
                               + " " + ",[SN]"
                               + " " + ",[BarCode]"
                               + " " + ",[FEPOCode]"
                               + " " + ",[MaterialPurchaseOrderMstID]"
                               + " " + ",[MaterialPurchaseOrderDtlID]"
                               + " " + ",[MaterialStockInputOrderMstID]"
                               + " " + ",[MaterialStockInputOrderDtlID]"
                               + " " + ",[MaterialStockOutputOrderMstID]"
                               + " " + ",[MaterialStockOutputOrderDtlID]"
                               + " " + ",[CreateDate]"
                               + " " + ",[Msg]"
                               + " " + ",[LastUpdateDate])"
                         + " " + "VALUES"
                               + " " + "(NEWID()"
                               + " " + ",'" + SN + "'"
                               + " " + ",'" + BarCode + "'"
                               + " " + ",'" + _FEPO + "'"
                               + " " + ",NULL"
                               + " " + ",NULL"
                               + " " + ",NULL"
                               + " " + ",NULL"
                               + " " + ",NULL"
                               + " " + ",NULL"
                               + " " + ",GETDATE()"
                               + " " + ",'KAY'"
                               + " " + ",GETDATE())";
                        SqlCommand commandINSERT = new SqlCommand(sqlINSERT, connection);
                        commandINSERT.ExecuteNonQuery();
                        countI = 1;

                    }
                }
                if (countI == 1)
                {
                    connection.Close();
                    XtraMessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    connection.Close();
                    XtraMessageBox.Show("Dữ liệu đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                XtraMessageBox.Show("Vui lòng chọn FEPO.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridViewShowFEPO_Click(object sender, EventArgs e)
        {
            flagdgv = 1;
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (hitInfo.InRow)
            {
                _FEPO = view.GetRowCellValue(hitInfo.RowHandle, "FEPO").ToString();
            }
        }
    }
}

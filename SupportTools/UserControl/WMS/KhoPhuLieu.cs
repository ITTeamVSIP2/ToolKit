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
    public partial class KhoPhuLieu : DevExpress.XtraEditors.XtraUserControl
    {
        string SqlWMS, SqlStaging, SqlERP;
        string _OrderID;
        public KhoPhuLieu()
        {
            InitializeComponent();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["WMS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            string connStringERP = ConfigurationManager.ConnectionStrings["ERP_Server"].ConnectionString;
            var connectionERP = new SqlConnection(connStringERP);
            SqlWMS = @"SELECT AccessoryOutputOrderMst.StockOutOrderID, AccessoryOutputOrderMst.OrderCode, AccessoryOutputOrderMst.Status, AccessoryOutputOrderMst.OrderDate --FEPOCode, WarehouseName
                    FROM dbo.AccessoryOutputOrderMst
                    INNER JOIN dbo.AccessoryOutputOrderDtl 
                    ON AccessoryOutputOrderDtl.StockOutOrderID = AccessoryOutputOrderMst.StockOutOrderID
                    WHERE 1 = 1 AND AccessoryOutputOrderMst.OrderCode = '" + txtOrderCode.Text + "'";

            SqlStaging = @"SELECT msuo.StockOutOrderID, msuo.OrderCode, msuo.Status, msuo.OrderDate --msooai.Quantity
                            FROM erpsvr.FEAStaging.dbo.MaterialStockOutOrder msuo (NOLOCK)
                            INNER JOIN erpsvr.FEAStaging.dbo.MaterialStockOutOrderAccessoryItem msooai(NOLOCK)
                            ON msooai.StockOutOrderID = msuo.StockOutOrderID
                            WHERE msuo.OrderCode = '" + txtOrderCode.Text + "'";

            SqlERP = @"SELECT msuo.StockOutOrderID, msuo.OrderCode, msuo.Status, msuo.OrderDate --msooai.Quantity
                            FROM dbo.MaterialStockOutOrder msuo (NOLOCK)
                            INNER JOIN dbo.MaterialStockOutOrderAccessoryItem msooai(NOLOCK)
                            ON msooai.StockOutOrderID = msuo.StockOutOrderID
                            WHERE msuo.OrderCode = '" + txtOrderCode.Text + "'";
            try
            {
                connection.Open();
                connectionERP.Open();
                //WMS
                SqlDataAdapter adapterWMS = new SqlDataAdapter(SqlWMS, connection);
                DataTable dtWMS = new DataTable();
                adapterWMS.Fill(dtWMS);

                //Staging
                SqlDataAdapter adapterStaging = new SqlDataAdapter(SqlStaging, connection);
                DataTable dtStaging = new DataTable();
                adapterStaging.Fill(dtStaging);

                //ERP
                SqlDataAdapter adapterERP = new SqlDataAdapter(SqlERP, connectionERP);
                DataTable dtERP = new DataTable();
                adapterERP.Fill(dtERP);

                connection.Close();
                connectionERP.Close();

                gridControlDataWMS.DataSource = dtWMS;
                gridControlDataStaging.DataSource = dtStaging;
                gridControlDataERP.DataSource = dtERP;

            }
            catch (Exception ex)
            {
                txtOrderCode.Text = ex.Message;
            }
        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["WMS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            string connStringERP = ConfigurationManager.ConnectionStrings["ERP_Server"].ConnectionString;
            var connectionERP = new SqlConnection(connStringERP);
            SqlWMS = @"SELECT dtl.StockInOrderID, dtl.OrderCode, dtl.OrderID, dtl.FEPOCode, dtl.Quantity
                    FROM FEWMS.dbo.AccessoryInputOrderDtl dtl (nolock)
                    JOIN FEWMS.dbo.AccessoryInputOrderMst mst (nolock) ON dtl.StockInOrderID = mst.StockInOrderID
                    WHERE  1= 1 and mst.BLNumber like '%" + txtCodeee.Text + "%'"
                    + @"UNION
                    SELECT dtl.StockInOrderID, dtl.OrderCode, dtl.OrderID, dtl.FEPOCode, dtl.Quantity
                    FROM FEWMS.dbo.AccessoryInputOrderDtl dtl (nolock)
                    JOIN FEWMS.dbo.AccessoryInputOrderMst mst (nolock) ON dtl.StockInOrderID = mst.StockInOrderID
                    WHERE  1= 1 and mst.OrderCode like '%" + txtCodeee.Text + "%'";

            //SqlStaging = @"SELECT msuo.StockOutOrderID, msuo.OrderCode, msuo.Status, msuo.OrderDate --msooai.Quantity
            //                FROM erpsvr.FEAStaging.dbo.MaterialStockOutOrder msuo (NOLOCK)
            //                INNER JOIN erpsvr.FEAStaging.dbo.MaterialStockOutOrderAccessoryItem msooai(NOLOCK)
            //                ON msooai.StockOutOrderID = msuo.StockOutOrderID
            //                WHERE msuo.OrderCode = '" + txtOrderCode.Text + "'";

            //SqlERP = @"SELECT msuo.StockOutOrderID, msuo.OrderCode, msuo.Status, msuo.OrderDate --msooai.Quantity
            //                FROM dbo.MaterialStockOutOrder msuo (NOLOCK)
            //                INNER JOIN dbo.MaterialStockOutOrderAccessoryItem msooai(NOLOCK)
            //                ON msooai.StockOutOrderID = msuo.StockOutOrderID
            //                WHERE msuo.OrderCode = '" + txtOrderCode.Text + "'";
            try
            {
                connection.Open();
                connectionERP.Open();
                //WMS
                SqlDataAdapter adapterWMS = new SqlDataAdapter(SqlWMS, connection);
                DataTable dtWMS = new DataTable();
                adapterWMS.Fill(dtWMS);

                ////Staging
                //SqlDataAdapter adapterStaging = new SqlDataAdapter(SqlStaging, connection);
                //DataTable dtStaging = new DataTable();
                //adapterStaging.Fill(dtStaging);

                ////ERP
                //SqlDataAdapter adapterERP = new SqlDataAdapter(SqlERP, connectionERP);
                //DataTable dtERP = new DataTable();
                //adapterERP.Fill(dtERP);

                connection.Close();
                connectionERP.Close();

                gridControlDataWMS2.DataSource = dtWMS;
                //gridControlDataStaging.DataSource = dtStaging;
                //gridControlDataERP.DataSource = dtERP;

            }
            catch (Exception ex)
            {
                txtOrderCode.Text = ex.Message;
            }
        }

        private void btnSync2_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(txtDaySync.Text);
            string connString = ConfigurationManager.ConnectionStrings["WMS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("sp_SyncStockInAccessory", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@pDifferenceDays", -day);
                command.CommandTimeout = 0;
                command.ExecuteNonQuery();
                XtraMessageBox.Show("Đồng bộ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                txtOrderCode.Text = ex.Message;
            }
        }

        private void btnUpdateFEPO2_Click(object sender, EventArgs e)
        {
            UpdateFEPO updatefepo = new UpdateFEPO();
            updatefepo.Sender(_OrderID);
            updatefepo.ShowDialog();
        }

        private void gridViewDataWMS2_Click(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (hitInfo.InRow)
            {
                _OrderID = view.GetRowCellValue(hitInfo.RowHandle, "OrderID").ToString();
            }
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["WMS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            connection.Open();

            string SqlUpdate = @"UPDATE erpsvr.FEAStaging.dbo.MaterialStockOutOrder
                    SET Status='MSOO.CHECKED'
                    WHERE OrderCode='" + txtOrderCode.Text + "'";
            try
            {
                SqlCommand commandPrefix = new SqlCommand(SqlUpdate, connection);
                commandPrefix.ExecuteNonQuery();
                connection.Close();
                XtraMessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                txtOrderCode.Text = ex.Message;
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(txtDaySync.Text);
            string connString = ConfigurationManager.ConnectionStrings["WMS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("sp_SyncStockOutAccessory", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@pDifferenceDays", -day);
                command.CommandTimeout = 0;
                command.ExecuteNonQuery();
                XtraMessageBox.Show("Đồng bộ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                txtOrderCode.Text = ex.Message;
            }
        }
    }
}

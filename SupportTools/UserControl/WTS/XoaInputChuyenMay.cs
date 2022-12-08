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
    public partial class XoaInputChuyenMay : DevExpress.XtraEditors.XtraUserControl
    {
        public XoaInputChuyenMay()
        {
            InitializeComponent();
        }

        private void simpleButtonKiemTra_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["WTS_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            string connStringERP = ConfigurationManager.ConnectionStrings["ERP_Server"].ConnectionString;
            var connectionERP = new SqlConnection(connStringERP);
            string a = memoBarcode.Text.TrimEnd().ToString().Replace("\r\n", ",");
            string Sql_BTP_ERP = @"SELECT cso.CuttingStockOutID, cso.OrderCode, cso.OrderDate, cso.Checked, csod.Quantity, o.FEPOCode, a.sPackBarcode
                            FROM FEAERP.FEAERP_VN.dbo.CuttingStockOut AS cso
                            INNER JOIN FEAERP.FEAERP_VN.dbo.CuttingStockOutDetail AS csod
                            ON csod.CuttingStockOutID = cso.CuttingStockOutID
                            INNER JOIN FEAERP.FEAERP_VN.dbo.CuttingOrderItem AS coi
                            ON csod.CuttingOrderItemID = coi.ItemID
                            INNER JOIN FEAERP.FEAERP_VN.dbo.[Order] AS o
                            ON coi.OrderID = o.OrderID
                            INNER JOIN( 
                            SELECT ri.sLotNo, ri.iPackageNo, ri.sPackBarcode FROM dbo.RFIDIn AS ri) a
                            ON a.sLotNo = o.FEPOCode
                            INNER JOIN dbo.SplitString('" + a + "', ',')"
                            + " AS ss ON ss.s = a.sPackBarcode"
                            + " AND a.iPackageNo = coi.CardNo"
                            + " WHERE cso.Checked = 1";
            string Sql_Input_ERP = @"SELECT RFIDInput.*
                                    FROM dbo.SplitString('" + a + "', ',')" + " AS ss INNER JOIN dbo.RFIDInput ON ss.s = Barcode";
            string Sql_Input_GP = @"SELECT RFIDIn.*
                                    FROM dbo.SplitString('" + a + "', ',')" + " AS ss INNER JOIN dbo.RFIDIn ON ss.s = sPackBarcode";
            try
            {
                connection.Open();
                SqlDataAdapter adapter1;
                adapter1 = new SqlDataAdapter(Sql_BTP_ERP, connection);
                System.Data.DataTable dt1 = new System.Data.DataTable();
                adapter1.Fill(dt1);
                //
                SqlDataAdapter adapter2;
                adapter2 = new SqlDataAdapter(Sql_Input_ERP, connectionERP);
                System.Data.DataTable dt2 = new System.Data.DataTable();
                adapter2.Fill(dt2);
                //
                SqlDataAdapter adapter3;
                adapter3 = new SqlDataAdapter(Sql_Input_GP, connection);
                System.Data.DataTable dt3 = new System.Data.DataTable();
                adapter3.Fill(dt3);
                connection.Close();
                gridControldulieuBTPERP.DataSource = dt1;
                gridControldulieuInputERP.DataSource = dt2;
                gridControldulieuInputGP.DataSource = dt3;
            }
            catch
            {

            }
        }
    }
}

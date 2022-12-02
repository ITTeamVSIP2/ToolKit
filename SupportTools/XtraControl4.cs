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
using System.Data.SqlClient;

namespace SupportTools
{
    public partial class XtraControl4 : DevExpress.XtraEditors.XtraUserControl
    {
        //ERP
        private string constringERP = @"Data Source=10.17.215.12;Initial Catalog=FEAERP_VN;User id = dev_user;password=test";
        private List<InvoiceDTO> invoices { set; get; }
        public XtraControl4()
        {
            InitializeComponent();
        }

        private void simplebtnTruyVan_Click(object sender, EventArgs e)
        {
            if (txt_Invoice.Text.ToString().Trim() == "")
                return;
            dgInvoice.DataSource = null;
            getInvoice();
            if (invoices.Count == 0)
            {
                MessageBox.Show("Invoice này chưa có đổ dữ liệu! Hehe");
                return;
            }
            dgInvoice.DataSource = invoices;
        }
        private void getInvoice()
        {
            invoices = new List<InvoiceDTO>();
            using (SqlConnection con = new SqlConnection(constringERP))
            {
                string sql = string.Format(@"
SELECT omsi.InvoiceNo,
       ce.CustomerID,
       ce.CustomerName,
       su.UserID,
       su.UserName,
       CAST(omsi.CreateDateTime AS DATE) CreateDate,
       omsi.ImportPassel,
       SUM(omsi.QuantityPS) TotalYards,
       COUNT(omsi.BarCode) TotalRoll,
       CASE
           WHEN its.Total = 0 THEN
               N'Chưa phân bổ'
           ELSE
               N'Đã phân bổ'
       END ScheduleCode
FROM dbo.Other_MaterialStockIn AS omsi
    INNER JOIN dbo.CustomerEntity AS ce
        ON ce.CustomerID = omsi.SupplierID
    LEFT JOIN dbo.SystemUser AS su
        ON ce.CreateUserID = su.UserID
    OUTER APPLY
(
    SELECT COUNT(*) Total
    FROM ITS.ITS.dbo.MobileQCMQPSchedule AS mqs
    WHERE mqs.Invoice = omsi.InvoiceNo COLLATE DATABASE_DEFAULT
) its
WHERE omsi.InvoiceNo = '{0}'
GROUP BY omsi.InvoiceNo,
         ce.CustomerID,
         ce.CustomerName,
         su.UserID,
         su.UserName,
         CAST(omsi.CreateDateTime AS DATE),
         omsi.ImportPassel,
         its.Total
                ", txt_Invoice.Text.ToString().Trim());
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            invoices.Add(new InvoiceDTO
                            {
                                InvoiceNo = sdr["InvoiceNo"].ToString(),
                                CustomerID = sdr["CustomerID"].ToString(),
                                CustomerName = sdr["CustomerName"].ToString(),
                                UserID = sdr["UserID"].ToString(),
                                UserName = sdr["UserName"].ToString(),
                                CreateDate = sdr["CreateDate"].ToString(),
                                ImportPassel = sdr["ImportPassel"].ToString(),
                                TotalYards = Convert.ToDecimal(sdr["TotalYards"].ToString()),
                                TotalRoll = Convert.ToInt32(sdr["TotalRoll"].ToString()),
                                ScheduleCode = sdr["ScheduleCode"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }
        }

        private void simpleButtonDongBoInvoice_Click(object sender, EventArgs e)
        {
            if (txt_Invoice.Text.ToString().Trim() == "")
                return;
            //lấy invoice
            string invoice = txt_Invoice.Text.ToString();
            using (SqlConnection con = new SqlConnection(constringERP))
            {
                con.Open();
                string sqlSync = string.Format(@"
                DECLARE @importpassel NVARCHAR(40) = N'';
                SELECT TOP 1
                       @importpassel = omsi.ImportPassel
                FROM dbo.Other_MaterialStockIn AS omsi
                WHERE omsi.InvoiceNo = '{0}'
                      AND omsi.ImportPassel <> '';
                IF(@importpassel='')
                BEGIN
                    SET @importpassel ='WAITING'
                END
                UPDATE dbo.Other_MaterialStockIn SET ImportPassel=@importpassel WHERE InvoiceNo='{0}'
                ", invoice);
                var command = new SqlCommand();
                command.Connection = con;
                command.CommandText = sqlSync;
                var rows_affected = command.ExecuteNonQuery();
                MessageBox.Show($"Có tất cả {rows_affected} đã được đồng bộ thành công!");
                con.Close();
            }
        }
    }
}

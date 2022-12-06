using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Configuration;

namespace SupportTools
{
    public partial class Frm_FEPODetail : DevExpress.XtraEditors.XtraForm
    {
        //Khai báo delegate
        public delegate void SendMessager(string Messager);
        public SendMessager Sender;
        public Frm_FEPODetail()
        {
            InitializeComponent();
            //Tạo con trỏ tới hàm GetMessage
            Sender = new SendMessager(GetMessager);
        }
        private void GetMessager(string Messager)
        {
            lbFEPO.Text = lbFEPO.Text + Messager;
            string connString = ConfigurationManager.ConnectionStrings["ERP_Server"].ConnectionString;
            var connection = new SqlConnection(connString);
            string Sql = "SELECT * FROM" + " "
                         + "(SELECT" + " "
                         + "[Order].FepoCode AS FepoCode," + " "
                         + "CASE ActionLog.ActionCode" + " "
                         + "WHEN 'OPEN' THEN N'Kích hoạt S.X'" + " "
                         + "WHEN 'CLOSE' THEN N'Kết thúc S.X'" + " "
                         + "WHEN 'COMPLETE' THEN N'Kết thúc Đ.H'" + " "
                         + "WHEN 'UNCOMPLETE' THEN N'Kích hoạt Đ.H'" + " "
                         + "WHEN 'FABRICPURCHASEOPEN' THEN '面料采购开启'" + " "
                         + "WHEN 'FABRICPURCHASECLOSE' THEN '面料采购关闭'" + " "
                         + "WHEN 'ACCPURCHASEOPEN' THEN '辅料采购开启'" + " "
                         + "WHEN 'ACCPURCHASECLOSE' THEN '辅料采购关闭'" + " "
                         + "ELSE ActionLog.ActionCode" + " "
                         + "END AS ActionCode," + " "
                         + "ActionLog.Operator as Operator," + " "
                         + "ActionLog.OperateDateTime as OperateDateTime," + " "
                         + "CASE isnull(lastLog.lastTime,'')" + " "
                         + "WHEN '' THEN ''" + " "
                         + "ELSE 'YES' END  LastOperation" + " "
                         + "FROM ActionLog" + " "
                         + "INNER JOIN [Order] On [Order].OrderId=ActionLog.ObjectId" + " "
                         + "LEFT JOIN" + " "
                         + "(SELECT al.ObjectId,MAX(al.OperateDateTime) lastTime FROM ActionLog al GROUP BY al.ObjectId)" + " "
                         + "lastLog ON ActionLog.ObjectId=lastlog.ObjectId AND ActionLog.OperateDateTime=lastLog.lastTime)" + " "
                         + "ActionLog " + " "
                         + "WHERE FepoCode IN('" + Messager + "')" + "AND ActionLog.ActionCode LIKE N'%%%' ORDER BY ActionLog.FepoCode,ActionLog.OperateDateTime";
            try
            {
                connection.Open();
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(Sql, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                gctrlListFEPO.DataSource = dt;
                gctrlListFEPO.Refresh();
            }
            catch //(Exception ex)
            {

            }
        }
    }
}
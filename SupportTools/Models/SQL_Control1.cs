using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportTools
{
    class SQL_Control1
    {
        string sql;
        string sqlUpMain;
        public DataSet SQLquery_Main(string text, string con, int flag)
        {
            if (flag == 1)
            {
                sql = @"SELECT ID, OrderCode, TotalEstimateAmount, CreateDate, CreatorID, Status
                            FROM dbo.PAOrder
                            WHERE OrderCode ='" + text + "'";
            }
            if (flag == 2)
            {
                sql = @"SELECT ID, OrderCode, Description, EstimatedAmount, CreatorID, CreateDate, Status
                            FROM dbo.PRPaymentRequest
                            WHERE OrderCode ='" + text + "'";
            }
            if (flag == 3)
            {
                sql = @"SELECT ID, OrderCode, DepartmentName, TotalAmount, CreatorID, CreateDate, Status
                            FROM dbo.PDApplicationRequest
                            WHERE OrderCode ='" + text + "'";
            }
            if (flag == 4)
            {
                sql = @"SELECT ID, Code, TargetUser, Creator, CreateDate, Status
                            FROM dbo.PDCarpentry
                            WHERE Code ='" + text + "'";
            }
            if (flag == 5)
            {
                sql = @"SELECT LAID, LACode, Creator, CreateDate, Status
                            FROM dbo.ISLeaveAbsence
                            WHERE LACode ='" + text + "'";
            }
            if (flag == 6)
            {
                sql = @"SELECT ID, OrderCode, CreatorID, LineID, CreateDate, Status
                            FROM dbo.IEAbnormalTime
                            WHERE OrderCode='" + text + "'";
            }
            if (flag == 8)
            {
                sql = @"SELECT ibt.BTID, ibt.BTCode, ibt.CreatorID, ibt.CreateDate, ibt.Status
                        FROM dbo.ISBusinessTrip AS ibt
                        --INNER JOIN dbo.ISBusinessTripDetail AS ibtd ON ibtd.BTID = ibt.BTID
                        --INNER JOIN dbo.ISBusinessTripParticipant AS ibtp ON ibtp.BTID = ibt.BTID
                        --INNER JOIN dbo.ISBusinessTripReplacement AS ibtr ON ibtr.BTID = ibt.BTID
                        WHERE ibt.BTCode='" + text + "'";
            }
            if (flag == 9)
            {
                sql = @"SELECT ID, OrderCode, UserID, CreateDate, Status
                        FROM dbo.ERPDocument 
                        WHERE OrderCode='" + text + "'";
            }
            if (flag == 10)
            {
                sql = @"SELECT WSID, WSCode, CreatorID, CreateDate, Status
                        FROM dbo.PAWorkspace 
                        WHERE WSCode='" + text + "'";
            }
            if (flag == 11)
            {
                sql = @"SELECT ID, OrderCode, CreateUserID, CreateDate, Status
                        FROM dbo.ERPPurchaseInvoice 
                        WHERE OrderCode='" + text + "'";
            }
            if (flag == 12)
            {
                sql = @"SELECT ID, OrderCode, CreatorID, CreateDate, Status
                        FROM dbo.GAItem 
                        WHERE OrderCode='" + text + "'";
            }
            if (flag == 13)
            {
                sql = @"SELECT BookingID, BookingCode, CreatorID, CreateDate, Status
                        FROM dbo.ISCarBooking 
                        WHERE BookingCode='" + text + "'";
            }
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tableMain");
            return ds;
        }
        public DataSet SQLquery_WFMain(string text, string con)
        {
            string sqlWFMain = @"SELECT MainID, OrderCode, DocumentTypeID, isFinished, CreateUserID, CreateDate
                                FROM dbo.WFMain
                                WHERE OrderCode='" + text + "'";
            SqlDataAdapter adapterWFMain;
            adapterWFMain = new SqlDataAdapter(sqlWFMain, con);
            DataSet dsWFMain = new DataSet();
            adapterWFMain.Fill(dsWFMain, "tableWFMain");
            return dsWFMain;
        }
        public DataSet SQLquery_WFMainDetail(string text, string con)
        {
            string sqlWFMainDetail = @"SELECT MainDetailID, WFMainDetail.MainID, Sequence, WFNode.NodeID, PostUserID, CheckUserID, CheckDate,
           ISNULL(WFMainDetail.CheckDate, GETDATE()) Sequenceday,
                                     WFMainDetail.isFinished AS 'isFinished',
                                         CASE
                                                   WHEN
                                                   (
                                                       WFMainDetail.isFinished = 0
                                                       AND ISNULL(WFMainDetail.Temp1, 0) = 0
                                                   ) THEN
                                                       N'Đang ký'
                                                   WHEN (
                                                            WFMainDetail.isFinished = 1
                                                            AND WFMainDetail.Temp1 = 1
                                                        )
                                                        OR
                                                        (
                                                            WFMainDetail.isFinished = 0
                                                            AND WFMainDetail.Temp1 = 1
                                                        ) THEN
                                                       N'Trả về'
                                                   WHEN WFMainDetail.isFinished = 1 THEN
                                                       N'Hoàn thành'
                                               END AS 'Status'
                                    ,UserCodeID +' - '+ UserName AS 'Signer' ,Comment
                                FROM dbo.WFMain
                                INNER JOIN dbo.WFMainDetail ON WFMainDetail.MainID = WFMain.MainID
                                LEFT JOIN dbo.ISMobileUser ON UserID = CheckUserID
                                LEFT JOIN dbo.WFNode ON WFNode.NodeID = WFMainDetail.NodeID
                                WHERE OrderCode='" + text + "'"
                                + " ORDER BY Sequenceday DESC";
            SqlDataAdapter adapterWFMainDetail;
            adapterWFMainDetail = new SqlDataAdapter(sqlWFMainDetail, con);
            DataSet dsWFMainDetail = new DataSet();
            adapterWFMainDetail.Fill(dsWFMainDetail, "tableWFMainDetail");
            return dsWFMainDetail;
        }
        public void SQLupdate_Main(SqlConnection con, string ID, string OrderCode, string _OrderCode, string Status, int flag)
        {
            if (flag == 1)
            {
                sqlUpMain = @"UPDATE dbo.PAOrder
                              SET OrderCode='" + _OrderCode + "', Status='" + Status + "'"
                              + " WHERE ID='" + ID + "' AND OrderCode='" + OrderCode + "'";
            }
            if (flag == 2)
            {
                sqlUpMain = @"UPDATE dbo.PRPaymentRequest
                              SET OrderCode='" + _OrderCode + "', Status='" + Status + "'"
                              + " WHERE ID='" + ID + "' AND OrderCode='" + OrderCode + "'";
            }
            if (flag == 3)
            {
                sqlUpMain = @"UPDATE dbo.PDApplicationRequest
                              SET OrderCode='" + _OrderCode + "', Status='" + Status + "'"
                              + " WHERE ID='" + ID + "' AND OrderCode='" + OrderCode + "'";
            }
            if (flag == 4)
            {
                sqlUpMain = @"UPDATE dbo.PDCarpentry
                              SET Code='" + _OrderCode + "', Status='" + Status + "'"
                              + " WHERE ID='" + ID + "' AND Code='" + OrderCode + "'";
            }
            if (flag == 5)
            {
                sqlUpMain = @"UPDATE dbo.ISLeaveAbsence
                              SET LACode='" + _OrderCode + "', Status='" + Status + "'"
                              + " WHERE LAID='" + ID + "' AND LACode='" + OrderCode + "'";
            }
            if (flag == 6)
            {
                sqlUpMain = @"UPDATE dbo.IEAbnormalTime
                              SET OrderCode='" + _OrderCode + "', Status='" + Status + "'"
                              + " WHERE ID='" + ID + "' AND OrderCode='" + OrderCode + "'";
            }
            if (flag == 8)
            {
                sqlUpMain = @"UPDATE dbo.ISBusinessTrip
                              SET BTCode='" + _OrderCode + "', Status='" + Status + "'"
                              + " WHERE BTID='" + ID + "' AND BTCode='" + OrderCode + "'";
            }
            if (flag == 9)
            {
                sqlUpMain = @"UPDATE ERPDocument
                            SET OrderCode='" + _OrderCode + "', Status='" + Status + "'"
                            + " WHERE ID='" + ID + "' AND OrderCode='" + OrderCode + "'";
            }
            if (flag == 10)
            {
                sqlUpMain = @"UPDATE PAWorkspace
                            SET WSCode='" + _OrderCode + "', Status='" + Status + "'"
                            + " WHERE WSID='" + ID + "' AND WSCode='" + OrderCode + "'";
            }
            if (flag == 11)
            {
                sqlUpMain = @"UPDATE ERPPurchaseInvoice
                            SET OrderCode='" + _OrderCode + "', Status='" + Status + "'"
                            + " WHERE ID='" + ID + "' AND OrderCode='" + OrderCode + "'";
            }
            if (flag == 12)
            {
                sqlUpMain = @"UPDATE GAItem
                            SET OrderCode='" + _OrderCode + "', Status='" + Status + "'"
                            + " WHERE ID='" + ID + "' AND OrderCode='" + OrderCode + "'";
            }
            if (flag == 13)
            {
                sqlUpMain = @"UPDATE ISCarBooking
                            SET BookingCode='" + _OrderCode + "', Status='" + Status + "'"
                            + " WHERE BookingID='" + ID + "' AND BookingCode='" + OrderCode + "'";
            }
            con.Open();
            SqlCommand commandPrefix = new SqlCommand(sqlUpMain, con);
            commandPrefix.ExecuteNonQuery();
            con.Close();
        }
        public void SQLupdate_WFMain(SqlConnection con, string isFinished, string MainID)
        {
            string sqlUpMainID;
            sqlUpMainID = @"UPDATE dbo.WFMain
                                SET isFinished='" + isFinished + "'"
                            + " WHERE MainID='" + MainID + "'";
            con.Open();
            SqlCommand commandPrefix = new SqlCommand(sqlUpMainID, con);
            commandPrefix.ExecuteNonQuery();
            con.Close();
        }
        public void SQLupdate_WFMainDetail(SqlConnection con, string CheckUserID, string CheckDate, string isFinished, string Comment, string MainDetailID, string MainID)
        {
            string sqlUpMainDetailID;
            if (CheckDate == "")
            {
                sqlUpMainDetailID = @"UPDATE dbo.WFMainDetail
                                         SET CheckUserID='" + CheckUserID + "', CheckDate=NULL, isFinished='" + isFinished + "', Comment=N'" + Comment + "'"
                                             + " WHERE MainDetailID='" + MainDetailID + "' AND MainID='" + MainID + "'";
            }
            else
            {
                sqlUpMainDetailID = @"UPDATE dbo.WFMainDetail
                                         SET CheckUserID='" + CheckUserID + "', CheckDate='" + CheckDate + "', isFinished='" + isFinished + "', Comment=N'" + Comment + "'"
                                             + " WHERE MainDetailID='" + MainDetailID + "' AND MainID='" + MainID + "'";
            }
            con.Open();
            SqlCommand commandPrefix = new SqlCommand(sqlUpMainDetailID, con);
            commandPrefix.ExecuteNonQuery();
            con.Close();
        }
    }
}

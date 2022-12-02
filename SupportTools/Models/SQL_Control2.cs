using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportTools
{
    class SQL_Control2
    {
        public DataSet SQLquery_WFDocumentType(string con)
        {
            string sqlWFDocumentType = @"SELECT DocumentTypeName, Description FROM dbo.WFDocumentType";
            SqlDataAdapter adapterWFDocumentType;
            adapterWFDocumentType = new SqlDataAdapter(sqlWFDocumentType, con);
            DataSet dsWFDocumentType = new DataSet();
            adapterWFDocumentType.Fill(dsWFDocumentType, "tableWFDocumentType");
            return dsWFDocumentType;
        }
        public DataSet SQLquery_WFMain(string text, string con)
        {
            string sqlWFMain = @"SELECT wm.OrderCode, wn.Sequence, wn.NodeID, ismu.UserName AS 'CheckUserName', wmd.CheckDate, ISNULL(wmd.CheckDate, GETDATE()) Sequenceday
                                    FROM dbo.WFMain AS wm
                                        INNER JOIN dbo.WFMainDetail AS wmd
                                            ON wmd.MainID = wm.MainID
                                        INNER JOIN dbo.ISMobileUser AS ismu
                                            ON ismu.UserID = wmd.CheckUserID
	                                    LEFT JOIN dbo.WFNode AS wn 
	                                    ON wn.NodeID = wmd.NodeID
						WHERE wm.OrderCode='" + text + "' ORDER BY Sequenceday DESC";
            SqlDataAdapter adapterWFMain;
            adapterWFMain = new SqlDataAdapter(sqlWFMain, con);
            DataSet dsWFMain = new DataSet();
            adapterWFMain.Fill(dsWFMain, "tableWFMain");
            return dsWFMain;
        }
        public DataSet SQLquery_WorkFlow(string text, string con)
        {
            string sqlWorkFlow = @"SELECT wfdt.DocumentTypeName, wfn.Temp1 AS 'Level', wfnd.ApproverID, wfnd.Condition, cc.Remark AS 'Department', wfdt.Temp1 AS 'SQL'
                                FROM dbo.WFDocumentType AS wfdt
                                INNER JOIN dbo.WFNode AS wfn ON wfn.DocumentTypeID = wfdt.DocumentTypeID
                                INNER JOIN dbo.WFNodeDetail wfnd ON wfnd.NodeID = wfn.NodeID
                                INNER JOIN dbo.CostCenter cc ON cc.CostCenterCode = wfnd.CostCenterCode
                                WHERE DocumentTypeName='" + text + "'";
            SqlDataAdapter adapterWorkFlow;
            adapterWorkFlow = new SqlDataAdapter(sqlWorkFlow, con);
            DataSet dsWorkFlow = new DataSet();
            adapterWorkFlow.Fill(dsWorkFlow, "tableWorkFlow");
            return dsWorkFlow;
        }
    }
}

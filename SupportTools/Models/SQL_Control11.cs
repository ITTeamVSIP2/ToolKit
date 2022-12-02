using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportTools.Models
{
    class SQL_Control11
    {
        public DataSet SQLquery_SiteFunction(string con)
        {
            string sqlSiteFunction = @"SELECT SiteFunctionID, SiteFunctionName, ParentID FROM SiteFunction WHERE ParentID = 0";
            SqlDataAdapter adapterSiteFunction;
            adapterSiteFunction = new SqlDataAdapter(sqlSiteFunction, con);
            DataSet dsSiteFunction = new DataSet();
            adapterSiteFunction.Fill(dsSiteFunction, "tableSiteFunction");
            return dsSiteFunction;
        }
        public DataSet SQLquery_SiteFunction_Child(string con, string id)
        {
            string sqlSiteFunction_Child = @"SELECT sf1.SiteFunctionID, sf1.SiteFunctionName, sf2.ParentID 
                                        FROM SiteFunction sf1
                                        INNER JOIN SiteFunction sf2 ON sf2.SiteFunctionID= sf1.ParentID
                                        WHERE sf1.ParentID = '" + id + "'";
            SqlDataAdapter adapterSiteFunction_Child;
            adapterSiteFunction_Child = new SqlDataAdapter(sqlSiteFunction_Child, con);
            DataSet dsSiteFunction_Child = new DataSet();
            adapterSiteFunction_Child.Fill(dsSiteFunction_Child, "tableSiteFunction");
            return dsSiteFunction_Child;
        }
        public DataSet SQLquery_UserFunction(string con, string id)
        {
            string sqlUserFunction = @"SELECT *
                                        FROM dbo.UserFunction
                                        WHERE SiteFunctionID='" + id + "' ORDER BY CreateDate DESC";
            SqlDataAdapter adapterUserFunction;
            adapterUserFunction = new SqlDataAdapter(sqlUserFunction, con);
            DataSet dsUserFunction = new DataSet();
            adapterUserFunction.Fill(dsUserFunction, "tableUserFunction");
            return dsUserFunction;
        }
    }
}

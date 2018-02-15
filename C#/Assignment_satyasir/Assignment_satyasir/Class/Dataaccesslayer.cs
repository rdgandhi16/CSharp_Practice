using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Assignment_satyasir
{
    public class Dataaccesslayer
    {
        string str = ConfigurationManager.ConnectionStrings["str"].ToString();
        public DataTable db_dept()
        {
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter ad = new SqlDataAdapter("select from *DEPARTMENT", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
    }
}
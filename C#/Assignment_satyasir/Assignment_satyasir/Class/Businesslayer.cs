using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Assignment_satyasir
{
    public class Businesslayer
    {
        Dataaccesslayer db = new Dataaccesslayer();

        public int eid { get; set; }
        public string ename { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public int deptid { get; set; }
        public string jdate { get; set; }
        public string bdate { get; set; }
        public string gender { get; set; }
        public bool isact { get; set; }
        public string depname { get; set; }

        public DataTable bs_dept()
        {
            return db.db_dept();
        }

    }
}
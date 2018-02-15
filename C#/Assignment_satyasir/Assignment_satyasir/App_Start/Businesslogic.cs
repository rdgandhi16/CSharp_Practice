using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace Assignment_satyasir
{

    public class Businesslogic
    {

        Dataaccess da = new Dataaccess();
        public int stdid { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string gender { get; set; }
        public string age { get; set; }
        public string address { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string image { get; set; }
        public int sid { get; set; }
        public DataTable bs_state()
        {
            return da.da_state();
        }
        public DataTable bs_city(Businesslogic bs)
        {
            return da.da_city(bs);
        }
        public int bs_insert(Businesslogic bs)
        {
            return da.da_insert(bs);
        }
        public DataSet bs_admin()
        {
            return da.da_admin();
        }
        public int bs_update(Businesslogic bs)
        {
            return da.da_update(bs);
        }
        public int bs_delete(Businesslogic bs)
        {
           return da.da_delete(bs);
        }
        public DataTable bs_depbind()
        {
            return da.db_depbind();
        }

        public int did { get; set; }
        public string dname { get; set; }

        public int bs_insertdepartment(Businesslogic bs)
        {
            return da.db_insertdepartment(bs);
        }
        public int bs_updatedepartment(Businesslogic bs)
        {
            return da.db_updatedepartment(bs);
        }



    }
}
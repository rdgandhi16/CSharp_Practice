using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for business
/// </summary>
public class business
{
    dataaccess depdata = new dataaccess();

    public int depid { get; set; }
    public string depname { get; set; }

    public int eid { get; set; }
    public string ename { get; set; }
    public string address { get; set; }
    public string city { get; set; }
    public string depart { get; set; }
    public string jdate { get; set; }
    public string bdate { get; set; }
    public string gender { get; set; }
    public bool isact { get; set; }

    

    public business()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int business_Depinsert(business depbuss)
    {
        return depdata.Depinsert(depbuss);
    }
    public DataTable business_depBind()
    {
        return depdata.depBind();
    }
    public int business_depupdate(business depbuss)
    {
        return depdata.depupdate(depbuss);
    }

    public DataTable buss_Binddep()
    {
        return depdata.db_Binddep();
    }

    public int buss_insertempdata(business buss)
    {
        return depdata.db_insertempdata(buss);
    }
    public DataSet bs_bindemp()
    {
        return depdata.db_bindemp();
    }
}
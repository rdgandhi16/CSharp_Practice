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

    dataaccess empdata = new dataaccess();

    public int eid { get; set; }
    public string fname { get; set; }
    public string lname { get; set; }
    public string gender { get; set; }
    public string department { get; set; }
    public string skills { get; set; }
    public string state { get; set; }
	public business()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int bussemp_Insert(business empbs)
    {
        return empdata.dataemp_Insert(empbs);
    }
    public DataSet business_bindEmpdata()
    {
        return empdata.dataaccess_bindEmpdata();
    }
    public int bussemp_update(business empbs)
    {
        return empdata.db_update(empbs);
    }
}
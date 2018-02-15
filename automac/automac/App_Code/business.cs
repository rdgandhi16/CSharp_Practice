using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for business
/// </summary>
public class business
{
    database db = new database();

    public int eid { get; set; }
    public string ename { get; set; }
    public string addr { get; set; }
    public string city { get; set; }
    public int deptid { get; set; }
    public string jdate { get; set; }
    public string bdate { get; set; }
    public string gender { get; set; }
    public bool isact { get; set; }

    public string deptname { get; set; }

	public business()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataTable bs_emp_grid()
    {

        return db.grid_emp();
    }


    public DataTable bs_dept_grid()
    {

        return db.grid_dept();
    }



    public int bs_dept_insert(business bs)
    {
        return db.dept_insert(bs);

    }


    public int bs_emp_insert(business bs)
    {

        return db.emp_insert(bs);
    }


    public int bs_update_dept(business bs)
    {

        return db.update_dept(bs);
    }
}
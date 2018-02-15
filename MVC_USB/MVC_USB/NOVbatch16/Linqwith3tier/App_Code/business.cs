using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;


/// <summary>
/// Summary description for business
/// </summary>
public class business
{
    database db = new database();
    public int id { get; set; }
    public string fname { get; set; }
    public string lname { get; set; }
	public business()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public void bs_insert(business bs)
    {
        db.db_insert(bs);
    }
    public IList bs_bind()
    {
        return db.db_bind();
    }

    public void bs_update(business bs)
    {
        db.db_update(bs);
    }
    public void bs_delete(business bs)
    {
        db.db_delete(bs);
    }
}
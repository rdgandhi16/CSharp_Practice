using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


/// <summary>
/// Summary description for businesslayer
/// </summary>
public class businesslayer
{
    databaselayer db = new databaselayer();
  
    public int id { get; set; }
    public string fname { get; set; }
    public string  lname { get; set; }
   


	public businesslayer()
	{
		
	}

    public int bs_insert(businesslayer bs)
    {
        return db.db_insert(bs);
    }
    public DataSet bs_bind()
    {
        return db.db_bind();
    }
    public int bs_update(businesslayer bs)
    {
        return db.db_update(bs);
    }
    public int bs_delete(businesslayer bs)
    {
        return db.db_delete(bs);
    }
}
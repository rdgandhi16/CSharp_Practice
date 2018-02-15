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
    public string gender { get; set; }
    public string hobby { get; set; }
    public string subject { get; set; }
    public string state { get; set; }
    public string image { get; set; }
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
}
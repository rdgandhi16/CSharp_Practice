using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for businesslayer
/// </summary>
public class businesslayer
{
    dataaccesslayer dataaccess = new dataaccesslayer();

    public int studentid { get; set; }
    public string fname { get; set; }
    public string lname { get; set; }
    public string gender { get; set; }
    public string state { get; set; }
    public string city { get; set; }
    public string department { get; set; }
    public string image { get; set; }
    public string hobby { get; set; }
    public int stateid { get; set; }
    public int cityid { get; set; }
    public businesslayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable bussiness_state()
    {
        return dataaccess.dataaccessState();
    }
    public DataSet businessCity(businesslayer business)
    {
        return dataaccess.dataaccessCity(business);
    }
}
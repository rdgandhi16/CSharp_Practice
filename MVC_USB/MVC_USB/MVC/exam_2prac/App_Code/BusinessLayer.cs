using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for BusinessLayer
/// </summary>
public class BusinessLayer
{

    DatabaseLayer ds = new DatabaseLayer();

    public int category_id { get; set; }
    public string category_name { get; set; }
    
    public int product_id { get; set; }
    public string product_name { get; set; }
    public float product_price { get; set; }
    public int product_qty { get; set; }
    public string product_description { get; set; }
    public int product_cat_id { get; set; }
    public string product_image { get; set; }

    public int cart_id { get; set; }
    public string cart_product_name { get; set; }
    public int cart_product_qty { get; set; }
    public float cart_total_amount { get; set; }


	public BusinessLayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public int bl_add_category(BusinessLayer bs)
    {

        return ds.dl_add_category(bs);
    }

    public DataSet bl_getCat()
    {

        return ds.get_cat();
    }

    public int bl_add_product(BusinessLayer bs)
    {

        return ds.dl_add_product(bs);
    }


    public DataSet bl_get_product(BusinessLayer bs)
    {
        return ds.get_product(bs);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;


/// <summary>
/// Summary description for database
/// </summary>
public class database
{
    DataClassesDataContext dc = new DataClassesDataContext();
	public database()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void db_insert(business bs)
    {
       // tbl_reg tr = new tbl_reg();
      //  tr.fname = bs.fname;
      //  tr.lname = bs.lname;

      //  dc.tbl_regs.InsertOnSubmit(tr);
      //  dc.SubmitChanges();

        dc.sp_insert_linq(bs.fname, bs.lname);
    }

    public IList db_bind()
    {
       // var p = from n in dc.tbl_regs select n;

      //   return p.ToList();

     return dc.sp_display_linq().ToList();

    }

    public void db_update(business bs)
    {
        //int i = bs.id;
        //var p = (from n in dc.tbl_regs where n.id == i select n).FirstOrDefault();

        //p.fname = bs.fname;
        //p.lname = bs.lname;

        //dc.SubmitChanges();
        dc.sp_update_linq(bs.id, bs.fname, bs.lname);

        
    }
    public void db_delete(business bs)
    {
        //int i = bs.id;
        //var p = (from n in dc.tbl_regs where n.id == i select n).FirstOrDefault();

        //dc.tbl_regs.DeleteOnSubmit(p);
        //dc.SubmitChanges();
        dc.sp_delete_linq(bs.id);


    }
}
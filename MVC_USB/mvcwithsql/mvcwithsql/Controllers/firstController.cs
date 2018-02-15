using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using mvcwithsql.Models;

namespace mvcwithsql.Controllers
{
    public class firstController : Controller
    {
        //
        // GET: /first/

        string str = ConfigurationManager.ConnectionStrings["str"].ToString();

        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]

        public ActionResult Index(first f)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into tbl_fn_ln values(@fn,@ln)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@fn", f.fname);
            cmd.Parameters.AddWithValue("@ln", f.lname);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            return View();

        }

        [HttpGet]
        public ActionResult getdata()
        {

            var m = new List<first>();
            string str = ConfigurationManager.ConnectionStrings["str"].ToString();
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from tbl_fn_ln";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                first f = new first();

                f.id = reader.GetInt32(0);
                f.fname = reader.GetString(1);
                f.lname = reader.GetString(2);
                m.Add(f);
            }

            con.Close();

            return View(m);

        }

        [HttpGet]
        public ActionResult edit(int id)
        {

            string str = ConfigurationManager.ConnectionStrings["str"].ToString();
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from tbl_fn_ln where id='" + id + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            first f = new first();
            f.id = int.Parse(dt.Tables[0].Rows[0]["id"].ToString());
            f.fname = dt.Tables[0].Rows[0]["fname"].ToString();
            f.lname = dt.Tables[0].Rows[0]["lname"].ToString();
            con.Close();

            return View(f);

        }
        [HttpPost]
        public ActionResult edit(int id, first f)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Update tbl_fn_ln set fname=@fn,lname=@ln where id='" + id + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@fn", f.fname);
            cmd.Parameters.AddWithValue("@ln", f.lname);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            return RedirectToAction("getdata");

        }

        [HttpGet]
        public ActionResult delete(int id)
        {

            string str = ConfigurationManager.ConnectionStrings["str"].ToString();
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from tbl_fn_ln where id='" + id + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            first f = new first();
            f.id = int.Parse(dt.Tables[0].Rows[0]["id"].ToString());
            f.fname = dt.Tables[0].Rows[0]["fname"].ToString();
            f.lname = dt.Tables[0].Rows[0]["lname"].ToString();
            con.Close();

            return View(f);

        }
        [HttpPost]
        public ActionResult delete(int id, first f)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from tbl_fn_ln where id='"+id+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

           
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            return RedirectToAction("getdata");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
    
namespace Assignment_satyasir
{
    public class Dataaccess
    {
        string str = ConfigurationManager.ConnectionStrings["str"].ToString();
       
        public DataTable da_state()
        {
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter ad = new SqlDataAdapter("sp_state ", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public DataTable da_city(Businesslogic bs)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "sp_city";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Connection = con;
            cm.Parameters.AddWithValue("@id", bs.sid);

            SqlDataAdapter ad = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public int da_insert(Businesslogic bs)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "student_insert";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Connection = con;

           // cm.Parameters.AddWithValue("@id", bs.stdid);
            cm.Parameters.AddWithValue("@fn", bs.fname);
            cm.Parameters.AddWithValue("@ln", bs.lname);
            cm.Parameters.AddWithValue("@gn", bs.gender);
            cm.Parameters.AddWithValue("@age", bs.age);
            cm.Parameters.AddWithValue("@ad", bs.address);
            cm.Parameters.AddWithValue("@st", bs.state);
            cm.Parameters.AddWithValue("@ct", bs.city);
            cm.Parameters.AddWithValue("@image", bs.image);

            con.Open();
            int p = cm.ExecuteNonQuery();
            con.Close();
            return p;            
        }


        public int da_update(Businesslogic bs)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update_admin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@id", bs.stdid);
            cmd.Parameters.AddWithValue("@fn", bs.fname);
            cmd.Parameters.AddWithValue("@ln", bs.lname);
            cmd.Parameters.AddWithValue("@gn", bs.gender);
            cmd.Parameters.AddWithValue("@age", bs.age);
            cmd.Parameters.AddWithValue("@ad", bs.address);
            cmd.Parameters.AddWithValue("@st", bs.state);
            cmd.Parameters.AddWithValue("@ct", bs.city);
            cmd.Parameters.AddWithValue("@image", bs.image);

            con.Open();
            int p = cmd.ExecuteNonQuery();
            con.Close();
            return p;

        }
        public DataSet da_admin()
        {
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter ad = new SqlDataAdapter("admin_bind", con);

            DataSet dt = new DataSet();
            ad.Fill(dt);
            return dt;
        }
        public int da_delete(Businesslogic bs)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "delete_student";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Connection = con;

            cm.Parameters.AddWithValue("@id", bs.stdid);

            con.Open();
            int p = cm.ExecuteNonQuery();
            con.Close();
            return p;
        }

        public DataTable db_depbind()
        {
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter ad = new SqlDataAdapter("bind_dept", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;

        }
        public int db_insertdepartment(Businesslogic bs)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insertdepartment";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@dname", bs.dname);
            con.Open();
            int p = cmd.ExecuteNonQuery();
            con.Close();
            return p;
        }
        public int db_updatedepartment(Businesslogic bs)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "update_department";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Connection = con;

            cm.Parameters.AddWithValue("@id", bs.did);
            cm.Parameters.AddWithValue("@dname", bs.dname);

            con.Open();
            int p = cm.ExecuteNonQuery();
            con.Close();
            return p;
        }
    }
}
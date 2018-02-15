using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mitesh_mvc.Models;

namespace mitesh_mvc.Controllers
{
    public class LoginController : Controller
    {
        db_mvcmiteshEntities dc = new db_mvcmiteshEntities();
        //
        // GET: /Login/

        public ActionResult Index()
        {             return View();
        }



        [HttpPost]
        public ActionResult Index(login l)
        {
            var p = (from n in dc.tbl_login where n.username== l.uname && n.password == l.pass select n).FirstOrDefault();

            if (p != null)
            {
                Session["username"] = l.uname;
                return RedirectToAction("home");
            }
            else
            {
                l.msg = "User name or password incorrect";
               // return RedirectToAction("Index");
            }


            return View(l);
        }

        [HttpGet]
        public ActionResult home(login ll)
        {
            if (Session["username"]!= null)
            {
                ll.uname = Session["username"].ToString();
            }
            return View(ll);
        }


        [HttpPost]
        public ActionResult home()
        {
            Session.Abandon();
            return RedirectToAction("Index");
            
        }

        [HttpGet]
        public ActionResult forgot_password()
        {
           
            return View();
        }
    }
}

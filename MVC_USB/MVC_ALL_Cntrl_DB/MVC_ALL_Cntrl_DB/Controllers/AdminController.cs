using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_ALL_Cntrl_DB.Models;

namespace MVC_ALL_Cntrl_DB.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        db_mvc_vishEntities dc = new db_mvc_vishEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gender()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Gender(admin a)
        {
            tbl_gender tr = new tbl_gender();
            tr.gender = a.genname;

            dc.tbl_gender.Add(tr);
            dc.SaveChanges();
            return View();
        }

        public ActionResult Hobby()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Hobby(admin a)
        {
            tbl_hobby tr = new tbl_hobby();
            tr.hobby = a.hbname;

            dc.tbl_hobby.Add(tr);
            dc.SaveChanges();
            return View();
        }
    }
}

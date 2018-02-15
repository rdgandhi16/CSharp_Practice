using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_ALL_Cntrl_DB.Models;

namespace MVC_ALL_Cntrl_DB.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        db_mvc_vishEntities dc = new db_mvc_vishEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            ViewBag.state = new SelectList(dc.tbl_state, "statename", "statename");
            ViewBag.sub = new SelectList(dc.tbl_subject, "subject", "subject");

            return View();

        }

        public ActionResult pv_gender()
        {


            //for Radiobutton
            var model = new List<admin>();

            foreach (var item in dc.tbl_gender)
            {
                admin tr = new admin();
                tr.genname = item.gender;
                model.Add(tr);
            }


            return View(model);

        }
        public ActionResult pv_hobby()
        {


            //for Checkbox
            var model = new List<admin>();

            foreach (var item in dc.tbl_hobby)
            {
                admin tr = new admin();

                tr.hb = item.hobby;
                model.Add(tr);
            }


            return View(model);

        }
       
    }
}

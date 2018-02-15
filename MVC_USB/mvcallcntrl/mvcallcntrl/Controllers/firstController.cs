using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcallcntrl.Models;

namespace mvcallcntrl.Controllers
{
    public class firstController : Controller
    {
        db_28decEntities dc = new db_28decEntities();
        string filename, path, fulpath, str1;
        public ActionResult Index()
        {
            var p = new SelectList(new[] { "Gujrat", "Mh","Delhi" });
//            var list = new SelectList(new[] 
//            {
//                new { ID = "1", Name = "Gujrat" },
//                 new { ID = "2", Name = "MH" },
//                 new { ID = "3", Name = "Delhi" },
//            },
//                         "ID", "Name", 1);

            //            ViewBag.state = list;
                      ViewBag.state = p;

            return View();
        }
        [HttpPost]
        public ActionResult Index(first f,HttpPostedFileBase file1)
        {
            tbl_all tr = new tbl_all();
            tr.fname = f.fname;
            tr.pass = f.password;
            tr.gender = f.gender;

            string str = "";
            if (f.cric == true)
            {
                if (str == "")
                {
                    str = "Cricket";
                }
                else
                {
                    str = str + "," + "Cricket";
                }
            } 
            if (f.foot == true)
            {
                if (str == "")
                {
                    str = "Football";
                }
                else
                {
                    str = str + "," + "Football";
                }
            }
            if (f.Hockey == true)
            {
                if (str == "")
                {
                    str = "Hockey";
                }
                else
                {
                    str = str + "," + "Hockey";
                }
            }

            tr.hobby = str;
            tr.state = f.state;

            if (file1!=null)
            {
                filename = file1.FileName;
                path = Server.MapPath("~/img/");
                fulpath = path + "\\" + filename;

                file1.SaveAs(fulpath);
                str1 = "~/img/" + filename;
              
            }
            tr.img = str1;

            dc.tbl_all.Add(tr);
            dc.SaveChanges();
            var p = new SelectList(new[] { "Gujrat", "Mh", "Delhi" });
            ViewBag.state = p;

            return View();
        }
        [HttpGet]

        public ActionResult getdata()
        {
            var p = from n in dc.tbl_all select n;
            var model = new List<first>();
            foreach (var item in p)
            {
                first f = new first();
                f.id = item.id;
                f.fname = item.fname;
                f.password = item.pass;
                f.gender = item.gender;
                f.hobby = item.hobby;
                f.state = item.state;
                f.img = item.img;

                model.Add(f);
            }
            return View(model);
        }
    }
}

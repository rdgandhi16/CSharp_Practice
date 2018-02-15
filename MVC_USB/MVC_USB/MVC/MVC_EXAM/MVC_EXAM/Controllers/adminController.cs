using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_EXAM.Models;

namespace MVC_EXAM.Controllers
{
    public class adminController : Controller
    {
        //
        // GET: /admin/

        db_rinkal_examEntities dc = new db_rinkal_examEntities();
        [HttpGet]
        public ActionResult addcat()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addcat(pclass f)
        {
            tbl_category tr = new tbl_category();
            tr.catid = f.catid;
            tr.catname = f.catname;

            dc.tbl_category.Add(tr);
            dc.SaveChanges();
            ViewBag.msg = "Insert Succesfully..";
            return View();
        }
        [HttpGet]
        public ActionResult displaycat()
        {
            var p = from n in dc.tbl_category select n;
            var model = new List<pclass>();
            foreach (var item in p)
            {
                pclass f = new pclass();
                f.catid = item.catid;
                f.catname = item.catname;

                model.Add(f);
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var p = (from n in dc.tbl_category where n.catid == id select n).FirstOrDefault();
           
            pclass f = new pclass();
            f.catid = p.catid;
            f.catname = p.catname;

            return View(f);
        }
        [HttpPost]
        public ActionResult Edit(int id,pclass f)
        {
            var p = (from n in dc.tbl_category where n.catid == id select n).FirstOrDefault();

            //p.catid = f.catid;
            p.catname=f.catname;

            dc.SaveChanges();
            return RedirectToAction("displaycat");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var p = (from n in dc.tbl_category where n.catid == id select n).FirstOrDefault();

            pclass f = new pclass();
            f.catid = p.catid;
            f.catname = p.catname;

            return View(f);
        }
        [HttpPost]
        public ActionResult Delete(int id, pclass f)
        {
            var p = (from n in dc.tbl_category where n.catid == id select n).FirstOrDefault();

           // p.catid = f.catid;
           //p.catname = f.catname;

            dc.tbl_category.Remove(p);
            dc.SaveChanges();
            return RedirectToAction("displaycat");
        }
       
    }
}

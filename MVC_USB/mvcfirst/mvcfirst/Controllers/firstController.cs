using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcfirst.Models;

namespace mvcfirst.Controllers
{

    public class firstController : Controller
    {
        db_28decEntities dc = new db_28decEntities();
        //
        // GET: /first/
        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(first f)
        {
            tbl_reg tr = new tbl_reg();
            tr.fname = f.fname;
            tr.lname = f.lname;

            dc.tbl_reg.Add(tr);
            dc.SaveChanges();
            ViewBag.msg = "Insert Successfully";

            return View();

        }

        [HttpGet]
        public ActionResult getdata()
        {
            var p = from n in dc.tbl_reg select n;

            var model = new List<first>();
            foreach (var item in p)
            {
                first f = new first();
                f.id = item.id;
                f.fname = item.fname;
                f.lname = item.lname;

                model.Add(f);
            }

            return View(model);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var p = (from n in dc.tbl_reg where n.id == id select n).FirstOrDefault();

            first f = new first();
            f.id = p.id;
            f.fname = p.fname;
            f.lname = p.lname;
            return View(f);

        }
        [HttpPost]
        public ActionResult Edit(int id, first f)
        {
            var p = (from n in dc.tbl_reg where n.id == id select n).FirstOrDefault();

            p.id = f.id;
            p.fname = f.fname;
            p.lname = f.lname;

            dc.SaveChanges();
            return RedirectToAction("getdata");

            
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var p = (from n in dc.tbl_reg where n.id == id select n).FirstOrDefault();

            first f = new first();
            f.id = p.id;
            f.fname = p.fname;
            f.lname = p.lname;
            return View(f);

        }
        [HttpPost]
        public ActionResult Delete(int id,first f)
        {
            var p = (from n in dc.tbl_reg where n.id == id select n).FirstOrDefault();
            dc.tbl_reg.Remove(p);
            dc.SaveChanges();
            return RedirectToAction("getdata");

        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var p = (from n in dc.tbl_reg where n.id == id select n).FirstOrDefault();

            first f = new first();
            f.id = p.id;
            f.fname = p.fname;
            f.lname = p.lname;
            return View(f);

        }
    }
}

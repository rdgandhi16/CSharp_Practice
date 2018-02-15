using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_EXAM.Models;

namespace MVC_EXAM.Controllers
{
    public class userController : Controller
    {
        //
        // GET: /user/
        db_rinkal_examEntities dc = new db_rinkal_examEntities();
        string filename, path, fulpath, temp;
        [HttpGet]
        public ActionResult addproduct()
        {
            ViewBag.cat = new SelectList(dc.tbl_category, "catid", "catname");
            return View();
        }
        [HttpPost]
        public ActionResult addproduct(pclass f, HttpPostedFileBase file1)
        {
            ViewBag.cat = new SelectList(dc.tbl_category, "catid", "catname");
            tbl_product pr = new tbl_product();
            pr.pname = f.pname;
            pr.pcategory = f.catid;
            pr.pprice = f.pprice;
            pr.pdetail = f.pdetail;
            if (file1 != null)
            {
                filename = file1.FileName;
                path = Server.MapPath("~/img/");
                fulpath = path + filename;
                file1.SaveAs(fulpath);
                temp = "~/img/" + filename;
            }
            else
            {
                temp = "";
            }
            pr.pimage = temp;
            dc.tbl_product.Add(pr);
            dc.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult viewproduct()
        {
            ViewBag.cat = new SelectList(dc.tbl_category, "catid", "catname");

            var p = from n in dc.tbl_product join m in dc.tbl_category on n.pcategory equals m.catid select new {n.pname,n.pdetail,n.pprice,n.pimage ,m.catname};
            var model = new List<pclass>();
            foreach (var item in p)
            {
                pclass f = new pclass();
                f.pname = item.pname;
                f.catname = item.catname;
                f.pprice = int.Parse(item.pprice.ToString());
                f.pdetail = item.pdetail;
                f.pimage = item.pimage;

                model.Add(f);
            }
            return View(model);
        }
    }
}

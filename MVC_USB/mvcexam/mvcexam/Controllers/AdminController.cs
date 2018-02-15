using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcexam.Models;

namespace mvcexam.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        krunalpractical100Entities dc = new krunalpractical100Entities();
        string filename, path, fullpath, temp;
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult addcat()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addcat(category ct)
        {
            tbl_category tr = new tbl_category();
            tr.cname = ct.cname;
            dc.tbl_category.Add(tr);
            dc.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult addprod()
        {
            ViewBag.cat = new SelectList(dc.tbl_category, "cid", "cname");
            return View();
        }
        [HttpPost]
        public ActionResult addprod(product pr,HttpPostedFileBase file1)
        {
            ViewBag.cat = new SelectList(dc.tbl_category, "cid", "cname");
          
            tbl_product tr = new tbl_product();
            tr.pname = pr.pname;
            tr.pcategory = pr.catid;
            tr.pprice = pr.pprice;
            tr.pdetails = pr.pdetails;
            if (file1 != null)
            {

                filename = file1.FileName;
                path = Server.MapPath("~/image/~");
                fullpath = path + "\\" + filename;
                file1.SaveAs(fullpath);
                temp = "~/image/" + filename;

            }
            else 
            {
                temp = "";
            }
            tr.pimg = temp;
            dc.tbl_product.Add(tr);
            dc.SaveChanges();
            return View();
        }

    }
}

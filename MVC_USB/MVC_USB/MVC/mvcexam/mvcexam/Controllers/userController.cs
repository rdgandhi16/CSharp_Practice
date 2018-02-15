using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcexam.Models;

namespace mvcexam.Controllers
{
    public class userController : Controller
    {
        //
        // GET: /user/
        krunalpractical100Entities dc = new krunalpractical100Entities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult viewprod()
        {
            ViewBag.cat = new SelectList(dc.tbl_category, "cid", "cname");
            return View();
        }
        [HttpGet]       
        public ActionResult viewproduct(int id)
        {
            var p = from n in dc.tbl_product where n.pcategory == id select n;
            var m=new List<product>();
            foreach (var item in p)
            {
                 product pr = new product();
                 pr.pname = item.pname;
                 pr.pimage = item.pimg;
               
                m.Add(pr);
            }
            return View(m);
            
        }

    }
}

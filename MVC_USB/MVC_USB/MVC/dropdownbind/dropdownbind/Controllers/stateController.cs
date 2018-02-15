using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dropdownbind.Controllers
{
    public class stateController : Controller
    {
        //
        // GET: /state/

        db_28decEntities dc = new db_28decEntities();

        public ActionResult Index()
        {
            ViewBag.state = new SelectList(dc.tbl_state, "id", "statename");
            return View();
        }
        public JsonResult citybyid(int id)
        {
            var p = from n in dc.tbl_city where n.sid == id select n;
            return Json(new SelectList(p.ToArray(), "cid", "cityname"), JsonRequestBehavior.AllowGet);
        }

    }
}

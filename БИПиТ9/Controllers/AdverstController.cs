using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace БИПиТ9.Controllers
{
    public class AdverstController : Controller
    {
        AdverstContext db = new AdverstContext();

        public ActionResult Client()
        {
            return View(db.Client.ToList());
        }
        public ActionResult Service()
        {
            return View(db.Service.ToList());
        }
        public ActionResult Order()
        {
            return View(db.OrderView.ToList());
        }

    }
}
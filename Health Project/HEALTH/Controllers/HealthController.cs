using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HEALTH.Controllers
{
    public class HealthController : Controller
    {
        HEALTHEntities db = new HEALTHEntities();
        // GET: Health
        public ActionResult Index()
        {
            return View();
        }

      

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HEALTH.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Records()
        {
            return View();
        }

        public ActionResult Information()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }
        public ActionResult GetRecords()
        {
            using (HEALTHEntities _db = new HEALTHEntities())
            {
                var records = (from d1 in _db.Records
                               select new
                               {
                                   Id = d1.Id,
                                   FirstName = d1.FirstName,
                                   LastName = d1.LastName,
                                   Age = d1.Age,
                                   Gender = d1.Gender,
                                   BloodGroup = d1.BloodGroup,
                                   EmailAdress = d1.EmailAdress,
                                   RecordDescription = d1.RecordDescription
                               }).ToList();
                return Json(new { data = records }, JsonRequestBehavior.AllowGet);
            }

        }
    }
}
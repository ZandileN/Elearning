using Elearning.Models.DAL.DAOImpl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Elearning.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            PolicyDAOImpl policy = new PolicyDAOImpl();
            ICollection<Policy> policyList = policy.FindAll();

            return View(policyList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Admin()
        {
            ViewBag.Message = "My Admin.";

            return View();
        }

        public ActionResult AddPolicy()
        {
            ViewBag.Message = "Awe admin.";

            return View();
        }
    }
}
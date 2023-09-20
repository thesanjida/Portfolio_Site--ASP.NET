using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio_Site.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Skills()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Educational()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Project()
        {
            return View();
        }
    }
}
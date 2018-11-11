using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HireMe.Models;

namespace HireMe.Controllers
{
    public class DemoCandidateController : Controller
    {
      
        public ActionResult DashBoard()
        {
            return View();
        }
        public ActionResult SearchJob()
        {
            return View();
        }
        public ActionResult ProfileCardOption()
        {
            return View();
        }

        public ActionResult PublishJob()
        {
            return View();
        }
        public ActionResult SC1()
        {
            return View();
        }
        public ActionResult SC2()
        {
            return View();
        }
        public ActionResult ManageFavo()
        {
            return View();
        }
    }
}

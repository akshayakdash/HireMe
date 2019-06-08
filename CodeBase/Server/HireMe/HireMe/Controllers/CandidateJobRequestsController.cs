using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HireMe.Controllers
{
    public class CandidateJobRequestsController : BaseController
    {
        // GET: CandidateJobRequests
        public ActionResult Index()
        {
            return View();
        }
    }
}
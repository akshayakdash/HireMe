using HireMe.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace HireMe
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<JobTask, JobTaskViewModel>();
                config.CreateMap<CandidateProfileViewModel, Candidate>();
                config.CreateMap<Candidate,CandidateProfileViewModel > ();
                config.CreateMap<EmployerJobOfferViewModel, JobOffer>();
                config.CreateMap<JobOffer, EmployerJobOfferViewModel>();
                config.CreateMap<RegisterCandidateViewModel, Candidate>();
            });
        }
        protected void Application_Error()
        {
            var ex = Server.GetLastError();
            //log the error!
            Logger log = LogManager.GetCurrentClassLogger();
            log.Error(ex);
            ;
        }
    }
}

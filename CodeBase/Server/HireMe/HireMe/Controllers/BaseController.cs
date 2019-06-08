using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace HireMe.Controllers
{
    public class BaseController : Controller
    {
        //protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        //{
        //    ////Localization in Base controller:

        //    //string language = (string)RouteData.Values["language"] ?? "fr-FR";
        //    //string culture = (string)RouteData.Values["culture"] ?? "fr-FR";

        //    //Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(string.Format("{0}-{1}", language, culture));
        //    //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(string.Format("{0}-{1}", language, culture));


        //    //return base.BeginExecuteCore(callback, state);
        //}
    }
}
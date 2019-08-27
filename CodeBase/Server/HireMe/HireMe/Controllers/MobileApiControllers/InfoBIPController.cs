using OneApi.Client.Impl;
using OneApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;
using HireMe.Models;
using Newtonsoft.Json;
using OneApi;

namespace HireMe.Controllers.MobileApiControllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class InfoBipController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private JsonMediaTypeFormatter jsonFormatter = GlobalConfiguration.Configuration.Formatters.JsonFormatter;

        public InfoBipController()
        {
            var jSettings = new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };

            jsonFormatter.SerializerSettings = jSettings;
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("api/InfoBip/SendPin/{contactNumber}")]
        public HttpResponseMessage SendPin(string contactNumber)
        {
            string result = string.Empty;
            try
            {
                OneApi.Config.Configuration configuration = new OneApi.Config.Configuration("Sharlee1", "Letmein1");
                SMSClient smsClient = new SMSClient(configuration);

                SMSRequest smsRequest = new SMSRequest("JobTek", "This is a test", "917504835326");
                smsRequest.Language = new Language(LanguageCode.Default);
                
                smsClient.SmsMessagingClient.SendSMSAsync(smsRequest, (sendMessageResult, e) =>
                {
                    if (e == null)
                    {
                        result = "Message sent successfully."; //sendMessageResult.ToString();
                    }
                    else
                    {
                        result = e.Message;
                    }
                });
            }
            catch (Exception exp)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Status = "ERROR", Message = exp.Message });
            }
            return Request.CreateResponse(HttpStatusCode.OK, new { Status = "SUCCESS", Message = result });

        }
        //[HttpPost]
        //[AllowAnonymous]
        //[Route("api/InfoBip/ResendPin")]
        //public HttpResponseMessage ResendPin(string contactNumber)
        //{
        //    OneApi.Config.Configuration configuration = new OneApi.Config.Configuration("Sharlee1", "Letmein1");
        //    SMSClient smsClient = new SMSClient(configuration);

        //    SMSRequest smsRequest = new SMSRequest("JobTek", "This is a test", "917504835326");
        //    smsRequest.Language = new Language(LanguageCode.Default);
        //    var sendMessageResult = smsClient.SmsMessagingClient.(smsRequest);
        //}
    }
}

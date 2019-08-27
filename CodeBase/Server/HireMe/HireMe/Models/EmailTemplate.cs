using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HireMe.Models
{
    public class EmailTemplate
    {
        public int Id { get; set; }
        public int EmailType { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
    }
}
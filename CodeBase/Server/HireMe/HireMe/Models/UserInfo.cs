using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HireMe.Models
{
    public class UserInfo
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
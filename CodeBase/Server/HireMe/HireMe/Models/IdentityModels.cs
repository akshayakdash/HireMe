﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System;

namespace HireMe.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public int Age { get; set; }
        public string Address { get; set; }

        public string ProfilePicUrl { get; set; }

        public DateTime? ActiveUntil { get; set; }

        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }

        public List<ApplicationUserSecurityQuestionAnswer> SecurityQuestionAnswers { get; set; }

        public List<Candidate> Candidates { get; set; }
        public List<Agency> Agencies { get; set; }
        public List<Employer> Employers { get; set; }

        //public List<ApplicationRole> Roles { get; set; }

        public List<SignalRUserConnection> SignalRConnections { get; set; }
        public List<JOBTekOtp> OTPList { get; set; }
    }

    //public class ApplicationRole : IdentityRole
    //{
    //}

   
}
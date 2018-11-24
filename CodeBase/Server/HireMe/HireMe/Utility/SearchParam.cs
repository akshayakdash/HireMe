using HireMe.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace HireMe.Utility
{


    public class JobRequestSearchParam
    {
        public Gender Gender { get; set; }
        public string Age { get; set; }
        public string MinAge { get; set; }
        public string MaxAge { get; set; }
        public StaffType StaffType { get; set; }
        public string YearsOfExperience { get; set; }


        ArrayList paramList = new ArrayList();
        int paramCount = 0;
        StringBuilder queryString = new StringBuilder();
        public object[] GetSearchQuery()
        {
            ArrayList paramList = new ArrayList();
            int paramCount = 0;
            StringBuilder queryString = new StringBuilder();
            if (Gender != null)
            {
                queryString.Append(" and Candidate.Gender = @" + paramCount);
                paramList.Add(Gender);
                paramCount++;
            }


            if (!string.IsNullOrWhiteSpace(Age))
            {
                queryString.Append(" and Candidate.Age = @" + paramCount);
                paramList.Add(int.Parse(Age));
                paramCount++;
            }

            if (StaffType != null && StaffType != default(StaffType))
            {
                queryString.Append(" and Candidate.StaffType = @" + paramCount);
                paramList.Add(StaffType);
                paramCount++;
            }

            if (!string.IsNullOrWhiteSpace(YearsOfExperience))
            {
                queryString.Append(" and Candidate.YearsOfExperience = @" + YearsOfExperience);
                paramList.Add(YearsOfExperience);
                paramCount++;
            }

            queryString.Append(" and IsPublished =@" + paramCount);
            paramList.Add(true);
            paramCount++;


            //Create the array
            object[] queryObject = new object[2];
            if (queryString.Length == 0)
            {
                queryObject = null;
            }
            else
            {
                //Remove the first 5 characters
                queryObject[0] = queryString.ToString().Substring(5);
                queryObject[1] = paramList;
            }
            return queryObject;
        }

    }

    public class MemberSearchParam
    {
        public MemberType MemberType { get; set; }
        public Gender Gender { get; set; }
        public int Job { get; set; }
        public bool VerificationStatus { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
    }

    public enum MemberType
    {
        Candidate = 1,
        Employer = 2
    }


}
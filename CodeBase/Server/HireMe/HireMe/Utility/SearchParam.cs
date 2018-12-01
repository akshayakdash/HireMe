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
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public StaffType StaffType { get; set; }
        public string YearsOfExperience { get; set; }


        public int Job { get; set; }
        public bool ProfileVerified { get; set; }
        public int MinYearsOfExperience { get; set; }
        public int MaxYearsOfExperience { get; set; }
        public DateTime? Disponibility { get; set; }
        public int City { get; set; }
        public int Country { get; set; }
        public int District { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public List<int> Tasks { get; set; }

        public bool EnableProfileVerifiedFilter { get; set; }
        public bool EnableAgeFilter { get; set; }
        public bool EnableExperienceFilter { get; set; }
        public bool EnableDisponibilityFilter { get; set; }
        public bool EnableLocalizationFilter { get; set; }
        public bool EnableSalaryFilter { get; set; }


        ArrayList paramList = new ArrayList();
        int paramCount = 0;
        StringBuilder queryString = new StringBuilder();
        public object[] GetSearchQuery()
        {
            ArrayList paramList = new ArrayList();
            int paramCount = 0;
            StringBuilder queryString = new StringBuilder();
            if (Gender != null && Gender != default(Gender))
            {
                queryString.Append(" and Candidate.Gender = @" + paramCount);
                paramList.Add(Gender);
                paramCount++;
            }

            if (Job != 0)
            {
                queryString.Append(" and Job.JobId = @" + paramCount);
                paramList.Add(Job);
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

            //if (!string.IsNullOrWhiteSpace(YearsOfExperience))
            //{
            //    queryString.Append(" and Candidate.YearsOfExperience = @" + YearsOfExperience);
            //    paramList.Add(YearsOfExperience);
            //    paramCount++;
            //}

            if (EnableProfileVerifiedFilter)
            {
                queryString.Append(" and Candidate.ProfileVerified= @" + paramCount);
                paramList.Add(ProfileVerified);
                paramCount++;
            }

            if (EnableAgeFilter)
            {
                if (MinAge > 0 && MaxAge > 0 && MinAge <= MaxAge)
                {
                    queryString.Append(" and Candidate.Age >= @" + paramCount);
                    paramList.Add(MinAge);
                    paramCount++;

                    queryString.Append(" and Candidate.Age <= @" + paramCount);
                    paramList.Add(MaxAge);
                    paramCount++;
                }
            }

            if (EnableExperienceFilter)
            {
                if (MinYearsOfExperience > 0 && MaxYearsOfExperience > 0 && MinYearsOfExperience <= MaxYearsOfExperience)
                {
                    queryString.Append(" and Candidate.ExperienceInYears >= @" + paramCount);
                    paramList.Add(MinYearsOfExperience);
                    paramCount++;

                    queryString.Append(" and Candidate.ExperienceInYears <= @" + paramCount);
                    paramList.Add(MaxYearsOfExperience);
                    paramCount++;
                }
            }

            if (EnableDisponibilityFilter)
            {
                if (Disponibility.HasValue)
                {
                    queryString.Append(" and Candidate.Disponibility.Date = @" + paramCount);
                    paramList.Add(Disponibility.Value.Date);
                    paramCount++;
                }
            }

            if (EnableLocalizationFilter)
            {
                if (City > 0)
                {
                    queryString.Append(" and Candidate.CityId = @" + paramCount);
                    paramList.Add(City);
                    paramCount++;
                }
                if (District > 0)
                {
                    queryString.Append(" and Candidate.DistrictId = @" + paramCount);
                    paramList.Add(District);
                    paramCount++;
                }
                if (Country > 0)
                {
                    queryString.Append(" and Candidate.CountryId = @" + paramCount);
                    paramList.Add(Country);
                    paramCount++;
                }
            }

            if (EnableSalaryFilter)
            {
                if (MinSalary > 0 && MaxSalary > 0 && MinSalary <= MaxSalary)
                {
                    queryString.Append(" and Candidate.ExpectedMinSalary >= @" + paramCount);
                    paramList.Add(MinSalary);
                    paramCount++;

                    queryString.Append(" and Candidate.ExpectedMinSalary <= @" + paramCount);
                    paramList.Add(MaxSalary);
                    paramCount++;
                }
            }

            #region filter by jobTasks
            //if (Tasks != null && Tasks.Count != 0)
            //{
            //    if (Tasks.Count == 1)
            //    {
            //        queryString.Append(" and JobRequestJobTasks.JobTaskId = @" + paramCount);
            //        paramList.Add(Tasks.ElementAt(0));
            //        paramCount++;
            //    }
            //    else
            //    {
            //        queryString.Append(" and (");
            //        for (int i = 0; i < Tasks.Count; i++)
            //        {
            //            if (i == Tasks.Count - 1)
            //            {
            //                queryString.Append("JobRequestJobTasks.JobTaskId = @" + paramCount);
            //            }
            //            else
            //            {
            //                queryString.Append("JobRequestJobTasks.JobTaskId = @" + paramCount + "||");
            //            }
            //            paramList.Add(Tasks.ElementAt(i));
            //            paramCount++;
            //        }
            //        queryString.Append(")");
            //    }

            //}
            // queryString.Append(" @"+paramCount + ".Contains(" + JobRequestJobTasks.JobTaskId + ")", Tasks);
            //if (Tasks != null && Tasks.Count != 0)
            //{
            //    queryString.Append(" and JobRequestJobTasks.Select(JobTaskId).Any(value => @" + paramCount + ".Contains(value))");
            //    paramList.Add(Tasks);
            //    paramCount++;
            //}

            #endregion

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
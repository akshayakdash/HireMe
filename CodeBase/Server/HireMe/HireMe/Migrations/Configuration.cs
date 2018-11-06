namespace HireMe.Migrations
{
    using HireMe.Models;
    using HireMe.Utility;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HireMe.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySqlMigrationGenerator());
        }

        protected override void Seed(HireMe.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.SecurityQuestions.AddOrUpdate(
                p => p.Question,
                    new Models.SecurityQuestion { Question = "What is your favourite movie ?" },
                    new Models.SecurityQuestion { Question = "What is your favourite food ?" }
            );

            context.JobCategories.AddOrUpdate(
                p => p.CategoryName,
                new Models.JobCategory
                {
                    CategoryName = "Home Job",
                    IconImage = "/assets/images/home-icon.png",
                    Description = "",
                    Jobs = new System.Collections.Generic.List<Models.Job> {
                        new Models.Job{ JobName = "Nanny", JobGroup = "Internal Home Job", JobTasks = new System.Collections.Generic.List<Models.JobTask>{
                            new Models.JobTask{JobTaskName = "Cleaning",TaskParamType = Models.ParamType.CheckBox},
                            new Models.JobTask{JobTaskName = "Cooking", TaskParamType = Models.ParamType.CheckBox
                                //SubTasks = new List<Models.JobTask> {
                                //    new Models.JobTask{ JobTaskName = "African Food", TaskParamType = Models.ParamType.CheckBox,
                                //        SubTasks = new List<JobTask>{
                                //            new JobTask{JobTaskName = "Sauces", TaskParamType = ParamType.CheckBox},
                                //            new JobTask{ JobTaskName = "Grill", TaskParamType = ParamType.CheckBox}
                                //        } },
                                //    new JobTask{ JobTaskName = "European Food", TaskParamType = ParamType.CheckBox,
                                //        SubTasks = new List<JobTask>{
                                //            new JobTask{JobTaskName = "Oven Food", TaskParamType = ParamType.CheckBox},
                                //            new JobTask{JobTaskName = "Dessert", TaskParamType = ParamType.CheckBox}
                                //        }
                                //    }
                                //} }
                            }
                        }
                        },

                        new Models.Job{ JobName = "Cook", JobGroup = "Internal Home Job",JobTasks = new System.Collections.Generic.List<Models.JobTask>{

                        } },

                        new Models.Job{ JobName = "Guardian", JobGroup = "External Home Job",JobTasks = new System.Collections.Generic.List<Models.JobTask>{

                        } }
                    }
                },

                new Models.JobCategory
                {
                    CategoryName = "Troubleshooting",
                    IconImage = "/assets/images/settings-icon.png",
                    Jobs = new System.Collections.Generic.List<Models.Job> {
                    new Models.Job{ JobName = "Plumber"},

                    new Models.Job{ JobName = "Electrician"}
                }
                },
                
                new Models.JobCategory
                {
                    CategoryName = "HairStyle/Care",
                    IconImage = "/assets/images/salon-icon.png",
                    Jobs = new List<Job> {
                        new Job{ JobName = "Hair Dresser"},
                        new Job{ JobName = "Manicure/Pedicure/Massage"}
                    }

                },
                 new Models.JobCategory
                 {
                     CategoryName = "Ceremony Organization",
                     IconImage = "/assets/images/ceremony-icon.png",
                     Jobs = new List<Job> {
                        new Job{ JobName = "Server/Caterer"},
                        new Job{ JobName = "Decorator"}
                    }

                 },
                 new Models.JobCategory
                 {
                     CategoryName = "Course",
                     IconImage = "/assets/images/course-icon.png",
                     Jobs = new List<Job> {
                        new Job{ JobName = "School Support"},
                        new Job{ JobName = "Music Course"}
                    }

                 }
            );
        }
    }
}

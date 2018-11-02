namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class job_category_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JobCategories",
                c => new
                    {
                        JobCategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(unicode: false),
                        Description = c.String(unicode: false),
                        JobGroupName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.JobCategoryId);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        JobId = c.Int(nullable: false, identity: true),
                        JobName = c.String(unicode: false),
                        JobCategoryId = c.Int(nullable: false),
                        JobDesc = c.String(unicode: false),
                        IconImage = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.JobId)
                .ForeignKey("dbo.JobCategories", t => t.JobCategoryId, cascadeDelete: true)
                .Index(t => t.JobCategoryId);
            
            CreateTable(
                "dbo.JobTasks",
                c => new
                    {
                        JobTaskId = c.Int(nullable: false, identity: true),
                        JobId = c.Int(nullable: false),
                        JobTaskName = c.String(unicode: false),
                        JobTaskDescription = c.String(unicode: false),
                        TaskSectionName = c.String(unicode: false),
                        TaskGroupName = c.String(unicode: false),
                        TaskParamType = c.Int(nullable: false),
                        TaskParamValueType = c.Int(nullable: false),
                        ParamAvailableOptions = c.String(unicode: false),
                        ParentJobTaskId = c.Int(),
                    })
                .PrimaryKey(t => t.JobTaskId)
                .ForeignKey("dbo.JobTasks", t => t.ParentJobTaskId)
                .ForeignKey("dbo.Jobs", t => t.JobId, cascadeDelete: true)
                .Index(t => t.JobId)
                .Index(t => t.ParentJobTaskId);
            
            CreateTable(
                "dbo.CountryJobTaskMappers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobTaskId = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JobTasks", t => t.JobTaskId, cascadeDelete: true)
                .Index(t => t.JobTaskId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "JobCategoryId", "dbo.JobCategories");
            DropForeignKey("dbo.JobTasks", "JobId", "dbo.Jobs");
            DropForeignKey("dbo.JobTasks", "ParentJobTaskId", "dbo.JobTasks");
            DropForeignKey("dbo.CountryJobTaskMappers", "JobTaskId", "dbo.JobTasks");
            DropIndex("dbo.CountryJobTaskMappers", new[] { "JobTaskId" });
            DropIndex("dbo.JobTasks", new[] { "ParentJobTaskId" });
            DropIndex("dbo.JobTasks", new[] { "JobId" });
            DropIndex("dbo.Jobs", new[] { "JobCategoryId" });
            DropTable("dbo.CountryJobTaskMappers");
            DropTable("dbo.JobTasks");
            DropTable("dbo.Jobs");
            DropTable("dbo.JobCategories");
        }
    }
}

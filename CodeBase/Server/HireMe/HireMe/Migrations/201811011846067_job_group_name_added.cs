namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class job_group_name_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "JobGroup", c => c.String(unicode: false));
            DropColumn("dbo.JobCategories", "JobGroupName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.JobCategories", "JobGroupName", c => c.String(unicode: false));
            DropColumn("dbo.Jobs", "JobGroup");
        }
    }
}

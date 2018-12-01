namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Job_Task_Image_Icon_Added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobTasks", "IconImage", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.JobTasks", "IconImage");
        }
    }
}

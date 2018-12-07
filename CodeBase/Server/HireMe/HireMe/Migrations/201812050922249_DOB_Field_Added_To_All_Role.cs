namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DOB_Field_Added_To_All_Role : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Agencies", "ManagerDOB", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.Candidates", "DOB", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.Employers", "DOB", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.JobTekNotifications", "Subject", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.JobTekNotifications", "Subject");
            DropColumn("dbo.Employers", "DOB");
            DropColumn("dbo.Candidates", "DOB");
            DropColumn("dbo.Agencies", "ManagerDOB");
        }
    }
}

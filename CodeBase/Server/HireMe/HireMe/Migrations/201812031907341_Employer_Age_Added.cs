namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Employer_Age_Added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employers", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employers", "Age");
        }
    }
}

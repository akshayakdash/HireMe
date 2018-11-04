namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Min_Age_Column_Added_To_Job_Offer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobOffers", "MinAge", c => c.Int(nullable: false));
            AddColumn("dbo.JobOffers", "MaxAge", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.JobOffers", "MaxAge");
            DropColumn("dbo.JobOffers", "MinAge");
        }
    }
}

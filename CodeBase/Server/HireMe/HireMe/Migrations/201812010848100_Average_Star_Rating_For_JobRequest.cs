namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Average_Star_Rating_For_JobRequest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobRequests", "StarRating", c => c.Int(nullable: false));
            AddColumn("dbo.JobOffers", "StarRating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.JobOffers", "StarRating");
            DropColumn("dbo.JobRequests", "StarRating");
        }
    }
}

namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Job_Offer_new_column_added : DbMigration
    {
        public override void Up()
        {
         
            AddColumn("dbo.JobOffers", "IsPublished", c => c.Boolean(nullable: false));
            AddColumn("dbo.Employers", "ApplicationUser_Id", c => c.String(maxLength: 128, storeType: "nvarchar"));
            CreateIndex("dbo.Employers", "ApplicationUser_Id");
            AddForeignKey("dbo.Employers", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employers", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Employers", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Employers", "ApplicationUser_Id");
            DropColumn("dbo.JobOffers", "IsPublished");
          
        }
    }
}

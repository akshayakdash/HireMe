namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Country_City_And_District_Added_To_Application_User : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CountryId", c => c.Int());
            AddColumn("dbo.AspNetUsers", "CityId", c => c.Int());
            AddColumn("dbo.AspNetUsers", "DistrictId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "DistrictId");
            DropColumn("dbo.AspNetUsers", "CityId");
            DropColumn("dbo.AspNetUsers", "CountryId");
        }
    }
}

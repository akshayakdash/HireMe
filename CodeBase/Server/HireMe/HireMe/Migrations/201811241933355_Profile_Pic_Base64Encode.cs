namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Profile_Pic_Base64Encode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employers", "IdProofDoc", c => c.String(unicode: false));
            AddColumn("dbo.Employers", "IdProofDocDesc", c => c.String(unicode: false));
            AddColumn("dbo.Employers", "ProfilePicUrl", c => c.String(unicode: false));
            AlterColumn("dbo.Employers", "CountryId", c => c.Int());
            AlterColumn("dbo.Employers", "CityId", c => c.Int());
            AlterColumn("dbo.Employers", "DistrictId", c => c.Int());
            CreateIndex("dbo.Agencies", "CountryId");
            CreateIndex("dbo.Agencies", "CityId");
            CreateIndex("dbo.Agencies", "DistrictId");
            CreateIndex("dbo.Candidates", "CountryId");
            CreateIndex("dbo.Candidates", "CityId");
            CreateIndex("dbo.Candidates", "DistrictId");
            CreateIndex("dbo.Employers", "CountryId");
            CreateIndex("dbo.Employers", "CityId");
            CreateIndex("dbo.Employers", "DistrictId");
            AddForeignKey("dbo.Employers", "AspNetUserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Employers", "CityId", "dbo.Cities", "CityId");
            AddForeignKey("dbo.Employers", "CountryId", "dbo.Countries", "CountryId");
            AddForeignKey("dbo.Employers", "DistrictId", "dbo.Districts", "DistrictId");
            AddForeignKey("dbo.Candidates", "AspNetUserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Candidates", "CityId", "dbo.Cities", "CityId");
            AddForeignKey("dbo.Candidates", "CountryId", "dbo.Countries", "CountryId");
            AddForeignKey("dbo.Candidates", "DistrictId", "dbo.Districts", "DistrictId");
            AddForeignKey("dbo.Agencies", "CityId", "dbo.Cities", "CityId");
            AddForeignKey("dbo.Agencies", "CountryId", "dbo.Countries", "CountryId");
            AddForeignKey("dbo.Agencies", "DistrictId", "dbo.Districts", "DistrictId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Agencies", "DistrictId", "dbo.Districts");
            DropForeignKey("dbo.Agencies", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Agencies", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Candidates", "DistrictId", "dbo.Districts");
            DropForeignKey("dbo.Candidates", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Candidates", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Candidates", "AspNetUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Employers", "DistrictId", "dbo.Districts");
            DropForeignKey("dbo.Employers", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Employers", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Employers", "AspNetUserId", "dbo.AspNetUsers");
            DropIndex("dbo.Employers", new[] { "DistrictId" });
            DropIndex("dbo.Employers", new[] { "CityId" });
            DropIndex("dbo.Employers", new[] { "CountryId" });
            DropIndex("dbo.Candidates", new[] { "DistrictId" });
            DropIndex("dbo.Candidates", new[] { "CityId" });
            DropIndex("dbo.Candidates", new[] { "CountryId" });
            DropIndex("dbo.Agencies", new[] { "DistrictId" });
            DropIndex("dbo.Agencies", new[] { "CityId" });
            DropIndex("dbo.Agencies", new[] { "CountryId" });
            AlterColumn("dbo.Employers", "DistrictId", c => c.Int(nullable: false));
            AlterColumn("dbo.Employers", "CityId", c => c.Int(nullable: false));
            AlterColumn("dbo.Employers", "CountryId", c => c.Int(nullable: false));
            DropColumn("dbo.Employers", "ProfilePicUrl");
            DropColumn("dbo.Employers", "IdProofDocDesc");
            DropColumn("dbo.Employers", "IdProofDoc");
        }
    }
}

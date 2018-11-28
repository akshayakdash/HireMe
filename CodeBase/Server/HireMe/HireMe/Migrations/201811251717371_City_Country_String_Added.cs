namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class City_Country_String_Added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JobRequestNotes",
                c => new
                    {
                        JobRequestNoteId = c.Int(nullable: false, identity: true),
                        JobRequestId = c.Int(nullable: false),
                        Note = c.String(unicode: false),
                        StarRating = c.Int(nullable: false),
                        EmployerId = c.Int(nullable: false),
                        CreatedBy = c.String(unicode: false),
                        CreatedDate = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.JobRequestNoteId)
                .ForeignKey("dbo.JobRequests", t => t.JobRequestId, cascadeDelete: true)
                .Index(t => t.JobRequestId);
            
            AddColumn("dbo.Agencies", "Country", c => c.String(unicode: false));
            AddColumn("dbo.Agencies", "City", c => c.String(unicode: false));
            AddColumn("dbo.Agencies", "District", c => c.String(unicode: false));
            AddColumn("dbo.Candidates", "Country", c => c.String(unicode: false));
            AddColumn("dbo.Candidates", "City", c => c.String(unicode: false));
            AddColumn("dbo.Candidates", "District", c => c.String(unicode: false));
            AddColumn("dbo.JobOffers", "Country", c => c.String(unicode: false));
            AddColumn("dbo.JobOffers", "City", c => c.String(unicode: false));
            AddColumn("dbo.JobOffers", "District", c => c.String(unicode: false));
            AddColumn("dbo.JobOffers", "VerifiedByAdmin", c => c.Boolean(nullable: false));
            AddColumn("dbo.JobOffers", "VerificationDate", c => c.DateTime(precision: 0));
            AddColumn("dbo.Employers", "Country", c => c.String(unicode: false));
            AddColumn("dbo.Employers", "City", c => c.String(unicode: false));
            AddColumn("dbo.Employers", "District", c => c.String(unicode: false));
            AddColumn("dbo.Employers", "IdProofDoc", c => c.String(unicode: false));
            AddColumn("dbo.Employers", "IdProofDocDesc", c => c.String(unicode: false));
            AddColumn("dbo.Employers", "ProfilePicUrl", c => c.String(unicode: false));
            AddColumn("dbo.JobRequests", "VerifiedByAdmin", c => c.Boolean(nullable: false));
            AddColumn("dbo.JobRequests", "VerificationDate", c => c.DateTime(precision: 0));
            AlterColumn("dbo.JobOffers", "CountryId", c => c.Int());
            AlterColumn("dbo.JobOffers", "CityId", c => c.Int());
            AlterColumn("dbo.JobOffers", "DistrictId", c => c.Int());
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
            DropForeignKey("dbo.JobRequestNotes", "JobRequestId", "dbo.JobRequests");
            DropForeignKey("dbo.Employers", "DistrictId", "dbo.Districts");
            DropForeignKey("dbo.Employers", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Employers", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Employers", "AspNetUserId", "dbo.AspNetUsers");
            DropIndex("dbo.JobRequestNotes", new[] { "JobRequestId" });
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
            AlterColumn("dbo.JobOffers", "DistrictId", c => c.Int(nullable: false));
            AlterColumn("dbo.JobOffers", "CityId", c => c.Int(nullable: false));
            AlterColumn("dbo.JobOffers", "CountryId", c => c.Int(nullable: false));
            DropColumn("dbo.JobRequests", "VerificationDate");
            DropColumn("dbo.JobRequests", "VerifiedByAdmin");
            DropColumn("dbo.Employers", "ProfilePicUrl");
            DropColumn("dbo.Employers", "IdProofDocDesc");
            DropColumn("dbo.Employers", "IdProofDoc");
            DropColumn("dbo.Employers", "District");
            DropColumn("dbo.Employers", "City");
            DropColumn("dbo.Employers", "Country");
            DropColumn("dbo.JobOffers", "VerificationDate");
            DropColumn("dbo.JobOffers", "VerifiedByAdmin");
            DropColumn("dbo.JobOffers", "District");
            DropColumn("dbo.JobOffers", "City");
            DropColumn("dbo.JobOffers", "Country");
            DropColumn("dbo.Candidates", "District");
            DropColumn("dbo.Candidates", "City");
            DropColumn("dbo.Candidates", "Country");
            DropColumn("dbo.Agencies", "District");
            DropColumn("dbo.Agencies", "City");
            DropColumn("dbo.Agencies", "Country");
            DropTable("dbo.JobRequestNotes");
        }
    }
}

namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agency_Details : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agencies",
                c => new
                    {
                        AgencyId = c.Int(nullable: false, identity: true),
                        AspNetUserId = c.String(unicode: false),
                        AgencyName = c.String(unicode: false),
                        AgencyLogo = c.String(unicode: false),
                        AgencyWebsiteURL = c.String(unicode: false),
                        ManagerFirstName = c.String(unicode: false),
                        ManagerLastName = c.String(unicode: false),
                        ManagerAge = c.String(unicode: false),
                        CompanyActivityDesc = c.String(unicode: false),
                        CountryId = c.Int(),
                        CityId = c.Int(),
                        DistrictId = c.Int(),
                        ProfileVerified = c.Boolean(nullable: false),
                        CreatedBy = c.String(unicode: false),
                        CreatedDate = c.String(unicode: false),
                        UpdatedBy = c.String(unicode: false),
                        UpdatedDate = c.String(unicode: false),
                        ApplicationUser_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.AgencyId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            AddColumn("dbo.Candidates", "FirstName", c => c.String(unicode: false));
            AddColumn("dbo.Candidates", "LastName", c => c.String(unicode: false));
            AddColumn("dbo.Candidates", "ContactNo", c => c.String(unicode: false));
            AddColumn("dbo.Candidates", "EmailId", c => c.String(unicode: false));
            AddColumn("dbo.Candidates", "Address", c => c.String(unicode: false));
            CreateIndex("dbo.Candidates", "AgencyId");
            AddForeignKey("dbo.Candidates", "AgencyId", "dbo.Agencies", "AgencyId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Agencies", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Candidates", "AgencyId", "dbo.Agencies");
            DropIndex("dbo.Candidates", new[] { "AgencyId" });
            DropIndex("dbo.Agencies", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Candidates", "Address");
            DropColumn("dbo.Candidates", "EmailId");
            DropColumn("dbo.Candidates", "ContactNo");
            DropColumn("dbo.Candidates", "LastName");
            DropColumn("dbo.Candidates", "FirstName");
            DropTable("dbo.Agencies");
        }
    }
}

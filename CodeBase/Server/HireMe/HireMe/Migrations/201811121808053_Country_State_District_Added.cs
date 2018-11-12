namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Country_State_District_Added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CountryId = c.Int(nullable: false),
                        CityName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        DistrictId = c.Int(nullable: false, identity: true),
                        CityId = c.Int(nullable: false),
                        DistrictName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.DistrictId)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        CountryName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.CountryJobMappers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryId = c.Int(nullable: false),
                        JobId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jobs", t => t.JobId, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId)
                .Index(t => t.JobId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CountryJobMappers", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.CountryJobMappers", "JobId", "dbo.Jobs");
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Districts", "CityId", "dbo.Cities");
            DropIndex("dbo.CountryJobMappers", new[] { "JobId" });
            DropIndex("dbo.CountryJobMappers", new[] { "CountryId" });
            DropIndex("dbo.Districts", new[] { "CityId" });
            DropIndex("dbo.Cities", new[] { "CountryId" });
            DropTable("dbo.CountryJobMappers");
            DropTable("dbo.Countries");
            DropTable("dbo.Districts");
            DropTable("dbo.Cities");
        }
    }
}

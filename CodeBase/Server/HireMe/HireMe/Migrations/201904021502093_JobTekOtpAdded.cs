namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JobTekOtpAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JOBTekOtps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AspNetUserId = c.String(maxLength: 128, storeType: "nvarchar"),
                        OTP = c.String(unicode: false),
                        UniqueCode = c.String(unicode: false),
                        Reason = c.String(unicode: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AspNetUserId)
                .Index(t => t.AspNetUserId);
            
            
        }
        
        public override void Down()
        {
            
            DropForeignKey("dbo.JOBTekOtps", "AspNetUserId", "dbo.AspNetUsers");
           
            DropIndex("dbo.JOBTekOtps", new[] { "AspNetUserId" });
       
            DropTable("dbo.JOBTekOtps");
        }
    }
}

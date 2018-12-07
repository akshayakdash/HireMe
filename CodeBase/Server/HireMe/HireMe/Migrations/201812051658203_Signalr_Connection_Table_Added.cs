namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Signalr_Connection_Table_Added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JobOfferNotes",
                c => new
                    {
                        JobOfferNoteId = c.Int(nullable: false, identity: true),
                        JobOfferId = c.Int(nullable: false),
                        Note = c.String(unicode: false),
                        StarRating = c.Int(nullable: false),
                        CandidateId = c.Int(nullable: false),
                        CreatedBy = c.String(unicode: false),
                        CreatedDate = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.JobOfferNoteId)
                .ForeignKey("dbo.JobOffers", t => t.JobOfferId, cascadeDelete: true)
                .Index(t => t.JobOfferId);
            
            CreateTable(
                "dbo.SignalRUserConnections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AspNetUserId = c.String(maxLength: 128, storeType: "nvarchar"),
                        ConnectionId = c.String(unicode: false),
                        UserAgent = c.String(unicode: false),
                        Connected = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AspNetUserId)
                .Index(t => t.AspNetUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SignalRUserConnections", "AspNetUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.JobOfferNotes", "JobOfferId", "dbo.JobOffers");
            DropIndex("dbo.SignalRUserConnections", new[] { "AspNetUserId" });
            DropIndex("dbo.JobOfferNotes", new[] { "JobOfferId" });
            DropTable("dbo.SignalRUserConnections");
            DropTable("dbo.JobOfferNotes");
        }
    }
}

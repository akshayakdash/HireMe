namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Notification_Entity_Added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JobTekNotifications",
                c => new
                    {
                        JobTekNotificationId = c.Int(nullable: false, identity: true),
                        Content = c.String(unicode: false),
                        SenderId = c.String(unicode: false),
                        ReceiverId = c.String(unicode: false),
                        Category = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        SeenByReceiver = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.JobTekNotificationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.JobTekNotifications");
        }
    }
}

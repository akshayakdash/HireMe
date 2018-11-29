namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class City_Country_String_Added1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employers", "EmailId", c => c.String(unicode: false));
            AddColumn("dbo.Employers", "ContactNo", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employers", "ContactNo");
            DropColumn("dbo.Employers", "EmailId");
        }
    }
}

namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Contact_Option_Consent_Field_Added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidates", "ContactOption", c => c.String(unicode: false));
            AddColumn("dbo.Employers", "ContactOption", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employers", "ContactOption");
            DropColumn("dbo.Candidates", "ContactOption");
        }
    }
}

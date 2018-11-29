namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Address_Field_Added_To_Employer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employers", "Address", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employers", "Address");
        }
    }
}

namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Id_proof_for_Agency : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Agencies", "IdProofDoc", c => c.String(unicode: false));
           
        }
        
        public override void Down()
        {
           
            DropColumn("dbo.Agencies", "IdProofDoc");
        }
    }
}

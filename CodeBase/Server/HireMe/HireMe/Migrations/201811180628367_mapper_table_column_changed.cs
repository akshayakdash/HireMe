namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mapper_table_column_changed : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.EmployerFavouriteJobRequest", name: "CandidateId", newName: "EmployerId");
            RenameIndex(table: "dbo.EmployerFavouriteJobRequest", name: "IX_CandidateId", newName: "IX_EmployerId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.EmployerFavouriteJobRequest", name: "IX_EmployerId", newName: "IX_CandidateId");
            RenameColumn(table: "dbo.EmployerFavouriteJobRequest", name: "EmployerId", newName: "CandidateId");
        }
    }
}

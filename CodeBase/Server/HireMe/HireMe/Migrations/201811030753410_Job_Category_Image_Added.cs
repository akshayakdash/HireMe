namespace HireMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Job_Category_Image_Added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobCategories", "IconImage", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.JobCategories", "IconImage");
        }
    }
}

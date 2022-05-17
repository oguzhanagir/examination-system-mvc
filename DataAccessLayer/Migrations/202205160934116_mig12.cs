namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig12 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sigmas", "Sigma_SigmaID", "dbo.Sigmas");
            DropIndex("dbo.Sigmas", new[] { "Sigma_SigmaID" });
            DropColumn("dbo.Sigmas", "Sigma_SigmaID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sigmas", "Sigma_SigmaID", c => c.Int());
            CreateIndex("dbo.Sigmas", "Sigma_SigmaID");
            AddForeignKey("dbo.Sigmas", "Sigma_SigmaID", "dbo.Sigmas", "SigmaID");
        }
    }
}

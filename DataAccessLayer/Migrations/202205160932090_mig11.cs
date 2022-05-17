namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig11 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sigmas", "QuestionID", "dbo.Questions");
            DropIndex("dbo.Sigmas", new[] { "QuestionID" });
            AddColumn("dbo.Questions", "SigmaID", c => c.Int(nullable: false));
            AddColumn("dbo.Sigmas", "Sigma_SigmaID", c => c.Int());
            CreateIndex("dbo.Questions", "SigmaID");
            CreateIndex("dbo.Sigmas", "Sigma_SigmaID");
            AddForeignKey("dbo.Sigmas", "Sigma_SigmaID", "dbo.Sigmas", "SigmaID");
            AddForeignKey("dbo.Questions", "SigmaID", "dbo.Sigmas", "SigmaID", cascadeDelete: true);
            DropColumn("dbo.Sigmas", "QuestionID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sigmas", "QuestionID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Questions", "SigmaID", "dbo.Sigmas");
            DropForeignKey("dbo.Sigmas", "Sigma_SigmaID", "dbo.Sigmas");
            DropIndex("dbo.Sigmas", new[] { "Sigma_SigmaID" });
            DropIndex("dbo.Questions", new[] { "SigmaID" });
            DropColumn("dbo.Sigmas", "Sigma_SigmaID");
            DropColumn("dbo.Questions", "SigmaID");
            CreateIndex("dbo.Sigmas", "QuestionID");
            AddForeignKey("dbo.Sigmas", "QuestionID", "dbo.Questions", "QuestionID", cascadeDelete: true);
        }
    }
}

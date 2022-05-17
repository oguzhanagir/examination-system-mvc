namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig10 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Questions", "SigmaID", "dbo.Sigmas");
            DropIndex("dbo.Questions", new[] { "SigmaID" });
            AddColumn("dbo.Sigmas", "QuestionID", c => c.Int(nullable: false));
            CreateIndex("dbo.Sigmas", "QuestionID");
            AddForeignKey("dbo.Sigmas", "QuestionID", "dbo.Questions", "QuestionID", cascadeDelete: true);
            DropColumn("dbo.Questions", "SigmaID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questions", "SigmaID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Sigmas", "QuestionID", "dbo.Questions");
            DropIndex("dbo.Sigmas", new[] { "QuestionID" });
            DropColumn("dbo.Sigmas", "QuestionID");
            CreateIndex("dbo.Questions", "SigmaID");
            AddForeignKey("dbo.Questions", "SigmaID", "dbo.Sigmas", "SigmaID", cascadeDelete: true);
        }
    }
}

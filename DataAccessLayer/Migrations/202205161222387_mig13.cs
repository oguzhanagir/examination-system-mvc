namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig13 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Questions", "SigmaID", "dbo.Sigmas");
            DropIndex("dbo.Questions", new[] { "SigmaID" });
            AddColumn("dbo.Sigmas", "UserID", c => c.Int(nullable: false));
            AddColumn("dbo.Sigmas", "QuestionID", c => c.Int(nullable: false));
            CreateIndex("dbo.Sigmas", "UserID");
            CreateIndex("dbo.Sigmas", "QuestionID");
            AddForeignKey("dbo.Sigmas", "QuestionID", "dbo.Questions", "QuestionID", cascadeDelete: true);
            AddForeignKey("dbo.Sigmas", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
            DropColumn("dbo.Questions", "SigmaID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questions", "SigmaID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Sigmas", "UserID", "dbo.Users");
            DropForeignKey("dbo.Sigmas", "QuestionID", "dbo.Questions");
            DropIndex("dbo.Sigmas", new[] { "QuestionID" });
            DropIndex("dbo.Sigmas", new[] { "UserID" });
            DropColumn("dbo.Sigmas", "QuestionID");
            DropColumn("dbo.Sigmas", "UserID");
            CreateIndex("dbo.Questions", "SigmaID");
            AddForeignKey("dbo.Questions", "SigmaID", "dbo.Sigmas", "SigmaID", cascadeDelete: true);
        }
    }
}

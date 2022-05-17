namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sigmas",
                c => new
                    {
                        SigmaID = c.Int(nullable: false, identity: true),
                        SigmaCheck1 = c.Boolean(nullable: false),
                        SigmaCheck2 = c.Boolean(nullable: false),
                        SigmaCheck3 = c.Boolean(nullable: false),
                        SigmaCheck4 = c.Boolean(nullable: false),
                        SigmaCheck5 = c.Boolean(nullable: false),
                        SigmaCheck6 = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SigmaID);
            
            AddColumn("dbo.Answers", "AnswerDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Questions", "SigmaID", c => c.Int(nullable: false));
            CreateIndex("dbo.Questions", "SigmaID");
            AddForeignKey("dbo.Questions", "SigmaID", "dbo.Sigmas", "SigmaID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "SigmaID", "dbo.Sigmas");
            DropIndex("dbo.Questions", new[] { "SigmaID" });
            DropColumn("dbo.Questions", "SigmaID");
            DropColumn("dbo.Answers", "AnswerDate");
            DropTable("dbo.Sigmas");
        }
    }
}

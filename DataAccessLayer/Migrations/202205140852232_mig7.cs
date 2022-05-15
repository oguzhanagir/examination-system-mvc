namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "AnswerID", c => c.Int(nullable: false));
            AlterColumn("dbo.Answers", "OptionA", c => c.String(maxLength: 500));
            AlterColumn("dbo.Answers", "OptionB", c => c.String(maxLength: 500));
            AlterColumn("dbo.Answers", "OptionC", c => c.String(maxLength: 500));
            AlterColumn("dbo.Answers", "OptionD", c => c.String(maxLength: 500));
            CreateIndex("dbo.Questions", "AnswerID");
            AddForeignKey("dbo.Questions", "AnswerID", "dbo.Answers", "AnswerID", cascadeDelete: true);
            DropColumn("dbo.Questions", "WrongAnswers");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questions", "WrongAnswers", c => c.String(maxLength: 500));
            DropForeignKey("dbo.Questions", "AnswerID", "dbo.Answers");
            DropIndex("dbo.Questions", new[] { "AnswerID" });
            AlterColumn("dbo.Answers", "OptionD", c => c.String());
            AlterColumn("dbo.Answers", "OptionC", c => c.String());
            AlterColumn("dbo.Answers", "OptionB", c => c.String());
            AlterColumn("dbo.Answers", "OptionA", c => c.String());
            DropColumn("dbo.Questions", "AnswerID");
        }
    }
}

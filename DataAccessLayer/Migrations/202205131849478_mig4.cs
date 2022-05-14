namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "RightAnswer", c => c.String(maxLength: 500));
            AddColumn("dbo.Questions", "WrongAnswers", c => c.String(maxLength: 500));
            AlterColumn("dbo.Questions", "CodeNo", c => c.String(maxLength: 10));
            AlterColumn("dbo.Questions", "QuestionText", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Questions", "QuestionText", c => c.String(maxLength: 600));
            AlterColumn("dbo.Questions", "CodeNo", c => c.String());
            DropColumn("dbo.Questions", "WrongAnswers");
            DropColumn("dbo.Questions", "RightAnswer");
        }
    }
}

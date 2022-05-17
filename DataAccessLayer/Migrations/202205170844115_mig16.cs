namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig16 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Answers", "RightAnswer", c => c.String(maxLength: 10));
            AlterColumn("dbo.Sigmas", "UserAnswer", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sigmas", "UserAnswer", c => c.String());
            DropColumn("dbo.Answers", "RightAnswer");
        }
    }
}

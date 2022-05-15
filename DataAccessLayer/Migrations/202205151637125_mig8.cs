namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig8 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Questions", "RightAnswer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questions", "RightAnswer", c => c.String(maxLength: 500));
        }
    }
}

namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig20 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Questions", "SubjectName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questions", "SubjectName", c => c.String(maxLength: 50));
        }
    }
}

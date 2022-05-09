namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Questions", "CodeNo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Questions", "CodeNo", c => c.Int(nullable: false));
        }
    }
}

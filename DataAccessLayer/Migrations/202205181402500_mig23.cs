namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig23 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Sigmas", "RightAnswerDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sigmas", "RightAnswerDate", c => c.DateTime(nullable: false));
        }
    }
}

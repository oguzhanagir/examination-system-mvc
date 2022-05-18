namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig22 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sigmas", "RightAnswerDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sigmas", "RightAnswerDate", c => c.DateTime(nullable: false));
        }
    }
}

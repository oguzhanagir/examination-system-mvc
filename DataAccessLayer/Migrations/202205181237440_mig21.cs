namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sigmas", "RightAnswerDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Sigmas", "SigmaCheck", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sigmas", "SigmaCheck");
            DropColumn("dbo.Sigmas", "RightAnswerDate");
        }
    }
}

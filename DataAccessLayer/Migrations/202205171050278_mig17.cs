namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig17 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sigmas", "SigmaCount", c => c.Boolean(nullable: false));
            DropColumn("dbo.Sigmas", "SigmaCheck1");
            DropColumn("dbo.Sigmas", "SigmaCheck2");
            DropColumn("dbo.Sigmas", "SigmaCheck3");
            DropColumn("dbo.Sigmas", "SigmaCheck4");
            DropColumn("dbo.Sigmas", "SigmaCheck5");
            DropColumn("dbo.Sigmas", "SigmaCheck6");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sigmas", "SigmaCheck6", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sigmas", "SigmaCheck5", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sigmas", "SigmaCheck4", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sigmas", "SigmaCheck3", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sigmas", "SigmaCheck2", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sigmas", "SigmaCheck1", c => c.Boolean(nullable: false));
            DropColumn("dbo.Sigmas", "SigmaCount");
        }
    }
}

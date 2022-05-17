namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig18 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sigmas", "SigmaCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sigmas", "SigmaCount", c => c.Boolean(nullable: false));
        }
    }
}

namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig19 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Questions", "UnitName");
            DropColumn("dbo.Questions", "SubjectNo");
            DropColumn("dbo.Questions", "PicturePath");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questions", "PicturePath", c => c.String(maxLength: 200));
            AddColumn("dbo.Questions", "SubjectNo", c => c.Int(nullable: false));
            AddColumn("dbo.Questions", "UnitName", c => c.String(maxLength: 50));
        }
    }
}

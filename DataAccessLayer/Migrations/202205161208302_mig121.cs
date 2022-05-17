﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig121 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Answers", "AnswerDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Answers", "AnswerDate", c => c.DateTime(nullable: false));
        }
    }
}

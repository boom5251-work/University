namespace University.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update9 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Posts", new[] { "Name" });
            AlterColumn("dbo.Posts", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Posts", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Posts", new[] { "Name" });
            AlterColumn("dbo.Posts", "Name", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Posts", "Name", unique: true);
        }
    }
}

namespace University.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "LatPath", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Faculties", "LatPath", c => c.String(nullable: false, maxLength: 20));
            CreateIndex("dbo.Departments", "LatPath", unique: true);
            CreateIndex("dbo.Faculties", "LatPath", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Faculties", new[] { "LatPath" });
            DropIndex("dbo.Departments", new[] { "LatPath" });
            AlterColumn("dbo.Faculties", "LatPath", c => c.String(nullable: false));
            DropColumn("dbo.Departments", "LatPath");
        }
    }
}

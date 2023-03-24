namespace University.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Faculties", "LatPath", c => c.String(nullable: false));
            AddColumn("dbo.Faculties", "ArgbColor", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Faculties", "ArgbColor");
            DropColumn("dbo.Faculties", "LatPath");
        }
    }
}

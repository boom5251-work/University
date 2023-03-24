namespace University.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update6 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.EducatorRole", newName: "EducatorsRoles");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.EducatorsRoles", newName: "EducatorRole");
        }
    }
}

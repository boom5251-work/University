namespace University.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Educators", "PhotoFileName", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Educators", "PhotoFileName");
        }
    }
}

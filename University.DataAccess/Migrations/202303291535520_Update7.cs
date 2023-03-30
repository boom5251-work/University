namespace University.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Headlines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PublishedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Title = c.String(nullable: false),
                        Text = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Headlines");
        }
    }
}

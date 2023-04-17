namespace University.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FacultiesHeads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FacultyId = c.Int(nullable: false),
                        HeadId = c.Int(nullable: false),
                        PostId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faculties", t => t.FacultyId, cascadeDelete: true)
                .ForeignKey("dbo.Educators", t => t.HeadId, cascadeDelete: true)
                .ForeignKey("dbo.Posts", t => t.PostId, cascadeDelete: true)
                .Index(t => t.FacultyId)
                .Index(t => t.HeadId)
                .Index(t => t.PostId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Code = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true)
                .Index(t => t.Code, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FacultiesHeads", "PostId", "dbo.Posts");
            DropForeignKey("dbo.FacultiesHeads", "HeadId", "dbo.Educators");
            DropForeignKey("dbo.FacultiesHeads", "FacultyId", "dbo.Faculties");
            DropIndex("dbo.Posts", new[] { "Code" });
            DropIndex("dbo.Posts", new[] { "Name" });
            DropIndex("dbo.FacultiesHeads", new[] { "PostId" });
            DropIndex("dbo.FacultiesHeads", new[] { "HeadId" });
            DropIndex("dbo.FacultiesHeads", new[] { "FacultyId" });
            DropTable("dbo.Posts");
            DropTable("dbo.FacultiesHeads");
        }
    }
}

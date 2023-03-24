namespace University.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EducatorRole",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EducatorId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Educators", t => t.EducatorId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.EducatorId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Code = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentsRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentsRoles", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentsRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.EducatorRole", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.EducatorRole", "EducatorId", "dbo.Educators");
            DropIndex("dbo.StudentsRoles", new[] { "RoleId" });
            DropIndex("dbo.StudentsRoles", new[] { "StudentId" });
            DropIndex("dbo.EducatorRole", new[] { "RoleId" });
            DropIndex("dbo.EducatorRole", new[] { "EducatorId" });
            DropTable("dbo.StudentsRoles");
            DropTable("dbo.Roles");
            DropTable("dbo.EducatorRole");
        }
    }
}

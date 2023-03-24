namespace University.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        FacultyId = c.Int(nullable: false),
                        HeadId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faculties", t => t.FacultyId, cascadeDelete: true)
                .ForeignKey("dbo.Educators", t => t.HeadId, cascadeDelete: true)
                .Index(t => t.Name, unique: true)
                .Index(t => t.FacultyId)
                .Index(t => t.HeadId);
            
            CreateTable(
                "dbo.DepartmentsFields",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(nullable: false),
                        FieldOfStudyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.FieldsOfStudy", t => t.FieldOfStudyId, cascadeDelete: true)
                .Index(t => t.DepartmentId)
                .Index(t => t.FieldOfStudyId);
            
            AlterColumn("dbo.Subjects", "Name", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.Groups", "Name", unique: true);
            CreateIndex("dbo.Subjects", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DepartmentsFields", "FieldOfStudyId", "dbo.FieldsOfStudy");
            DropForeignKey("dbo.DepartmentsFields", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Departments", "HeadId", "dbo.Educators");
            DropForeignKey("dbo.Departments", "FacultyId", "dbo.Faculties");
            DropIndex("dbo.Subjects", new[] { "Name" });
            DropIndex("dbo.DepartmentsFields", new[] { "FieldOfStudyId" });
            DropIndex("dbo.DepartmentsFields", new[] { "DepartmentId" });
            DropIndex("dbo.Departments", new[] { "HeadId" });
            DropIndex("dbo.Departments", new[] { "FacultyId" });
            DropIndex("dbo.Departments", new[] { "Name" });
            DropIndex("dbo.Groups", new[] { "Name" });
            AlterColumn("dbo.Subjects", "Name", c => c.String(nullable: false));
            DropTable("dbo.DepartmentsFields");
            DropTable("dbo.Departments");
        }
    }
}

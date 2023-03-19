namespace University.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CoursesGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        GroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 10),
                        FieldOfStudyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FieldsOfStudy", t => t.FieldOfStudyId, cascadeDelete: true)
                .Index(t => t.FieldOfStudyId);
            
            CreateTable(
                "dbo.FieldsOfStudy",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 20),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.Educators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        MiddleName = c.String(maxLength: 30),
                        Email = c.String(nullable: false, maxLength: 320),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FacultiesGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FacultyId = c.Int(nullable: false),
                        GroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faculties", t => t.FacultyId, cascadeDelete: true)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .Index(t => t.FacultyId)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.GroupsStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.GroupId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        MiddleName = c.String(maxLength: 30),
                        IdNumber = c.String(nullable: false, maxLength: 10),
                        PhoneNumber = c.String(nullable: false, maxLength: 11),
                        Email = c.String(nullable: false, maxLength: 320),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.IdNumber, unique: true)
                .Index(t => t.PhoneNumber, unique: true)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.Specializations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SpecializationsSubjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SpecializationId = c.Int(nullable: false),
                        SubjectId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Specializations", t => t.SpecializationId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.SpecializationId)
                .Index(t => t.SubjectId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubjectsEducators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectId = c.Int(nullable: false),
                        EducatorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Educators", t => t.EducatorId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.SubjectId)
                .Index(t => t.EducatorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubjectsEducators", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.SubjectsEducators", "EducatorId", "dbo.Educators");
            DropForeignKey("dbo.SpecializationsSubjects", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.SpecializationsSubjects", "SpecializationId", "dbo.Specializations");
            DropForeignKey("dbo.SpecializationsSubjects", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.GroupsStudents", "StudentId", "dbo.Students");
            DropForeignKey("dbo.GroupsStudents", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.FacultiesGroups", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.FacultiesGroups", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.CoursesGroups", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Groups", "FieldOfStudyId", "dbo.FieldsOfStudy");
            DropForeignKey("dbo.CoursesGroups", "CourseId", "dbo.Courses");
            DropIndex("dbo.SubjectsEducators", new[] { "EducatorId" });
            DropIndex("dbo.SubjectsEducators", new[] { "SubjectId" });
            DropIndex("dbo.SpecializationsSubjects", new[] { "CourseId" });
            DropIndex("dbo.SpecializationsSubjects", new[] { "SubjectId" });
            DropIndex("dbo.SpecializationsSubjects", new[] { "SpecializationId" });
            DropIndex("dbo.Students", new[] { "Email" });
            DropIndex("dbo.Students", new[] { "PhoneNumber" });
            DropIndex("dbo.Students", new[] { "IdNumber" });
            DropIndex("dbo.GroupsStudents", new[] { "StudentId" });
            DropIndex("dbo.GroupsStudents", new[] { "GroupId" });
            DropIndex("dbo.FacultiesGroups", new[] { "GroupId" });
            DropIndex("dbo.FacultiesGroups", new[] { "FacultyId" });
            DropIndex("dbo.Educators", new[] { "Email" });
            DropIndex("dbo.FieldsOfStudy", new[] { "Code" });
            DropIndex("dbo.Groups", new[] { "FieldOfStudyId" });
            DropIndex("dbo.CoursesGroups", new[] { "GroupId" });
            DropIndex("dbo.CoursesGroups", new[] { "CourseId" });
            DropTable("dbo.SubjectsEducators");
            DropTable("dbo.Subjects");
            DropTable("dbo.SpecializationsSubjects");
            DropTable("dbo.Specializations");
            DropTable("dbo.Students");
            DropTable("dbo.GroupsStudents");
            DropTable("dbo.FacultiesGroups");
            DropTable("dbo.Faculties");
            DropTable("dbo.Educators");
            DropTable("dbo.FieldsOfStudy");
            DropTable("dbo.Groups");
            DropTable("dbo.CoursesGroups");
            DropTable("dbo.Courses");
        }
    }
}

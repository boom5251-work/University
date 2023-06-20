namespace University.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_11 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CoursesGroups", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Groups", "FieldOfStudyId", "dbo.FieldsOfStudy");
            DropForeignKey("dbo.CoursesGroups", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.DepartmentsFields", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.DepartmentsFields", "FieldOfStudyId", "dbo.FieldsOfStudy");
            DropForeignKey("dbo.EducatorsRoles", "EducatorId", "dbo.Educators");
            DropForeignKey("dbo.EducatorsRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.FacultiesGroups", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.FacultiesGroups", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.FacultiesHeads", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.FacultiesHeads", "HeadId", "dbo.Educators");
            DropForeignKey("dbo.FacultiesHeads", "PostId", "dbo.Posts");
            DropForeignKey("dbo.FacultiesFields", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.FacultiesFields", "FieldOfStudyId", "dbo.FieldsOfStudy");
            DropForeignKey("dbo.GroupsStudents", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.GroupsStudents", "StudentId", "dbo.Students");
            DropForeignKey("dbo.SpecializationsSubjects", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.SpecializationsSubjects", "SpecializationId", "dbo.Specializations");
            DropForeignKey("dbo.SpecializationsSubjects", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.StudentsRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.StudentsRoles", "StudentId", "dbo.Students");
            DropForeignKey("dbo.SubjectsEducators", "EducatorId", "dbo.Educators");
            DropForeignKey("dbo.SubjectsEducators", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Departments", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.Departments", "HeadId", "dbo.Educators");
            DropIndex("dbo.CoursesGroups", new[] { "CourseId" });
            DropIndex("dbo.CoursesGroups", new[] { "GroupId" });
            DropIndex("dbo.Groups", new[] { "Name" });
            DropIndex("dbo.Groups", new[] { "FieldOfStudyId" });
            DropIndex("dbo.Departments", new[] { "FacultyId" });
            DropIndex("dbo.Departments", new[] { "HeadId" });
            DropIndex("dbo.DepartmentsFields", new[] { "DepartmentId" });
            DropIndex("dbo.DepartmentsFields", new[] { "FieldOfStudyId" });
            DropIndex("dbo.EducatorsRoles", new[] { "EducatorId" });
            DropIndex("dbo.EducatorsRoles", new[] { "RoleId" });
            DropIndex("dbo.FacultiesGroups", new[] { "FacultyId" });
            DropIndex("dbo.FacultiesGroups", new[] { "GroupId" });
            DropIndex("dbo.FacultiesHeads", new[] { "FacultyId" });
            DropIndex("dbo.FacultiesHeads", new[] { "HeadId" });
            DropIndex("dbo.FacultiesHeads", new[] { "PostId" });
            DropIndex("dbo.FacultiesFields", new[] { "FacultyId" });
            DropIndex("dbo.FacultiesFields", new[] { "FieldOfStudyId" });
            DropIndex("dbo.GroupsStudents", new[] { "GroupId" });
            DropIndex("dbo.GroupsStudents", new[] { "StudentId" });
            DropIndex("dbo.SpecializationsSubjects", new[] { "SpecializationId" });
            DropIndex("dbo.SpecializationsSubjects", new[] { "SubjectId" });
            DropIndex("dbo.SpecializationsSubjects", new[] { "CourseId" });
            DropIndex("dbo.Subjects", new[] { "Name" });
            DropIndex("dbo.StudentsRoles", new[] { "StudentId" });
            DropIndex("dbo.StudentsRoles", new[] { "RoleId" });
            DropIndex("dbo.SubjectsEducators", new[] { "SubjectId" });
            DropIndex("dbo.SubjectsEducators", new[] { "EducatorId" });
            RenameColumn(table: "dbo.Departments", name: "FacultyId", newName: "Faculty_Id");
            RenameColumn(table: "dbo.Departments", name: "HeadId", newName: "Head_Id");
            CreateTable(
                "dbo.FieldOfStudyFaculties",
                c => new
                    {
                        FieldOfStudy_Id = c.Int(nullable: false),
                        Faculty_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FieldOfStudy_Id, t.Faculty_Id })
                .ForeignKey("dbo.FieldsOfStudy", t => t.FieldOfStudy_Id, cascadeDelete: true)
                .ForeignKey("dbo.Faculties", t => t.Faculty_Id, cascadeDelete: true)
                .Index(t => t.FieldOfStudy_Id)
                .Index(t => t.Faculty_Id);
            
            CreateTable(
                "dbo.RoleEducators",
                c => new
                    {
                        Role_Id = c.Int(nullable: false),
                        Educator_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_Id, t.Educator_Id })
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .ForeignKey("dbo.Educators", t => t.Educator_Id, cascadeDelete: true)
                .Index(t => t.Role_Id)
                .Index(t => t.Educator_Id);
            
            CreateTable(
                "dbo.StudentRoles",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Role_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Role_Id })
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.Student_Id)
                .Index(t => t.Role_Id);
            
            AddColumn("dbo.FieldsOfStudy", "Department_Id", c => c.Int());
            AddColumn("dbo.Educators", "Post_Id", c => c.Int());
            AddColumn("dbo.Educators", "Faculty_Id", c => c.Int());
            AlterColumn("dbo.Departments", "Faculty_Id", c => c.Int());
            AlterColumn("dbo.Departments", "Head_Id", c => c.Int());
            CreateIndex("dbo.Departments", "Faculty_Id");
            CreateIndex("dbo.Departments", "Head_Id");
            CreateIndex("dbo.FieldsOfStudy", "Department_Id");
            CreateIndex("dbo.Educators", "Post_Id");
            CreateIndex("dbo.Educators", "Faculty_Id");
            AddForeignKey("dbo.Educators", "Post_Id", "dbo.Posts", "Id");
            AddForeignKey("dbo.Educators", "Faculty_Id", "dbo.Faculties", "Id");
            AddForeignKey("dbo.FieldsOfStudy", "Department_Id", "dbo.Departments", "Id");
            AddForeignKey("dbo.Departments", "Faculty_Id", "dbo.Faculties", "Id");
            AddForeignKey("dbo.Departments", "Head_Id", "dbo.Educators", "Id");
            DropTable("dbo.Courses");
            DropTable("dbo.CoursesGroups");
            DropTable("dbo.Groups");
            DropTable("dbo.DepartmentsFields");
            DropTable("dbo.EducatorsRoles");
            DropTable("dbo.FacultiesGroups");
            DropTable("dbo.FacultiesHeads");
            DropTable("dbo.FacultiesFields");
            DropTable("dbo.GroupsStudents");
            DropTable("dbo.Specializations");
            DropTable("dbo.SpecializationsSubjects");
            DropTable("dbo.Subjects");
            DropTable("dbo.StudentsRoles");
            DropTable("dbo.SubjectsEducators");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SubjectsEducators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectId = c.Int(nullable: false),
                        EducatorId = c.Int(nullable: false),
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
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false),
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
                .PrimaryKey(t => t.Id);
            
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
                "dbo.GroupsStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FacultiesFields",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FacultyId = c.Int(nullable: false),
                        FieldOfStudyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FacultiesHeads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FacultyId = c.Int(nullable: false),
                        HeadId = c.Int(nullable: false),
                        PostId = c.Int(nullable: false),
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
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EducatorsRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EducatorId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DepartmentsFields",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(nullable: false),
                        FieldOfStudyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 10),
                        FieldOfStudyId = c.Int(nullable: false),
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
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Departments", "Head_Id", "dbo.Educators");
            DropForeignKey("dbo.Departments", "Faculty_Id", "dbo.Faculties");
            DropForeignKey("dbo.FieldsOfStudy", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.Educators", "Faculty_Id", "dbo.Faculties");
            DropForeignKey("dbo.StudentRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.StudentRoles", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.RoleEducators", "Educator_Id", "dbo.Educators");
            DropForeignKey("dbo.RoleEducators", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Educators", "Post_Id", "dbo.Posts");
            DropForeignKey("dbo.FieldOfStudyFaculties", "Faculty_Id", "dbo.Faculties");
            DropForeignKey("dbo.FieldOfStudyFaculties", "FieldOfStudy_Id", "dbo.FieldsOfStudy");
            DropIndex("dbo.StudentRoles", new[] { "Role_Id" });
            DropIndex("dbo.StudentRoles", new[] { "Student_Id" });
            DropIndex("dbo.RoleEducators", new[] { "Educator_Id" });
            DropIndex("dbo.RoleEducators", new[] { "Role_Id" });
            DropIndex("dbo.FieldOfStudyFaculties", new[] { "Faculty_Id" });
            DropIndex("dbo.FieldOfStudyFaculties", new[] { "FieldOfStudy_Id" });
            DropIndex("dbo.Educators", new[] { "Faculty_Id" });
            DropIndex("dbo.Educators", new[] { "Post_Id" });
            DropIndex("dbo.FieldsOfStudy", new[] { "Department_Id" });
            DropIndex("dbo.Departments", new[] { "Head_Id" });
            DropIndex("dbo.Departments", new[] { "Faculty_Id" });
            AlterColumn("dbo.Departments", "Head_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Departments", "Faculty_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Educators", "Faculty_Id");
            DropColumn("dbo.Educators", "Post_Id");
            DropColumn("dbo.FieldsOfStudy", "Department_Id");
            DropTable("dbo.StudentRoles");
            DropTable("dbo.RoleEducators");
            DropTable("dbo.FieldOfStudyFaculties");
            RenameColumn(table: "dbo.Departments", name: "Head_Id", newName: "HeadId");
            RenameColumn(table: "dbo.Departments", name: "Faculty_Id", newName: "FacultyId");
            CreateIndex("dbo.SubjectsEducators", "EducatorId");
            CreateIndex("dbo.SubjectsEducators", "SubjectId");
            CreateIndex("dbo.StudentsRoles", "RoleId");
            CreateIndex("dbo.StudentsRoles", "StudentId");
            CreateIndex("dbo.Subjects", "Name", unique: true);
            CreateIndex("dbo.SpecializationsSubjects", "CourseId");
            CreateIndex("dbo.SpecializationsSubjects", "SubjectId");
            CreateIndex("dbo.SpecializationsSubjects", "SpecializationId");
            CreateIndex("dbo.GroupsStudents", "StudentId");
            CreateIndex("dbo.GroupsStudents", "GroupId");
            CreateIndex("dbo.FacultiesFields", "FieldOfStudyId");
            CreateIndex("dbo.FacultiesFields", "FacultyId");
            CreateIndex("dbo.FacultiesHeads", "PostId");
            CreateIndex("dbo.FacultiesHeads", "HeadId");
            CreateIndex("dbo.FacultiesHeads", "FacultyId");
            CreateIndex("dbo.FacultiesGroups", "GroupId");
            CreateIndex("dbo.FacultiesGroups", "FacultyId");
            CreateIndex("dbo.EducatorsRoles", "RoleId");
            CreateIndex("dbo.EducatorsRoles", "EducatorId");
            CreateIndex("dbo.DepartmentsFields", "FieldOfStudyId");
            CreateIndex("dbo.DepartmentsFields", "DepartmentId");
            CreateIndex("dbo.Departments", "HeadId");
            CreateIndex("dbo.Departments", "FacultyId");
            CreateIndex("dbo.Groups", "FieldOfStudyId");
            CreateIndex("dbo.Groups", "Name", unique: true);
            CreateIndex("dbo.CoursesGroups", "GroupId");
            CreateIndex("dbo.CoursesGroups", "CourseId");
            AddForeignKey("dbo.Departments", "HeadId", "dbo.Educators", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Departments", "FacultyId", "dbo.Faculties", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SubjectsEducators", "SubjectId", "dbo.Subjects", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SubjectsEducators", "EducatorId", "dbo.Educators", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentsRoles", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentsRoles", "RoleId", "dbo.Roles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SpecializationsSubjects", "SubjectId", "dbo.Subjects", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SpecializationsSubjects", "SpecializationId", "dbo.Specializations", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SpecializationsSubjects", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.GroupsStudents", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.GroupsStudents", "GroupId", "dbo.Groups", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FacultiesFields", "FieldOfStudyId", "dbo.FieldsOfStudy", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FacultiesFields", "FacultyId", "dbo.Faculties", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FacultiesHeads", "PostId", "dbo.Posts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FacultiesHeads", "HeadId", "dbo.Educators", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FacultiesHeads", "FacultyId", "dbo.Faculties", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FacultiesGroups", "GroupId", "dbo.Groups", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FacultiesGroups", "FacultyId", "dbo.Faculties", "Id", cascadeDelete: true);
            AddForeignKey("dbo.EducatorsRoles", "RoleId", "dbo.Roles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.EducatorsRoles", "EducatorId", "dbo.Educators", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DepartmentsFields", "FieldOfStudyId", "dbo.FieldsOfStudy", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DepartmentsFields", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CoursesGroups", "GroupId", "dbo.Groups", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Groups", "FieldOfStudyId", "dbo.FieldsOfStudy", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CoursesGroups", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
        }
    }
}

namespace University.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FacultiesFields",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FacultyId = c.Int(nullable: false),
                        FieldOfStudyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faculties", t => t.FacultyId, cascadeDelete: true)
                .ForeignKey("dbo.FieldsOfStudy", t => t.FieldOfStudyId, cascadeDelete: true)
                .Index(t => t.FacultyId)
                .Index(t => t.FieldOfStudyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FacultiesFields", "FieldOfStudyId", "dbo.FieldsOfStudy");
            DropForeignKey("dbo.FacultiesFields", "FacultyId", "dbo.Faculties");
            DropIndex("dbo.FacultiesFields", new[] { "FieldOfStudyId" });
            DropIndex("dbo.FacultiesFields", new[] { "FacultyId" });
            DropTable("dbo.FacultiesFields");
        }
    }
}

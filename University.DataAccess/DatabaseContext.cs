using System.Data.Entity;
using University.DataAccess.Models;

namespace University.DataAccess
{
    /// <summary>
    /// Контекст базы данных.
    /// </summary>
    public sealed class DatabaseContext : DbContext
    {
        /// <summary>
        /// Конструктор контекста базы данных по умолчанию.
        /// </summary>
        public DatabaseContext() : base("DbConnection") { }



        /// <summary>
        /// Набор курсов.
        /// </summary>
        public DbSet<Course> Courses { get; set; }

        /// <summary>
        /// Набор сущностей курс-группа.
        /// </summary>
        public DbSet<CourseGroup> CoursesGroups { get; set; }

        /// <summary>
        /// Набор кафедр.
        /// </summary>
        public DbSet<Department> Departments { get; set; }

        /// <summary>
        /// Набор сущностей кафедра-направление подготовки.
        /// </summary>
        public DbSet<DepartmentFieldOfStudy> DepartmentsFields { get; set; }

        /// <summary>
        /// Набор преподавателей.
        /// </summary>
        public DbSet<Educator> Educators { get; set; }

        /// <summary>
        /// Набор сущностей преподаватель-роль.
        /// </summary>
        public DbSet<EducatorRole> EducatorsRoles { get; set; }

        /// <summary>
        /// Набор факультетов.
        /// </summary>
        public DbSet<Faculty> Faculties { get; set; }

        /// <summary>
        /// Набор сущностей факультет-направление подготовки.
        /// </summary>
        public DbSet<FacultyFieldOfStudy> FacultyFields { get; set; }

        /// <summary>
        /// Набор сущностей факультет-группа.
        /// </summary>
        public DbSet<FacultyGroup> FacultiesGroups { get; set; }

        /// <summary>
        /// Набор направлений подготовки.
        /// </summary>
        public DbSet<FieldOfStudy> FieldsOfStudy { get; set; }

        /// <summary>
        /// Набор учебных групп.
        /// </summary>
        public DbSet<Group> Groups { get; set; }

        /// <summary>
        /// Набор сущностей группа-студент.
        /// </summary>
        public DbSet<GroupStudent> GroupsStudents { get; set; }

        /// <summary>
        /// Набор ролей.
        /// </summary>
        public DbSet<Role> Roles { get; set; }

        /// <summary>
        /// Набор специализаций.
        /// </summary>
        public DbSet<Specialization> Specializations { get; set; }

        /// <summary>
        /// Набор сущностей специализация-дисциплина.
        /// </summary>
        public DbSet<SpecializationSubject> SpecializationsSubjects { get; set; }

        /// <summary>
        /// Набор студентов.
        /// </summary>
        public DbSet<Student> Students { get; set; }

        /// <summary>
        /// Набор сущностей студент-роль.
        /// </summary>
        public DbSet<StudentRole> StudentsRoles { get; set; }

        /// <summary>
        /// Набор дисциплин.
        /// </summary>
        public DbSet<Subject> Subjects { get; set; }

        /// <summary>
        /// Набор сущностей дисциплина-преподаватель.
        /// </summary>
        public DbSet<SubjectEducator> SubjectsEducators { get; set; }
    }
}
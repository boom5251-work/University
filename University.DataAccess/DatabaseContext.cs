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
        /// Набор кафедр.
        /// </summary>
        public DbSet<Department> Departments { get; set; }

        /// <summary>
        /// Набор преподавателей.
        /// </summary>
        public DbSet<Educator> Educators { get; set; }

        /// <summary>
        /// Набор факультетов.
        /// </summary>
        public DbSet<Faculty> Faculties { get; set; }

        /// <summary>
        /// Набор направлений подготовки.
        /// </summary>
        public DbSet<FieldOfStudy> FieldsOfStudy { get; set; }

        /// <summary>
        /// Набор новостных записей.
        /// </summary>
        public DbSet<Headline> Headlines { get; set; }

        /// <summary>
        /// Набор должностей.
        /// </summary>
        public DbSet<Post> Posts { get; set; }

        /// <summary>
        /// Набор ролей.
        /// </summary>
        public DbSet<Role> Roles { get; set; }

        /// <summary>
        /// Набор студентов.
        /// </summary>
        public DbSet<Student> Students { get; set; }
    }
}
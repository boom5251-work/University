using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель аккаунт-роль.
    /// </summary>
    [Table("StudentsRoles")]
    public sealed class StudentRole
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор студента (внешний ключ).
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// Идентификатор роли (внешний ключ).
        /// </summary>
        public int RoleId { get; set; }


        /// <summary>
        /// Студент.
        /// </summary>
        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; }

        /// <summary>
        /// Роль.
        /// </summary>
        [ForeignKey(nameof(RoleId))]
        public Role Role { get; set; }
    }
}
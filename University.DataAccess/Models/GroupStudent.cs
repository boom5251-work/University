using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель группа-студент.
    /// </summary>
    [Table("GroupsStudents")]
    public sealed class GroupStudent
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор группы (внешний ключ).
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// Идентификатор студента (внешний ключ).
        /// </summary>
        public int StudentId { get; set; }


        /// <summary>
        /// Группа.
        /// </summary>
        [ForeignKey(nameof(GroupId))]
        public Group Group { get; set; }

        /// <summary>
        /// Студент.
        /// </summary>
        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель курс-группа.
    /// </summary>
    [Table("CoursesGroups")]
    public sealed class CourseGroup
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор курса (внешний ключ).
        /// </summary>
        public int CourseId { get; set; }

        /// <summary>
        /// Идентификатор группы (внешний ключ).
        /// </summary>
        public int GroupId { get; set; }


        /// <summary>
        /// Курс.
        /// </summary>
        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; }

        /// <summary>
        /// Группа.
        /// </summary>
        [ForeignKey(nameof(GroupId))]
        public Group Group { get; set; }
    }
}
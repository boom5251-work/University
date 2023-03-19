using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель дисциплина-преподаватель.
    /// </summary>
    [Table("SubjectsEducators")]
    public sealed class SubjectEducator
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор дисциплины (внешний ключ).
        /// </summary>
        public int SubjectId { get; set; }

        /// <summary>
        /// Идентификатор преподавателя (внешний ключ).
        /// </summary>
        public int EducatorId { get; set; }


        /// <summary>
        /// Дисциплина.
        /// </summary>
        [ForeignKey(nameof(SubjectId))]
        public Subject Subject { get; set; }

        /// <summary>
        /// Преподаватель.
        /// </summary>
        [ForeignKey(nameof(EducatorId))]
        public Educator Educator { get; set; }
    }
}
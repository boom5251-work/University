using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель специализации-предмета.
    /// </summary>
    [Table("SpecializationsSubjects")]
    public sealed class SpecializationSubject
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор специализации (внешний ключ).
        /// </summary>
        public int SpecializationId { get; set; }

        /// <summary>
        /// Идентификатор дисциплины (внешний ключ).
        /// </summary>
        public int SubjectId { get; set; }

        /// <summary>
        /// Идентификатор курса (внешний ключ).
        /// </summary>
        public int CourseId { get; set; }


        /// <summary>
        /// Специализация.
        /// </summary>
        [ForeignKey(nameof(SpecializationId))]
        public Specialization Specialization { get; set; }

        /// <summary>
        /// Дисциплина.
        /// </summary>
        [ForeignKey(nameof(SubjectId))]
        public Subject Subject { get; set; }

        /// <summary>
        /// Курс.
        /// </summary>
        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; }
    }
}
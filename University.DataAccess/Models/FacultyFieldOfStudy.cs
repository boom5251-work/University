using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель факультет-направление подготовки.
    /// </summary>
    [Table("FacultiesFields")]
    public sealed class FacultyFieldOfStudy
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор факультета.
        /// </summary>
        public int FacultyId { get; set; }

        /// <summary>
        /// Идентификатор направления подготовки.
        /// </summary>
        public int FieldOfStudyId { get; set; }

        /// <summary>
        /// Факультет.
        /// </summary>
        [ForeignKey(nameof(FacultyId))]
        public Faculty Faculty { get; set; }

        /// <summary>
        /// Направление подготовки.
        /// </summary>
        [ForeignKey(nameof(FieldOfStudyId))]
        public FieldOfStudy FieldOfStudy { get; set; }
    }
}
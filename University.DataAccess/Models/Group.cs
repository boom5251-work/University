using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель учебной группы.
    /// </summary>
    [Table("Groups")]
    public sealed class Group
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Код группы.
        /// </summary>
        [Required]
        [StringLength(10, MinimumLength = 2)]
        public string Name { get; set; }


        /// <summary>
        /// Идентификатор направления получения (внешний ключ).
        /// </summary>
        public int FieldOfStudyId { get; set; }


        /// <summary>
        /// Направление обучения.
        /// </summary>
        [ForeignKey(nameof(FieldOfStudyId))]
        public FieldOfStudy FieldOfStudy { get; set; }
    }
}
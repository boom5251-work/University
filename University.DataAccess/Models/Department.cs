using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель кафедры.
    /// </summary>
    [Table("Departments")]
    public sealed class Department
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Название.
        /// </summary>
        [Required]
        [Index(IsUnique = true)]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }

        /// <summary>
        /// Сокращенное латинское название.
        /// </summary>
        [Required]
        [Index(IsUnique = true)]
        [StringLength(10, MinimumLength = 1)]
        public string LatPath { get; set; }

        /// <summary>
        /// Идентификатор факультета (внешний ключ).
        /// </summary>
        public int FacultyId { get; set; }

        /// <summary>
        /// Идентификатор заведующего кафедрой (внешний ключ).
        /// </summary>
        public int HeadId { get; set; }


        /// <summary>
        /// Факультет.
        /// </summary>
        [ForeignKey(nameof(FacultyId))]
        public Faculty Faculty { get; set; }

        /// <summary>
        /// Заведующий кафедрой.
        /// </summary>
        [ForeignKey(nameof(HeadId))]
        public Educator Head { get; set; }
    }
}
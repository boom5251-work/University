using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель направления подготовки.
    /// </summary>
    [Table("FieldsOfStudy")]
    public sealed class FieldOfStudy
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Уникальный код.
        /// </summary>
        [Required]
        [MaxLength(20)]
        [Index(IsUnique = true)]
        public string Code { get; set; }

        /// <summary>
        /// Название направления подготовки.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Описание направления подготовки.
        /// </summary>
        [Required]
        public string Description { get; set; }



        /// <summary>
        /// Список факультетов.
        /// </summary>
        public List<Faculty> Faculties { get; set; }
    }
}
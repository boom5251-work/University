using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель специализации направления.
    /// </summary>
    [Table("Specializations")]
    public sealed class Specialization
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
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
    }
}
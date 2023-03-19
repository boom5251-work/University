using System.ComponentModel.DataAnnotations;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель курса.
    /// </summary>
    public sealed class Course
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Название курса.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
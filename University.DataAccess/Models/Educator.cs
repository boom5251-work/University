using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель преподавателя.
    /// </summary>
    [Table("Educators")]
    public sealed class Educator
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Имя.
        /// </summary>
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия.
        /// </summary>
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        /// <summary>
        /// Отчество.
        /// </summary>
        [MaxLength(30)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Адрес электронной почты.
        /// </summary>
        [Required]
        [StringLength(320, MinimumLength = 6)]
        [Index(IsUnique = true)]
        public string Email { get; set; }

        /// <summary>
        /// Пароль.
        /// </summary>
        [Required]
        [StringLength(50, MinimumLength = 6)]
        public string Password { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель студента.
    /// </summary>
    [Table("Students")]
    public sealed class Student
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
        /// Номер студенческого билета.
        /// </summary>
        [Required]
        [MaxLength(10)]
        [Index(IsUnique = true)]
        public string IdNumber { get; set; }

        /// <summary>
        /// Номер телефона.
        /// </summary>
        [Required]
        [StringLength(11, MinimumLength = 11)]
        [Index(IsUnique = true)]
        public string PhoneNumber { get; set; }

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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using University.DataAccess.Models.Base;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель преподавателя.
    /// </summary>
    [Table("Educators")]
    public sealed class Educator : IUser
    {
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
        /// Путь к фотографии пользователя.
        /// </summary>
        [StringLength(50, MinimumLength = 5)]
        public string PhotoFileName { get; set; }

        /// <inheritdoc />
        [Required]
        [StringLength(320, MinimumLength = 6)]
        [Index(IsUnique = true)]
        public string Email { get; set; }

        /// <inheritdoc />
        [Required]
        [StringLength(50, MinimumLength = 6)]
        public string Password { get; set; }



        /// <inheritdoc />
        public List<Role> Roles { get; set; }

        /// <summary>
        /// Должность.
        /// </summary>
        public Post Post { get; set; }
    }
}
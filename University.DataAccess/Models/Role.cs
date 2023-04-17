using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using University.DataAccess.Models.Base;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель роли.
    /// </summary>
    [Table("Roles")]
    public sealed class Role
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
        public string Name { get; set; }

        /// <summary>
        /// Уникальный код.
        /// </summary>
        [Required]
        public int Code { get; set; }

        /// <summary>
        /// Роль пользователя.
        /// </summary>
        [NotMapped]
        public UserRoles UserRole => (UserRoles)Code;
    }
}
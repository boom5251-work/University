using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using University.DataAccess.Models.Base;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель должности.
    /// </summary>
    [Table("Posts")]
    public sealed class Post
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
        [StringLength(255)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        /// <summary>
        /// Уникальный код.
        /// </summary>
        [Required]
        [Index(IsUnique = true)]
        public int Code { get; set; }


        /// <summary>
        /// Должность преподавателя.
        /// </summary>
        [NotMapped]
        public EducatorPost EducatorPost => (EducatorPost)Code;
    }
}
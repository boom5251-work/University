using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Новостная запись
    /// </summary>
    [Table("Headlines")]
    public sealed class Headline
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Дата и время публикации.
        /// </summary>
        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime PublishedAt { get; set; }

        /// <summary>
        /// Заголовок.
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Текст новости.
        /// </summary>
        [Required]
        public string Text { get; set; }
    }
}
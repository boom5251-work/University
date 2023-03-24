﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель изучаемой дисциплины.
    /// </summary>
    [Table("Subjects")]
    public sealed class Subject
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
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        [Required]
        public string Description { get; set; }
    }
}
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель факультета.
    /// </summary>
    [Table("Faculties")]
    public sealed class Faculty
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
        /// Описание.
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Сокращенное латинское название.
        /// </summary>
        [Required]
        [Index(IsUnique = true)]
        [StringLength(20, MinimumLength = 1)]
        public string LatPath { get; set; }

        /// <summary>
        /// Уникальный цвет факультета.
        /// </summary>
        [Required]
        public int ArgbColor { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель факультет-руководитель.
    /// </summary>
    [Table("FacultiesHeads")]
    public sealed class FacultyHead
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор факультета (внешний ключ).
        /// </summary>
        public int FacultyId { get; set; }

        /// <summary>
        /// Идентификатор факультета (внешний ключ).
        /// </summary>
        public int HeadId { get; set; }

        /// <summary>
        /// Идентификатор должности (внешний ключ).
        /// </summary>
        public int PostId { get; set; }


        /// <summary>
        /// Факультет.
        /// </summary>
        [ForeignKey(nameof(FacultyId))]
        public Faculty Faculty { get; set; }

        /// <summary>
        /// Руководитель.
        /// </summary>
        [ForeignKey(nameof(HeadId))]
        public Educator Head { get; set; }

        /// <summary>
        /// Должность.
        /// </summary>
        [ForeignKey(nameof(PostId))]
        public Post Post { get; set; }
    }
}
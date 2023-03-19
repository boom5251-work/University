using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель факультет-группа.
    /// </summary>
    [Table("FacultiesGroups")]
    public sealed class FacultyGroup
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
        /// Идентификатор группы (внешний ключ).
        /// </summary>
        public int GroupId { get; set; }


        /// <summary>
        /// Факультет.
        /// </summary>
        [ForeignKey(nameof(FacultyId))]
        public Faculty Faculty { get; set; }

        /// <summary>
        /// Группа.
        /// </summary>
        [ForeignKey(nameof(GroupId))]
        public Group Group { get; set; }
    }
}
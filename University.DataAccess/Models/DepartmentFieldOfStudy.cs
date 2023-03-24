using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DataAccess.Models
{
    /// <summary>
    /// Модель кафедра-курс.
    /// </summary>
    [Table("DepartmentsFields")]
    public sealed class DepartmentFieldOfStudy
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор кафедры (внешний ключ).
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// Идентификатор направления подготовки (внешний ключ).
        /// </summary>
        public int FieldOfStudyId { get; set; }


        /// <summary>
        /// Кафедра.
        /// </summary>
        [ForeignKey(nameof(DepartmentId))]
        public Department Department { get; set; }

        /// <summary>
        /// Направление подготовки.
        /// </summary>
        [ForeignKey(nameof(FieldOfStudyId))]
        public FieldOfStudy FieldOfStudy { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DataAccess.Models
{
    [Table("EducatorsRoles")]
    public sealed class EducatorRole
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор преподавателя (внешний ключ).
        /// </summary>
        public int EducatorId { get; set; }

        /// <summary>
        /// Идентификатор роли (внешний ключ).
        /// </summary>
        public int RoleId { get; set; }


        /// <summary>
        /// Преподаватель.
        /// </summary>
        [ForeignKey(nameof(EducatorId))]
        public Educator Educator { get; set; }

        /// <summary>
        /// Роль.
        /// </summary>
        [ForeignKey(nameof(RoleId))]
        public Role Role { get; set; }
    }
}

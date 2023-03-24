using System;

namespace University.DataAccess.Models.Base
{
    /// <summary>
    /// Роли пользователей.
    /// </summary>
    [Flags]
    public enum UserRoles
    {
        /// <summary>
        /// Роль не присвоена.
        /// </summary>
        None = 0,

        /// <summary>
        /// Системный администратор.
        /// </summary>
        Admin = 1,

        /// <summary>
        /// Преподаватель.
        /// </summary>
        Educator = 2,

        /// <summary>
        /// Работник учебного отдела.
        /// </summary>
        Employee = 4,

        /// <summary>
        /// Студент.
        /// </summary>
        Student = 8,

        /// <summary>
        /// Любая роль.
        /// </summary>
        Any = 0b1111
    }
}
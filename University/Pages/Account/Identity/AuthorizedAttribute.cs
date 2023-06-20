using System;
using University.DataAccess.Models.Base;

namespace University.Pages.Account.Identity
{
    /// <summary>
    /// Атрибут, указывающий каким пользователям открыт доступ к ресурсу.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizedAttribute : Attribute
    {
        /// <summary>
        /// Конструктор по умолчанию для любого авторизированного пользователя.
        /// </summary>
        public AuthorizedAttribute()
        {
            AcceptableRoles = UserRoles.Any;
        }


        /// <summary>
        /// Конструктор с принудительной установкой ролей.
        /// </summary>
        /// <param name="userRoles">Роил пользователей, которым разрешен доступ.</param>
        /// <param name="allowAdmin">Флаг указывает, разрешен ли доступ администратору.</param>
        public AuthorizedAttribute(UserRoles userRoles, bool allowAdmin = true)
        {
            AcceptableRoles = userRoles;

            if (allowAdmin)
                AcceptableRoles |= UserRoles.Admin;
        }



        /// <summary>
        /// Роли пользователей, которым открыт доступ к ресурсу.
        /// </summary>
        public UserRoles AcceptableRoles { get; private set; }



        /// <summary>
        /// Проверяет, соответствует ли пользователь требованиям защиты.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>True, если валидация выполнена успешно. False - нет.</returns>
        public bool ValidateUser(IUser user)
        {
            var userRoles = UserRoles.None;

            foreach (var role in user.Roles)
                userRoles |= role.UserRole;

            return (userRoles & AcceptableRoles) != UserRoles.None;
        }
    }
}
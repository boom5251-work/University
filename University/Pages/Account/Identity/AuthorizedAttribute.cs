using System;
using System.Collections.Generic;
using System.Linq;
using University.DataAccess;
using University.DataAccess.Models;
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
            UserRoles = UserRoles.Any;
        }


        /// <summary>
        /// Конструктор с принудительной установкой ролей.
        /// </summary>
        /// <param name="userRoles">Роил пользователей, которым разрешен доступ.</param>
        /// <param name="allowAdmin">Флаг указывает, разрешен ли доступ администратору.</param>
        public AuthorizedAttribute(UserRoles userRoles, bool allowAdmin = true)
        {
            UserRoles = userRoles;

            if (allowAdmin)
                UserRoles |= UserRoles.Admin;
        }



        /// <summary>
        /// Роли пользователей, которым открыт доступ к ресурсу.
        /// </summary>
        public UserRoles UserRoles { get; private set; }



        /// <summary>
        /// Проверяет, соответствует ли пользователь требованиям защиты.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="email"></param>
        /// <param name="user"></param>
        /// <returns>Пользователь (при успешной валидации).</returns>
        public bool ValidateUser<T>(string email, out IUser user) where T : IUser
        {
            user = FindUser<T>(email);

            if (user is null)
            {
                return false;
            }
            else
            {
                UserRoles roles = GetUserRoles(user);
                return (roles & UserRoles) != UserRoles.None;
            }
        }


        /// <summary>
        /// Извлекает пользователя из БД по адресу электронной почты.
        /// </summary>
        /// <typeparam name="T">Тип пользователя.</typeparam>
        /// <param name="email">Адрес электронной почты.</param>
        /// <returns>Пользователь.</returns>
        private IUser FindUser<T>(string email)
        {
            var context = new DatabaseContext();

            if (typeof(T) == typeof(Educator))
            {
                return context.Educators.SingleOrDefault(educator => educator.Email == email);
            }
            else if (typeof(T) == typeof(Student))
            {
                return context.Students.SingleOrDefault(student => student.Email == email);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Извлекает роли пользователя из БД и возвращает флаги.
        /// </summary>
        /// <param name="user">Пользователь.</param>
        /// <returns>Флаги пользователя.</returns>
        private UserRoles GetUserRoles(IUser user)
        {
            var context = new DatabaseContext();

            var roleIds = new List<int>();

            if (user is Educator)
            {
                roleIds = context.EducatorsRoles
                    .Where(item => item.EducatorId == user.Id)
                    .Select(item => item.RoleId)
                    .ToList();
            }
            else if (user is Student)
            {
                roleIds = context.StudentsRoles
                    .Where(item => item.StudentId == user.Id)
                    .Select(item => item.RoleId)
                    .ToList();
            }

            UserRoles userRoles = UserRoles.None;

            var roles = context.Roles.Where(role => roleIds.Contains(role.Id));

            foreach (var role in roles)
                userRoles |= role.UserRole;

            return userRoles;

        }
    }
}
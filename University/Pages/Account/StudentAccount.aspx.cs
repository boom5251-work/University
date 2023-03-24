using System;
using System.Reflection;
using System.Web.Security;
using System.Web.UI;
using University.DataAccess.Models;
using University.DataAccess.Models.Base;
using University.Pages.Account.Identity;

namespace University.Pages.Account
{
    /// <summary>
    /// Страница личного кабинета студента.
    /// </summary>
    [Authorized(UserRoles.Student)]
    public partial class StudentAccount : Page
    {
        /// <summary>
        /// Путь перехода на страницу авторизации.
        /// </summary>
        private readonly string loginUrl = "/Login?RedirectUrl=/Account/Student";

        /// <summary>
        /// Путь переходы на страницу ошибки 401.
        /// </summary>
        private readonly string unauthorizedUrl = "/Error/401?ErrorUrl=/Account/Student";



        /// <summary>
        /// Обрабатывает событие загрузки страницы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (CheckIdentity(out IUser user))
                    InitializeContent((Student)user);
                else
                    Response.RedirectPermanent(unauthorizedUrl);
            }
            else
                Response.RedirectPermanent(loginUrl);
        }


        /// <summary>
        /// Обрабатывает событие нажатия на кнопку выхода из аккаунта.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы.</param>
        protected void LogOutButton_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.RedirectPermanent("/Login");
        }


        /// <summary>
        /// Проверяет, авторизирован ли преподаватель.
        /// </summary>
        /// <param name="user">Студент.</param>
        /// <returns>True, если студент прошел авторизацию. False - нет.</returns>
        private bool CheckIdentity(out IUser user)
        {
            var authorized = GetType().GetCustomAttribute<AuthorizedAttribute>();
            return authorized.ValidateUser<Student>(User.Identity.Name, out user);
        }


        /// <summary>
        /// Инициализирует содержимое страницы.
        /// </summary>
        /// <param name="student">Студент.</param>
        private void InitializeContent(Student student)
        {
            // TODO: Реализовать.
            // TODO: Переписать код отображения.
            test.InnerText = $"{student.LastName} {student.FirstName} {student.MiddleName}";
        }
    }
}
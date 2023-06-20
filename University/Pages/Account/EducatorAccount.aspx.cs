using System;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web.Security;
using System.Web.UI;
using University.DataAccess;
using University.DataAccess.Models;
using University.DataAccess.Models.Base;
using University.Pages.Account.Identity;

namespace University.Pages.Account
{
    /// <summary>
    /// Страница личного кабинета преподавателя.
    /// </summary>
    [Authorized(UserRoles.Educator)]
    public partial class EducatorAccount : Page
    {
        /// <summary>
        /// Путь перехода на страницу авторизации.
        /// </summary>
        private readonly string loginUrl = "/Login?RedirectUrl=/Account/Educator";

        /// <summary>
        /// Путь переходы на страницу ошибки 401.
        /// </summary>
        private readonly string unauthorizedUrl = "/Error/401?ErrorUrl=/Account/Educator";



        /// <summary>
        /// Обрабатывает событие загрузки страницы.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (CheckIdentity(out IUser user))
                    InitializeContent((Educator)user);
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
        /// <param name="user">Преподаватель.</param>
        /// <returns>True, если преподаватель прошел авторизацию. False - нет.</returns>
        private bool CheckIdentity(out IUser user)
        {
            var authorized = GetType().GetCustomAttribute<AuthorizedAttribute>();

            using (var context = new DatabaseContext())
            {
                user = context.Educators.Include(educator => educator.Roles)
                    .AsNoTracking()
                    .SingleOrDefault(educator => educator.Email == User.Identity.Name);

                return authorized.ValidateUser(user);
            }
        }


        /// <summary>
        /// Инициализирует содержимое страницы.
        /// </summary>
        /// <param name="educator">Преподаватель.</param>
        private void InitializeContent(Educator educator)
        {
            // TODO: Реализовать.
            // TODO: Переписать код отображения.
            test.InnerText = $"{educator.LastName} {educator.FirstName} {educator.MiddleName}";
        }
    }
}
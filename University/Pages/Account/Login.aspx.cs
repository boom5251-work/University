using System;
using System.Linq;
using System.Web.Security;
using System.Web.UI;
using University.DataAccess;
using University.DataAccess.Models;

namespace University.Pages.Account
{
    /// <summary>
    /// Страница авторизация пользователя.
    /// </summary>
    public partial class Login : Page
    {
        /// <summary>
        /// Обрабатывает событие загрузки страницы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
                RedirectFromLoginPage("/");
        }


        /// <summary>
        /// Обрабатывает событие нажатия на кнопку авторизации.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы.</param>
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if (TryGetEducator(out Educator educator))
            {
                FormsAuthentication.SetAuthCookie(educator.Email, false);
                RedirectFromLoginPage("Account/Educator");
            }
            else if (TryGetStudent(out Student student))
            {
                FormsAuthentication.SetAuthCookie(student.Email, false);
                RedirectFromLoginPage("Account/Student");
            }
            else
            {
                // TODO: Добавить сообщение о некорректно введенных данных.
            }
        }


        /// <summary>
        /// Пытается найти и извлечь преподавателя из БД по адресу электронной почты и паролю.
        /// </summary>
        /// <param name="educator">Преподаватель.</param>
        /// <returns>True - если преподаватель найден. False - нет.</returns>
        private bool TryGetEducator(out Educator educator)
        {
            string email = EmailInput.Text;
            string password = PasswordInput.Text;

            var context = new DatabaseContext();

            educator = context.Educators.SingleOrDefault(_educator => 
                _educator.Email == email && _educator.Password == password);

            return educator != null;
        }


        /// <summary>
        /// Пытается найти и извлечь студента из БД по адресу электронной почты и паролю.
        /// </summary>
        /// <param name="student">Студент.</param>
        /// <returns>True - если студент найден. False - нет.</returns>
        private bool TryGetStudent(out Student student)
        {
            string email = EmailInput.Text;
            string password = PasswordInput.Text;

            var context = new DatabaseContext();

            student = context.Students.SingleOrDefault(_student =>
                _student.Email == email && _student.Password == password);

            return student != null;
        }


        /// <summary>
        /// Осуществляет переход со страницы авторизации.
        /// </summary>
        private void RedirectFromLoginPage(string accountUrl)
        {
            string redirectUrl = Request.QueryString.Get("RedirectUrl");

            if (!string.IsNullOrEmpty(redirectUrl))
                Response.RedirectPermanent(redirectUrl);
            else
                Response.RedirectPermanent(accountUrl);
        }
    }
}
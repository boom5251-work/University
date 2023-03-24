using System;
using System.Net;
using System.Web.UI;

namespace University
{
    /// <summary>
    /// Страница ошибки.
    /// </summary>
    public partial class ErrorStatus : Page
    {
        /// <summary>
        /// Обрабатывает событие загрузки страницы.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы.</param>>
        protected void Page_Load(object sender, EventArgs e)
        {
            string RouteDataErrorCode = (string)RouteData.Values["StatusCode"];

            if (int.TryParse(RouteDataErrorCode, out int errorCode))
            {
                var statusCode = (HttpStatusCode)errorCode;

                // TODO: Изменить отображение.
                // TODO: Переписать тестовый код.
                testCode.InnerHtml = RouteDataErrorCode;
                testText.InnerHtml = statusCode.ToString();
            }
            else
            {
                // TODO: Реализовать.
            }
        }
    }
}
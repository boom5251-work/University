using System;
using System.Globalization;
using System.Web.UI;
using University.DataAccess.Models;

namespace University.Controls.Main
{
    /// <summary>
    /// Новостной блок.
    /// </summary>
    public partial class HeadlineBlock : UserControl
    {
        /// <summary>
        /// Новостная запись.
        /// </summary>
        public Headline Headline { get; set; }


        /// <summary>
        /// Обрабатывает событие загрузки элемента управления.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Headline != null)
            {
                string datePattern = "d MMMM yyyy";
                var cultureInfo = CultureInfo.GetCultureInfo("ru-RU");

                DateTimeBox.Text = Headline.PublishedAt.ToString(datePattern, cultureInfo);

                TitleBox.Text = Headline.Title;
                TextBox.Text = Headline.Text;

                Link.NavigateUrl = $"/News/Headline/{Headline.Id}";
            }             
        }
    }
}
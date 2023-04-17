using System;
using System.Web.UI;

namespace University.Controls
{
    /// <summary>
    /// Элемент представления основной информации о человеке.
    /// </summary>
    public partial class PersonInfo : UserControl
    {
        public string ImageUrl { get; set; } = "/Resources/Images/DefaultPersonPhoto.png";

        /// <summary>
        /// Полное имя.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Описание (должность, ученая степень и т.п.).
        /// </summary>
        public string Description { get; set; }




        /// <summary>
        /// Обрабатывает событие загрузки страницы.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            PersonPhoto.ImageUrl = ImageUrl;

            PersonName.InnerText = FullName;
            PersonDescription.InnerText = Description;
        }
    }
}
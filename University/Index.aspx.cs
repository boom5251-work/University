using System;
using System.Linq;
using System.Web.UI;
using University.Controls.Main;
using University.DataAccess;

namespace University
{
    /// <summary>
    /// Главная страница сайта.
    /// </summary>
    public partial class Index : Page
    {
        /// <summary>
        /// Обрабатывает событие загрузки страницы.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            var context = new DatabaseContext();

            int skipCount = Math.Max(0, context.Headlines.Count() - 10);

            var headlines = context.Headlines
                .ToList()
                .Skip(skipCount)
                .OrderBy(_headline => _headline.PublishedAt)
                .Reverse();

            foreach (var headline in headlines)
            {
                var control = LoadControl(@"~\Controls\Main\HeadlineBlock.ascx") as HeadlineBlock;
                control.Headline = headline;
                NewsContainer.Controls.Add(control);
            }
        }
    }
}
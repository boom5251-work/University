using System;
using System.Web.UI;

namespace University.Controls.Institute
{
    /// <summary>
    /// Элемент представления кафедры института.
    /// </summary>
    public partial class DepartmentBlock : UserControl
    {
        /// <summary>
        /// Название кафедры.
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Сокращенное латинское название кафедры.
        /// </summary>
        public string LatPath { get; set; }

        /// <summary>
        /// Сокращенное латинское название факультета.
        /// </summary>
        public string FacultyLatPath { get; set; }

        

        /// <summary>
        /// Обрабатывает событие загрузки страницы.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Link.NavigateUrl = $"/Department/{FacultyLatPath}/{LatPath}";
            DepartmentName.InnerText = Name;
        }
    }
}
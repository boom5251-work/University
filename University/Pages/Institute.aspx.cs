using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.UI;
using University.Controls;
using University.Controls.Institute;
using University.DataAccess;
using University.DataAccess.Models;

namespace University.Pages
{
    /// <summary>
    /// Страница институтов.
    /// </summary>
    public partial class Institute : Page
    {
        /// <summary>
        /// Обрабатывает событие загрузки страницы.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            string latPath = (string)RouteData.Values["Institute"];

            FieldsOfStudyLink.NavigateUrl = $"/FieldsOfStudy/#{latPath}";

            if (!string.IsNullOrEmpty(latPath))
            {
                // Получение основной информации.
                var context = new DatabaseContext();

                var faculty = context.Faculties
                    .Include(_faculty => _faculty.Heads.Select(head => head.Post))
                    .Include(_faculty => _faculty.Departments)
                    .SingleOrDefault(_faculty => _faculty.LatPath == latPath);

                context.Dispose();

                if (faculty != null)
                {
                    ShowMainInfo(faculty);
                    ShowHeads(faculty.Heads);

                    var departments = faculty.Departments?.Take(5);
                    ShowDepartments(departments);
                } 
                else
                {
                    // TODO: Добавить обработку ошибки.
                }
            }
            else
            {
                // TODO: Добавить обработку ошибки.
            }
        }



        #region Отображение данных.
        /// <summary>
        /// Отображает основную информацию.
        /// </summary>
        /// <param name="faculty">Факультет.</param>
        private void ShowMainInfo(Faculty faculty)
        {
            Title = faculty.Name;

            Header.InnerText = faculty.Name;
            Description.InnerText = faculty.Description;

            BaseDepartmentsLink.NavigateUrl = $"/Departments/#{faculty.LatPath}@base";
            DepartmentsLink.NavigateUrl = $"/Departments/#{faculty.LatPath}";
        }


        /// <summary>
        /// Отображает руководителей факультета.
        /// </summary>
        /// <param name="educators">Перечисление руководителей.</param>
        private void ShowHeads(IEnumerable<Educator> educators)
        {
            foreach (var educator in educators)
            {
                var personInfo = LoadControl(@"~/Controls/PersonInfo.ascx") as PersonInfo;

                if (!string.IsNullOrEmpty(educator.PhotoFileName))
                    personInfo.ImageUrl = $"/SiteData/Images/Photos/{educator.PhotoFileName}";

                personInfo.FullName = $"{educator.LastName} {educator.FirstName} {educator.MiddleName}";

                string replacement = "Зам.";

                personInfo.Description = educator.Post?.Name
                    .Replace("Заместитель", replacement)
                    .Replace("заместитель", replacement);

                HeadsContainer.Controls.Add(personInfo);
            }
        }


        /// <summary>
        /// Отображает кафедры института.
        /// </summary>
        /// <param name="departments">Перечисление кафедр.</param>
        private void ShowDepartments(IEnumerable<DataAccess.Models.Department> departments)
        {
            foreach (var department in departments)
            {
                var departmentBlock = LoadControl(@"~/Controls/Institute/DepartmentBlock.ascx") as DepartmentBlock;

                departmentBlock.Name = department.Name;
                departmentBlock.LatPath = department.LatPath;
                departmentBlock.FacultyLatPath = department.Faculty.LatPath;

                DepartmentsContainer.Controls.Add(departmentBlock);
            }
        }
        #endregion
    }
}
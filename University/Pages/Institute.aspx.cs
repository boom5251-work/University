using System;
using System.Collections.Generic;
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
                using (var context = new DatabaseContext())
                {
                    // Получение основной информации.
                    var faculty = context.Faculties.Single(_faculty => _faculty.LatPath == latPath);
                    ShowMainInfo(faculty);

                    // Получение руководителей.
                    var facultiesHeads = context.FacultiesHeads
                        .Where(item => item.FacultyId == faculty.Id)
                        .ToList();

                    facultiesHeads.ForEach((FacultyHead facultyHead) =>
                    {
                        facultyHead.Head = context.Educators.SingleOrDefault(head => head.Id == facultyHead.HeadId);
                        facultyHead.Post = context.Posts.SingleOrDefault(post => post.Id == facultyHead.PostId);
                    });

                    ShowHeads(facultiesHeads);

                    // Получение кафедр.
                    var departments = context.Departments
                        .Where(department => department.FacultyId == faculty.Id)
                        .ToList();

                    ShowDepartments(departments);
                }
            }
            else
            {
                // TODO: Добавить обработку ошибки.
            }
        }


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
        /// <param name="facultiesHeads">Список сущностей факультет-руководитель.</param>
        private void ShowHeads(List<FacultyHead> facultiesHeads)
        {
            foreach (var item in facultiesHeads)
            {
                var personInfo = LoadControl(@"~/Controls/PersonInfo.ascx") as PersonInfo;

                if (!string.IsNullOrEmpty(item.Head.PhotoFileName))
                    personInfo.ImageUrl = $"/SiteData/Images/Photos/{item.Head.PhotoFileName}";

                personInfo.FullName = $"{item.Head?.LastName} {item.Head?.FirstName} {item.Head?.MiddleName}";

                personInfo.Description = item.Post?.Name
                    .Replace("Заместитель", "Зам.")
                    .Replace("заместитель", "зам.");

                HeadsContainer.Controls.Add(personInfo);
            }
        }


        /// <summary>
        /// Отображает кафедры института.
        /// </summary>
        /// <param name="departments">Список кафедр.</param>
        private void ShowDepartments(List<DataAccess.Models.Department> departments)
        {
            string value = "базовая кафедра";

            var firstFiveDepartments = departments
                .Where(department => department.Name.IndexOf(value, StringComparison.OrdinalIgnoreCase) == -1)
                .OrderBy(department => department.Name)
                .Take(5)
                .ToList();

            foreach (var department in firstFiveDepartments)
            {
                var departmentBlock = LoadControl(@"~/Controls/Institute/DepartmentBlock.ascx") as DepartmentBlock;

                departmentBlock.Name = department.Name;
                departmentBlock.LatPath = department.LatPath;
                departmentBlock.FacultyLatPath = department.Faculty.LatPath;

                DepartmentsContainer.Controls.Add(departmentBlock);
            }
        }
    }
}
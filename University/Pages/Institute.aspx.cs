using System;
using System.Linq;
using System.Web.UI;
using University.DataAccess;

namespace University.Pages
{
    public partial class Institute : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string latPath = (string)RouteData.Values["Institute"];

            if (!string.IsNullOrEmpty(latPath))
            {
                var context = new DatabaseContext();

                var faculty = context.Faculties.Single(item => item.LatPath == latPath);

                Title = faculty.Name;

                test.Controls.Add(new LiteralControl($"<h1>{faculty.Name}</h1>"));
                test.Controls.Add(new LiteralControl($"<p>{faculty.Description}</p>"));


                test.Controls.Add(new LiteralControl("<h3>Направления</h3>"));

                var fieldOfStudyIds = context.FacultyFields.Where(x => x.FacultyId == faculty.Id)
                                                           .Select(item => item.FieldOfStudyId);

                var fieldsOfStudy = context.FieldsOfStudy.Where(item => fieldOfStudyIds.Contains(item.Id));

                foreach (var fieldOfStudy in fieldsOfStudy)
                    test.Controls.Add(new LiteralControl($"<a href=\"/Program/{faculty.LatPath}/" + 
                        $"{fieldOfStudy.Code.Replace('.', '-')}\">" +
                        $"<h4>{fieldOfStudy.Code} {fieldOfStudy.Name}</h4></a>"));

                test.Controls.Add(new LiteralControl("<h3>Кафедры</h3>"));

                var departments = context.Departments.Where(item => item.FacultyId == faculty.Id).ToList();

                foreach (var department in departments)
                    test.Controls.Add(new LiteralControl($"<a href=\"/Department/{faculty.LatPath}/{department.LatPath}\">" + 
                        $"<h4>{department.Name}</h4></a>"));

            }
            else
            {
                // TODO: Добавить обработку ошибки.
            }
        }
    }
}
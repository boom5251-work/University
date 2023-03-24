using System;
using System.Linq;
using System.Web.UI;
using University.DataAccess;

namespace University.Pages
{
    public partial class TrainingProgram : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string latPath = (string)RouteData.Values["Institute"];
            string code = ((string)RouteData.Values["Code"])?.Replace('-', '.');

            if (!string.IsNullOrEmpty(latPath) && !string.IsNullOrEmpty(code))
            {
                var context = new DatabaseContext();

                var faculty = context.Faculties.Single(item => item.LatPath == latPath);
                var fieldOfStudyIds = context.FacultyFields.Where(item => item.FacultyId == faculty.Id)
                                                           .Select(item => item.FieldOfStudyId)
                                                           .ToList();

                var fieldOfStudy = context.FieldsOfStudy.Where(item => fieldOfStudyIds.Contains(item.Id))
                                                        .SingleOrDefault(item => item.Code == code);

                if (fieldOfStudy != null)
                {
                    Title = $"{faculty.Name}: {fieldOfStudy.Code} — {fieldOfStudy.Name}";
                    test.Controls.Add(new LiteralControl($"<h1>{fieldOfStudy.Code} — {fieldOfStudy.Name}</h1>"));
                    test.Controls.Add(new LiteralControl($"<p>{fieldOfStudy.Description}</p>"));
                }
            }
        }
    }
}
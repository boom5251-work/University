using System;
using System.Linq;
using System.Web.UI;
using University.DataAccess;

namespace University.Pages
{
    public partial class Department : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string inst = (string)RouteData.Values["Institute"];
            string dep = (string)RouteData.Values["Department"];

            if (!string.IsNullOrEmpty(inst) && !string.IsNullOrEmpty(dep))
            {
                var context = new DatabaseContext();

                var faculty = context.Faculties.Single(item => item.LatPath == inst);

                var department = context.Departments.SingleOrDefault(item => item.LatPath == dep);

                Title = $"{faculty.Name}: {department.Name}";

                var head = context.Educators.SingleOrDefault(item => item.Id == department.HeadId);

                if (department.FacultyId == faculty.Id)
                {
                    test.Controls.Add(new LiteralControl($"<h1>{department.Name}</h1>"));
                    test.Controls.Add(new LiteralControl($"<h3>Заведующий кафедрой: {head.LastName} {head.FirstName} {head.MiddleName}</h3>"));
                }

                context.Dispose();
            }
        }
    }
}
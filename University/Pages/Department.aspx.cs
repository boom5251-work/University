using System;
using System.Data.Entity;
using System.Linq;
using System.Web.UI;
using University.DataAccess;

namespace University.Pages
{
    public partial class Department : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // TODO: Реализовать отображение содержимого.
            string institute = (string)RouteData.Values["Institute"];
            string dep = (string)RouteData.Values["Department"];

            if (!string.IsNullOrEmpty(institute) && !string.IsNullOrEmpty(dep))
            {
                var context = new DatabaseContext();

                var faculty = context.Faculties.Single(item => item.LatPath == institute);

                var department = context.Departments.Include(_dep => _dep.Head.Post)
                    .SingleOrDefault(item => item.LatPath == dep);

                Title = $"{faculty.Name}: {department.Name}";

                test.Controls.Add(new LiteralControl($"<h1>{department.Name}</h1>"));
                test.Controls.Add(new LiteralControl($"<h3>Заведующий кафедрой: {department.Head.LastName} {department.Head.FirstName} {department.Head.MiddleName}</h3>"));

                context.Dispose();
            }
        }
    }
}
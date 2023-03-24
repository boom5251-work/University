using System;
using System.Linq;
using System.Web.UI;
using University.DataAccess;

namespace University
{
    public partial class Index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var context = new DatabaseContext();
            var faculties = context.Faculties.ToList();

            foreach (var faculty in faculties)
                test.Controls.Add(new LiteralControl($"<div><a href=\"/Institute/{faculty.LatPath}\">{faculty.Name}</a></div>"));
        }
    }
}
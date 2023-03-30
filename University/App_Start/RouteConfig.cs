using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace University
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);

            // �������� ������.
            routes.MapPageRoute(
                "ErrorByErrorCode",
                "Status/{StatusCode}",
                "~/ErrorStatus.aspx"
            );

            // �������� �����������.
            routes.MapPageRoute(
                "InstituteByInstituteLatPath",
                "Institute/{Institute}",
                "~/Pages/Institute.aspx"
            );

            // �������� ����������� ���������� �����������.
            routes.MapPageRoute(
                "InstituteByInstituteLatPathAndCode",
                "Program/{Institute}/{Code}",
                "~/Pages/TrainingProgram.aspx"
            );

            // �������� ������ ����������.
            routes.MapPageRoute(
                "DepartmentByInstituteAndDepartmentLatPath",
                "Department/{Institute}/{Department}",
                "~/Pages/Department.aspx"
            );

            // ����������� ������������.
            routes.MapPageRoute(
                "Login",
                "Login",
                "~/Pages/Account/Login.aspx"
            );

            // ������ ������� �������������.
            routes.MapPageRoute(
                "EducatorAccount",
                "Account/Educator",
                "~/Pages/Account/EducatorAccount.aspx"
            );

            // ������ ������� ��������.
            routes.MapPageRoute(
                "StudentAccount",
                "Account/Student",
                "~/Pages/Account/StudentAccount.aspx"
            );

            // ��� �������.
            routes.MapPageRoute(
                "News",
                "News",
                "~/Pages/News/News.aspx"
            );

            // ��������� ������.
            routes.MapPageRoute(
                "HeadlineById",
                "News/Headline/{id}",
                "~/Pages/News/Headline.aspx"
            );
        }
    }
}

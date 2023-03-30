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

            // Страница ошибок.
            routes.MapPageRoute(
                "ErrorByErrorCode",
                "Status/{StatusCode}",
                "~/ErrorStatus.aspx"
            );

            // Страница факультетов.
            routes.MapPageRoute(
                "InstituteByInstituteLatPath",
                "Institute/{Institute}",
                "~/Pages/Institute.aspx"
            );

            // Страница направлений подготовки факультетов.
            routes.MapPageRoute(
                "InstituteByInstituteLatPathAndCode",
                "Program/{Institute}/{Code}",
                "~/Pages/TrainingProgram.aspx"
            );

            // Страница кафедр институтов.
            routes.MapPageRoute(
                "DepartmentByInstituteAndDepartmentLatPath",
                "Department/{Institute}/{Department}",
                "~/Pages/Department.aspx"
            );

            // Авторизация пользователя.
            routes.MapPageRoute(
                "Login",
                "Login",
                "~/Pages/Account/Login.aspx"
            );

            // Личный кабинет преподавателя.
            routes.MapPageRoute(
                "EducatorAccount",
                "Account/Educator",
                "~/Pages/Account/EducatorAccount.aspx"
            );

            // Личный кабинет студента.
            routes.MapPageRoute(
                "StudentAccount",
                "Account/Student",
                "~/Pages/Account/StudentAccount.aspx"
            );

            // Все новости.
            routes.MapPageRoute(
                "News",
                "News",
                "~/Pages/News/News.aspx"
            );

            // Новостная запись.
            routes.MapPageRoute(
                "HeadlineById",
                "News/Headline/{id}",
                "~/Pages/News/Headline.aspx"
            );
        }
    }
}

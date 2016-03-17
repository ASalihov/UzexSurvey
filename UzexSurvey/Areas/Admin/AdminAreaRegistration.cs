using System.Web.Mvc;

namespace UzexSurvey.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                name: "admin",
                url: "Admin/{controller}/{action}/{id}",
                defaults: new { action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "UzexSurvey.Areas.Admin.Controllers" }
            );
            
        }
    }
}
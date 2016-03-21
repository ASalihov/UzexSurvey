using System.Linq;
using System.Web.Mvc;
using DAL;

namespace UzexSurvey.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        AppDbContext context = new AppDbContext();
        // GET: Admin/Admin
        public ActionResult Index()
        {
            var list = context.Quizes.ToList();
            return View(list);
        }
    }
}
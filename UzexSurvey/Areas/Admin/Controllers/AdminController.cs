using System.Linq;
using System.Web.Mvc;
using DAL;

namespace UzexSurvey.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        UoW uow = new UoW(new AppDbContext());
        // GET: Admin/Admin
        public ActionResult Index()
        {
            var list = uow.Quizes.GetAll();
            return View(list);
        }
    }
}
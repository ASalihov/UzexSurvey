using System.Linq;
using System.Web.Mvc;
using DAL;
using DAL.Contracts;

namespace UzexSurvey.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        private IUoW _uow;

        public AdminController(IUoW uow)
        {
            _uow = uow;
        }

        // GET: Admin/Admin
        public ActionResult Index()
        {
            var list = _uow.Quizes.GetAll();
            return View(list);
        }
    }
}
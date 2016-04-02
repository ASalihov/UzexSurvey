using DAL.Contracts;
using DAL.ViewModels;
using System.Web.Mvc;
using UzexSurvey.Areas.Admin.Controllers;

namespace UzexSurvey.Controllers
{
    public class QuizController : BaseController
    {
        public QuizController(IUoW uow)
            : base(uow)
        {

        }
        public ActionResult Index()
        {
            return View(_uow.Quizes.GetNotEmpties());
        }


        // GET: Quiz/PassQuiz
        public ActionResult PassQuiz(int id)
        {
            ViewBag.Message = "Your application description page.";
            QuizViewModel quiz = _uow.Quizes.GetQuizViewModel(id);
            return View(quiz);
        }


        // POST: Quiz/PassQuiz
        [HttpPost]
        public ActionResult PassQuiz(QuizViewModel quizVm)
        {
            _uow.Answers.SavePassedQuiz(quizVm);
            _uow.Complete();
            return RedirectToAction("Index");
        }

        public ActionResult GetPartialByOptionType(QuizViewModel vm, int questionId, int optionId)
        {
            ViewBag.questionId = questionId;
            ViewBag.optionId = optionId;
            return PartialView("_GetPartialByOptionType", vm);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
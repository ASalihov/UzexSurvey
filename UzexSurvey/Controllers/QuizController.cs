using DAL.Contracts;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            QuizViewModel quiz = _uow.Quizes.GetQuizToPass(id);
            return View(quiz);
        }


        // POST: Quiz/PassQuiz
        [HttpPost]
        public ActionResult PassQuiz(QuizViewModel quizVm)
        {
            _uow.Quizes.SavePassedQuiz(quizVm);
            return RedirectToAction("Index");
        }

        public ActionResult GetPartialByOptionType(QuizViewModel vm, int i, int j)
        {
            ViewBag.i = i;
            ViewBag.j = j;
            return PartialView("_GetPartialByOptionType", vm);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
using DAL.Contracts;
using DAL.Entities;
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
            return View(_uow.Quizes.GetAll());
        }

        public ActionResult PassQuiz(int id)
        {
            ViewBag.Message = "Your application description page.";
            Quiz quiz = _uow.Quizes.GetById(id);
            return View(quiz);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
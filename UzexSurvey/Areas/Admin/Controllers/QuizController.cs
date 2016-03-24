using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Contracts;
using DAL.Entities;

namespace UzexSurvey.Areas.Admin.Controllers
{
    public class QuizController : BaseController
    {
        public QuizController (IUoW uow)
            :base(uow)
	    {
	    }

        // GET: Admin/Quiz
        public ActionResult Index()
        {
            return View(_uow.Quizes.GetAll());
        }

        // GET: Admin/Quiz/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Quiz/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Quiz/Create
        [HttpPost]
        public ActionResult Create(Quiz quiz)
        {
            _uow.Quizes.Add(quiz);
            _uow.Complete();
            return RedirectToAction("Index");
        }
        

        // GET: Admin/Quiz/Edit/5
        public ActionResult Edit(int quizId)
        {
            Quiz quiz = _uow.Quizes.GetById(quizId);
            return View(quiz);
        }

        // POST: Admin/Quiz/Edit/5
        [HttpPost]
        public ActionResult Edit(Quiz quiz)
        {
            _uow.Quizes.Update(quiz);
            _uow.Complete();
            return RedirectToAction("Index");
        }

        // GET: Admin/Quiz/Delete/5
        public ActionResult Delete(int quizId)
        {
            _uow.Quizes.Delete(quizId);
            _uow.Complete();
            return RedirectToAction("Index");
        }
    }
}

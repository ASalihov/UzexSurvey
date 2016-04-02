using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Contracts;
using DAL.Entities;

namespace UzexSurvey.Areas.Admin.Controllers
{
    public class QuestionController : BaseController
    {
        public QuestionController(IUoW uow)
            :base(uow)
	    {
	    }
        // GET: Admin/Question
        public ActionResult Index(int id)
        {
            var questions = _uow.Questions.GetByQuizId(id);
            ViewBag.QuizName = _uow.Quizes.GetById(id).Name;
            ViewBag.QuizId = id;
            return View(questions);
        }

        // GET: Admin/Question/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Question/Create
        public ActionResult Create(int quizId)
        {
            var question = new Question();
            question.QuizId = quizId;
            return PartialView("_Create", question);
        }

        // POST: Admin/Question/Create
        [HttpPost]
        public ActionResult Create(Question question)
        {
            var quizid = question.QuizId;
            if (ModelState.IsValid)
            {
                _uow.Questions.Add(question);
                _uow.Complete();
                return RedirectToAction("Index", new {id = quizid});
            }

            return RedirectToAction("Index", new { id = quizid });
    }

        // GET: Admin/Question/Edit/5
        public ActionResult Edit(int id)
        {
            Question question = _uow.Questions.GetById(id);
            return View(question);
        }

        // POST: Admin/Question/Edit/5
        [HttpPost]
        public ActionResult Edit(Question question)
        {
            if (ModelState.IsValid)
            {
                _uow.Questions.Update(question);
                _uow.Complete();
                return RedirectToAction("Index", new {id = question.QuizId});
            }

            return RedirectToAction("Index", new { id = question.QuizId });
        }

        // GET: Admin/Question/Delete/5
        public ActionResult Delete(int id)
        {

            var quizId = _uow.Questions.GetById(id).QuizId;
            _uow.Questions.Delete(id);
            _uow.Complete();
            return RedirectToAction("Index", new { id = quizId });
        }

    }
}

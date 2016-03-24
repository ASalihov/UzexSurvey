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
        public ActionResult Index(int quizId)
        {
            ViewBag.quizId = quizId;
            return View(_uow.Questions.GetByQuiz(quizId));
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
            return View(question);
        }

        // POST: Admin/Question/Create
        [HttpPost]
        public ActionResult Create(Question question)
        {
            _uow.Questions.Add(question);
            _uow.Complete();
            return RedirectToAction("Index", new { quizId = question.QuizId});
        }

        // GET: Admin/Question/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Question/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Question/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Question/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Quiz/Edit/5
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

        // GET: Admin/Quiz/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Quiz/Delete/5
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

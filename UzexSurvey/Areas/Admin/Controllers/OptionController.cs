using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Contracts;
using DAL.Entities;

namespace UzexSurvey.Areas.Admin.Controllers
{
    public class OptionController : BaseController
    {
        public OptionController(IUoW uow)
            : base(uow)
        {
        }

        // GET: Admin/Option
        public ActionResult Index(int id)
        {
            ViewBag.QiestionId = id;
            var Options = _uow.Options.GetByQuestionId(id);
            return PartialView("_Index", Options);
        }

        // GET: Admin/Option/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Option/Create
        public ActionResult Create(int id)
        {
            Option Option = new Option();
            Option.QuestionId = id;
            return PartialView("_Create", Option);
        }

        // POST: Admin/Option/Create
        [HttpPost]
        public ActionResult Create(Option Option)
        {
            var questionId = Option.QuestionId;
            _uow.Options.Add(Option);
            _uow.Complete();
            return RedirectToAction("Edit", "Question", new { id = questionId });
        }

        // GET: Admin/Option/Edit/5
        public ActionResult Edit(int id)
        {
            Option Option = _uow.Options.GetById(id);
            return PartialView("_Edit", Option);
        }

        // POST: Admin/Option/Edit/5
        [HttpPost]
        public ActionResult Edit(Option Option)
        {
            _uow.Options.Update(Option);
            _uow.Complete();
            return RedirectToAction("Edit", "Question", new { id = Option.QuestionId });
        }

        // GET: Admin/Option/Delete/5
        public ActionResult Delete(int id)
        {
            var questionId = _uow.Options.GetById(id).QuestionId;
            _uow.Options.Delete(id);
            _uow.Complete();
            return RedirectToAction("Edit", "Question", new { id = questionId });
        }

        // POST: Admin/Option/Delete/5
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

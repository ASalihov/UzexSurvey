using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Contracts;
using DAL.Entities;

namespace UzexSurvey.Areas.Admin.Controllers
{
    public class AnswerController : BaseController
    {
        public AnswerController(IUoW uow)
            :base(uow)
	    {
	    }

        // GET: Admin/Answer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Answer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Answer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Answer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Answer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Answer/Edit/5
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

        // GET: Admin/Answer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Answer/Delete/5
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

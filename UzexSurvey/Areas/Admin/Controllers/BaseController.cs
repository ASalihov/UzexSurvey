using DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UzexSurvey.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
         protected IUoW _uow;

         public BaseController(IUoW uow)
         {
             _uow = uow;
         }
    }
}
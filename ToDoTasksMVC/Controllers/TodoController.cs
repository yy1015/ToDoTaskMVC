using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoTasksMVC.Models.ViewModels;

namespace ToDoTasksMVC.Controllers
{
    public class TodoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(AddTaskViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            return RedirectToAction("Index");
        }
    }
}
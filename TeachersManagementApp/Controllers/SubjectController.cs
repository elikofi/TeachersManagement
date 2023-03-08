using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeachersManagementApp.Models.Domain;
using TeachersManagementApp.Repositories.Abstract;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TeachersManagementApp.Controllers
{
    public class SubjectController : Controller
    {
        private readonly ISubjectService service;

        public SubjectController(ISubjectService service)
        {
            this.service = service;
        }

        // GET: /<controller>/

        //Add method
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Subject model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = service.Add(model);
            if (result)
            {
                TempData["msg"] = "New subject added.";
                return RedirectToAction(nameof(Add));
            }
            TempData["msg"] = "Failed to add. Error occured on server side.";
            return View(model);
        }

        //Update method
        public IActionResult Update(int id)
        {
            var record = service.FindById(id);
            return View(record);
        }

        [HttpPost]
        public IActionResult Update(Subject model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = service.Update(model);
            if (result)
            {
                TempData["msg"] = "Subject successfully updated.";
                return RedirectToAction(nameof(Add));
            }
            TempData["msg"] = "Failed to update. Error occured on server side.";
            return View(model);
        }

        //Delete method
        public IActionResult Delete(int id)
        {
            var result = service.Delete(id);
            return RedirectToAction("GetAll");
        }

        //Get all method
        public IActionResult GetAll()
        {
            var data = service.GetAll().OrderBy(data => data.SubjectName).ToList();
            return View(data);
        }
    }
}


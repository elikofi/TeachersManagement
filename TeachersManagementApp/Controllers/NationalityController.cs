using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using TeachersManagementApp.Models.Domain;
using TeachersManagementApp.Repositories.Abstract;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TeachersManagementApp.Controllers
{
    public class NationalityController : Controller
    {
        private readonly INationalityService service;
        public NationalityController(INationalityService service)
        {
            this.service = service;
        }

        // GET: /<controller>/
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Nationality model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = service.Add(model);
            if (result)
            {
                TempData["msg"] = "New nationality added.";
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
        public IActionResult Update(Nationality model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = service.Update(model);
            if (result)
            {
                TempData["msg"] = "Nationality successfully updated.";
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
            var data = service.GetAll().OrderBy(data => data.NationalityName).ToList();
            return View(data);
        }
    }
}


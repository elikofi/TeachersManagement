using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TeachersManagementApp.Models.Domain;
using TeachersManagementApp.Repositories.Abstract;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TeachersManagementApp.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherService teacherService;
        private readonly ISubjectService subjectService;
        private readonly INationalityService nationalityService;
        private readonly IGenderService genderService;
        private readonly IRoleService roleService;
        private readonly IQualificationService qualificationService;

        public TeacherController(ITeacherService teacherService, ISubjectService subjectService, INationalityService nationalityService, IGenderService genderService, IRoleService roleService, IQualificationService qualificationService)
        {
            this.teacherService = teacherService;
            this.subjectService = subjectService;
            this.nationalityService = nationalityService;
            this.genderService = genderService;
            this.roleService = roleService;
            this.qualificationService = qualificationService;
        }
        // GET: /<controller>/

        //Add methods
        public IActionResult Add()
        {
            var model = new Teacher();
            model.SubjectList = subjectService.GetAll().Select(a => new SelectListItem { Text = a.SubjectName, Value = a.Id.ToString() }).ToList();
            model.NationalityList = nationalityService.GetAll().Select(a => new SelectListItem { Text = a.NationalityName, Value = a.Id.ToString() }).ToList();
            model.GenderList = genderService.GetAll().Select(a => new SelectListItem { Text = a.GenderName, Value = a.Id.ToString() }).ToList();
            model.RoleList = roleService.GetAll().Select(a => new SelectListItem { Text = a.RoleName, Value = a.Id.ToString() }).ToList();
            model.QualificationList = qualificationService.GetAll().Select(a => new SelectListItem { Text = a.QualificationName, Value = a.Id.ToString() }).ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(Teacher model)
        {
            model.SubjectList = subjectService.GetAll().Select(a => new SelectListItem { Text = a.SubjectName, Value = a.Id.ToString(), Selected=a.Id==model.SubjectId }).ToList();
            model.NationalityList = nationalityService.GetAll().Select(a => new SelectListItem { Text = a.NationalityName, Value = a.Id.ToString(), Selected = a.Id == model.NationalityId }).ToList();
            model.GenderList = genderService.GetAll().Select(a => new SelectListItem { Text = a.GenderName, Value = a.Id.ToString(), Selected = a.Id == model.GenderId }).ToList();
            model.RoleList = roleService.GetAll().Select(a => new SelectListItem { Text = a.RoleName, Value = a.Id.ToString(), Selected = a.Id == model.RoleId }).ToList();
            model.QualificationList = qualificationService.GetAll().Select(a => new SelectListItem { Text = a.QualificationName, Value = a.Id.ToString(), Selected = a.Id == model.QualificationId }).ToList();
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = teacherService.Add(model);
            if (result)
            {
                TempData["msg"] = "New teacher Added.";
                return RedirectToAction(nameof(Add));
            }
            TempData["msg"] = "Failed to add. Error occured on server side.";
            return View(model);
        }

        //Update method
        public IActionResult Update(int id)
        {
            var model = teacherService.FindById(id);
            model.SubjectList = subjectService.GetAll().Select(a => new SelectListItem { Text = a.SubjectName, Value = a.Id.ToString(), Selected = a.Id == model.SubjectId }).ToList();
            model.NationalityList = nationalityService.GetAll().Select(a => new SelectListItem { Text = a.NationalityName, Value = a.Id.ToString(), Selected = a.Id == model.NationalityId }).ToList();
            model.GenderList = genderService.GetAll().Select(a => new SelectListItem { Text = a.GenderName, Value = a.Id.ToString(), Selected = a.Id == model.GenderId }).ToList();
            model.RoleList = roleService.GetAll().Select(a => new SelectListItem { Text = a.RoleName, Value = a.Id.ToString(), Selected = a.Id == model.RoleId }).ToList();
            model.QualificationList = qualificationService.GetAll().Select(a => new SelectListItem { Text = a.QualificationName, Value = a.Id.ToString(), Selected = a.Id == model.QualificationId }).ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Teacher model)
        {
            model.SubjectList = subjectService.GetAll().Select(a => new SelectListItem { Text = a.SubjectName, Value = a.Id.ToString(), Selected = a.Id == model.SubjectId }).ToList();
            model.NationalityList = nationalityService.GetAll().Select(a => new SelectListItem { Text = a.NationalityName, Value = a.Id.ToString(), Selected = a.Id == model.NationalityId }).ToList();
            model.GenderList = genderService.GetAll().Select(a => new SelectListItem { Text = a.GenderName, Value = a.Id.ToString(), Selected = a.Id == model.GenderId }).ToList();
            model.RoleList = roleService.GetAll().Select(a => new SelectListItem { Text = a.RoleName, Value = a.Id.ToString(), Selected = a.Id == model.RoleId }).ToList();
            model.QualificationList = qualificationService.GetAll().Select(a => new SelectListItem { Text = a.QualificationName, Value = a.Id.ToString(), Selected = a.Id == model.QualificationId }).ToList();
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = teacherService.Update(model);
            if (result)
            {
                TempData["msg"] = "Teacher details successfully updated.";
                return RedirectToAction(nameof(Add));
            }
            TempData["msg"] = "Failed to update. Error occure on server side.";
            return View(model);
        }

        //Delete method
        public IActionResult Delete(int id)
        {
            var result = teacherService.Delete(id);
            return RedirectToAction("GetAll");
        }

        //Get all method
        public IActionResult GetAll()
        {
            var data = teacherService.GetAll().OrderBy(data => data.Name).ToList();
            return View(data);
        }
    }
}


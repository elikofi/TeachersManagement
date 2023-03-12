using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TeachersManagementApp.Models;
using TeachersManagementApp.Repositories.Abstract;

namespace TeachersManagementApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

//public class HomeController : Controller
//{
//    private readonly ITeacherService teacherService;

//    public HomeController(ITeacherService teacherService)
//    {
//        this.teacherService = teacherService;
//    }

//    public IActionResult Index(string term="")
//    {
//        var teachers = teacherService.List();
//        return View(teacherService);
//    }

//    public IActionResult Privacy()
//    {
//        return View();
//    }

//    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//    public IActionResult Error()
//    {
//        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//    }
//}


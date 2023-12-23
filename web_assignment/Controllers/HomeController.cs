using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using web_assignment.Models;

namespace web_assignment.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult About()
    {
        return View();
    }
}


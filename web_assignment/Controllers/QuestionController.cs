using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using web_assignment.Models;

namespace web_assignment.Controllers;

public class QuestionController : Controller
{
    private readonly ILogger<HomeController> _logger;

	public QuestionController(ILogger<HomeController> logger)
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

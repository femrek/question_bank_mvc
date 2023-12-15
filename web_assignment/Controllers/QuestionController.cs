using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using web_assignment.Data;
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
        QuestionModel sampleData = new QuestionModel();
        sampleData.QuestionModelId = 1;
        sampleData.title = "Question Title";
        sampleData.content = "Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content ";
        sampleData.correctOption = "the correct option";
        sampleData.optionOne = "wrong option One";
        sampleData.optionTwo = "wrong option Two";
        sampleData.optionThree = "wrong option Three";
        List<QuestionModel> data = new List<QuestionModel>();
        data.Add(sampleData);
        data.Add(sampleData);
        data.Add(sampleData);
        data.Add(sampleData);
        return View(data);
    }

    public IActionResult Editor()
    {
        return View();
    }
    public IActionResult Viewer()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

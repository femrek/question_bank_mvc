using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using web_assignment.Data;
using web_assignment.Models;

namespace web_assignment.Controllers;

public class QuestionController : Controller
{
    private readonly ILogger<QuestionController> _logger;
    private readonly DataContext _context;

	public QuestionController(ILogger<QuestionController> logger, DataContext context)
    { 
        _context = context;
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
    [HttpGet]
    public IActionResult Editor()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Editor(QuestionModel model)
    {
        if(ModelState.IsValid)
        {
            var question = new QuestionModel
            {
                title = model.title,
                content = model.content,
                correctOption = model.correctOption,
                optionOne = model.optionOne,
                optionTwo = model.optionTwo,
                optionThree = model.optionThree
            };

            _context.QuestionModels.Add(question);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        return View(model);
    }
    public IActionResult Viewer(int id)
    {
        //var question = _context.QuestionModels.FirstOrDefault(q => q.QuestionModelId == id);
        QuestionModel sampleData = new QuestionModel();
        sampleData.QuestionModelId = 1;
        sampleData.title = "Question Title";
        sampleData.content = "Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content Question Content ";
        sampleData.correctOption = "the correct option";
        sampleData.optionOne = "wrong option One";
        sampleData.optionTwo = "wrong option Two";
        sampleData.optionThree = "wrong option Three";
        return View(sampleData);
    }
}

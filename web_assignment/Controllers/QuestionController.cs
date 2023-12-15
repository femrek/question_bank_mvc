using System;
using Microsoft.AspNetCore.Mvc;
using web_assignment.Models; 
using System;
using web_assignment.Data;

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
        return View();
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
    public IActionResult Viewer()
    {

        return View();
    }
}

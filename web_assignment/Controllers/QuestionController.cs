using Microsoft.AspNetCore.Mvc;
using web_assignment.Data;

namespace web_assignment.Controllers;

public class QuestionController : Controller
{
    private readonly DataContext _context;

    // Constructor for the QuestionController class
    // Parameter:
    //   context: DataContext instance for database interaction
    public QuestionController(DataContext context)
    {
        _context = context;
    }

    // Fetch all questions and send it to view as list.
    public IActionResult Index()
    {
        var questions = _context.QuestionModels.ToList();
        return View(questions);
    }

    public IActionResult Editor()
    {
        return View();
    }

    // Saves given data to db. 
    [HttpPost]
    public IActionResult Editor(QuestionModel model)
    {
        // Saves the given model into db and redirect to home page.
        if (ModelState.IsValid)
        {
            _context.QuestionModels.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home"); 
        }

        // If form is not valid add error messages into viewbag, then shows with error message.
        ViewBag.editorValidationMessages = ModelState;
        return View(model);
    }

    // Shows the question with given id. If id is null, then recalls itself with random id form db.
    public IActionResult Viewer(int? id)
    {
        // Find a random id from db table if the id parameter is not given.
        // Then redirect back with id parameter.
        if(id == null)
        {
            Random random = new Random();
            int questionCount = _context.QuestionModels.Count();
            if (questionCount <= 0) {
                return NotFound();
            }
            int randomNum = random.Next(1, questionCount + 1);
            id = _context.QuestionModels.Skip(randomNum - 1).Select(e => e.QuestionModelId).FirstOrDefault();

            // Redirect to viewer page but with definite id.
            return RedirectToAction("Viewer", new { id = id });
        }

        // Reads the question with given id form db.
        var question = _context.QuestionModels.FirstOrDefault(q => q.QuestionModelId == id);
        return View(question);
    }
}

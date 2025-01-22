using CorePortfolio.Business.Abstract;
using CorePortfolio.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
public class ExperiencesController : Controller
{
    private readonly IExperinceService _experinceService;

    public ExperiencesController(IExperinceService experinceService)
    {
        _experinceService = experinceService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var experiences = _experinceService.GetList();
        return View(experiences);
    }

    [HttpGet]
    public IActionResult CreateExperience()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateExperience(Experience experience)
    {
        _experinceService.Insert(experience);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult GetExperience(int id)
    {
        var experience = _experinceService.GetById(id);
        return View(experience);
    }

    [HttpPost]
    public IActionResult UpdateExperience(Experience experience)
    {
        _experinceService.Update(experience);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult RemoveExperience(int id)
    {
        var experience = _experinceService.GetById(id);
        _experinceService.Delete(experience);
        return RedirectToAction(nameof(Index));
    }
}
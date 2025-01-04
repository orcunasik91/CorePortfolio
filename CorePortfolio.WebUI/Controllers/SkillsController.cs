using CorePortfolio.Business.Abstract;
using CorePortfolio.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.Controllers;
public class SkillsController : Controller
{
    private readonly ISkillService _skillService;

    public SkillsController(ISkillService skillService)
    {
        _skillService = skillService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var skills = _skillService.GetList();
        return View(skills);
    }

    [HttpGet]
    public IActionResult CreateSkill()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateSkill(Skill skill)
    {
        _skillService.Insert(skill);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult GetSkill(int id)
    {
        var skill = _skillService.GetById(id);
        return View(skill);
    }

    [HttpPost]
    public IActionResult UpdateSkill(Skill skill)
    {
        _skillService.Update(skill);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult RemoveSkill(int id)
    {
        var skill = _skillService.GetById(id);
        _skillService.Delete(skill);
        return RedirectToAction(nameof(Index));
    }
}
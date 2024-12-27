using CorePortfolio.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.ViewComponents.Skill;
public class SkillSection : ViewComponent
{
    private readonly ISkillService _skillService;

    public SkillSection(ISkillService skillService)
    {
        _skillService = skillService;
    }
    public IViewComponentResult Invoke()
    {
        var skills = _skillService.GetList();
        return View(skills);
    }
}
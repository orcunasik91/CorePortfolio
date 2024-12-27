using CorePortfolio.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.ViewComponents.Experience;
public class ExperienceSection : ViewComponent
{
    private readonly IExperinceService _experinceService;

    public ExperienceSection(IExperinceService experinceService)
    {
        _experinceService = experinceService;
    }

    public IViewComponentResult Invoke()
    {
        var experiences = _experinceService.GetList();
        return View(experiences);
    }
}
using CorePortfolio.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.Areas.Admin.ViewComponents.Dashboard;
public class Experiences : ViewComponent
{
    private readonly IExperinceService experinceService;

    public Experiences(IExperinceService _experinceService)
    {
        experinceService = _experinceService;
    }

    public IViewComponentResult Invoke()
    {
        var experiences = experinceService.GetList();
        return View(experiences);
    }
}
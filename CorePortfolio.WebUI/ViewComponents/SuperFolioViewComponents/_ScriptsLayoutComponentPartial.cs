using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.ViewComponents.SuperFolioViewComponents;
public class _ScriptsLayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
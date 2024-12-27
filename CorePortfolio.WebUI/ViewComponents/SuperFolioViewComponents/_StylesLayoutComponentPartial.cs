using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.ViewComponents.SuperFolioViewComponents;
public class _StylesLayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
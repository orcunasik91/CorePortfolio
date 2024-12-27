using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.ViewComponents.SuperFolioViewComponents;
public class _HeadLayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.ViewComponents.SuperFolioViewComponents;
public class _FooterLayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
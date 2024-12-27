using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.ViewComponents.SuperFolioViewComponents;
public class _NavbarLayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
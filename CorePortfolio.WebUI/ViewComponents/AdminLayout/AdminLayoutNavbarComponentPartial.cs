using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.ViewComponents.AdminLayout;
public class AdminLayoutNavbarComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
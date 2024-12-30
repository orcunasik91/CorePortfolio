using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.ViewComponents.AdminLayout;
public class AdminLayoutHeaderBreadcrumbComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
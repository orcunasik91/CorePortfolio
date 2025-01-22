using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.Areas.Admin.ViewComponents.AdminLayout;
public class AdminLayoutStylesComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}

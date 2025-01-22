using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.Areas.Admin.ViewComponents.AdminLayout;
public class AdminLayoutFooterComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}

using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.ViewComponents.AdminLayout;
public class AdminLayoutFooterComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}

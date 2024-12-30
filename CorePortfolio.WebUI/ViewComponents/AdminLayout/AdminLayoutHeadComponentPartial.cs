using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.ViewComponents.AdminLayout;
public class AdminLayoutHeadComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}

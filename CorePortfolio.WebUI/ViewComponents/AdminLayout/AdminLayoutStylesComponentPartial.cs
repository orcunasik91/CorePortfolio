using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.ViewComponents.AdminLayout;
public class AdminLayoutStylesComponentPartial : ViewComponent
{
    public  IViewComponentResult Invoke()
    {
        return View();
    }
}

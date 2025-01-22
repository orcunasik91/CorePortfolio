using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
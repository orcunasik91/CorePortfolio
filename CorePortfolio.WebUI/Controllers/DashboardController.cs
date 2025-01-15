using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.Controllers;
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
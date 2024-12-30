using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.Controllers;
public class AdminLayoutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
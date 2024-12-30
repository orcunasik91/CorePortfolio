using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.Controllers;
public class SkillsController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
}
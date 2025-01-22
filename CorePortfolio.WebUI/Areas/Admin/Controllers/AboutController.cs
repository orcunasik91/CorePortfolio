using CorePortfolio.Business.Abstract;
using CorePortfolio.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
public class AboutController : Controller
{
    private readonly IAboutService _aboutService;

    public AboutController(IAboutService aboutService)
    {
        _aboutService = aboutService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var datas = _aboutService.GetList();
        return View(datas);
    }

    [HttpGet]
    public IActionResult GetAbout(int id)
    {
        var datas = _aboutService.GetById(id);
        return View(datas);
    }

    [HttpPost]
    public IActionResult UpdateAbout(About about)
    {
        _aboutService.Update(about);
        return RedirectToAction(nameof(Index));
    }
}
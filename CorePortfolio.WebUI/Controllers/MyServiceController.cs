using CorePortfolio.Business.Abstract;
using CorePortfolio.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.Controllers;
public class MyServiceController : Controller
{
    private readonly IMyServiceService _myService;

    public MyServiceController(IMyServiceService myService)
    {
        _myService = myService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var datas = _myService.GetList();
        return View(datas);
    }

    [HttpGet]
    public IActionResult CreateMyService()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateMyService(MyService myService)
    {
        _myService.Insert(myService);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult GetMyService(int id)
    {
        var datas = _myService.GetById(id);
        return View(datas);
    }

    [HttpPost]
    public IActionResult UpdateMyService(MyService myService)
    {
        _myService.Update(myService);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult RemoveMyService(int id)
    {
        var datas = _myService.GetById(id);
        _myService.Delete(datas);
        return RedirectToAction(nameof(Index));
    }
}
using CorePortfolio.Business.Abstract;
using CorePortfolio.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.Controllers;
public class FeatureController : Controller
{
    private readonly IFeatureService _featureService;

    public FeatureController(IFeatureService featureService)
    {
        _featureService = featureService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var datas = _featureService.GetList();
        return View(datas);
    }

    [HttpGet]
    public IActionResult GetFeature(int id)
    {
        var feature = _featureService.GetById(id);
        return View(feature);
    }

    [HttpPost]
    public IActionResult UpdateFeature(Feature feature)
    {
        _featureService.Update(feature);
        return RedirectToAction(nameof(Index));
    }
}
using CorePortfolio.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.ViewComponents.Feature;
public class FeatureList : ViewComponent
{
    private readonly IFeatureService _featureService;

    public FeatureList(IFeatureService featureService)
    {
        _featureService = featureService;
    }

    public IViewComponentResult Invoke()
    {
        var featureList = _featureService.GetList();
        return View(featureList);
    }
}
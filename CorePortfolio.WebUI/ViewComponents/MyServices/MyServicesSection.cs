using CorePortfolio.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.ViewComponents.MyServices;
public class MyServicesSection : ViewComponent
{
    private readonly IMyServiceService _myService;

    public MyServicesSection(IMyServiceService myService)
    {
        _myService = myService;
    }
    public IViewComponentResult Invoke()
    {
        var myServices = _myService.GetList();
        return View(myServices);
    }
}
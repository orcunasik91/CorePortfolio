using CorePortfolio.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.ViewComponents.About;
public class AboutSection : ViewComponent
{
    private readonly IAboutService _aboutService;

    public AboutSection(IAboutService aboutService)
    {
        _aboutService = aboutService;
    }

    public IViewComponentResult Invoke()
    {
        var abouts = _aboutService.GetList();
        return View(abouts);
    }
}

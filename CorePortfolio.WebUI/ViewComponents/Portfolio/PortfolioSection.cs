using CorePortfolio.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.ViewComponents.Portfolio;
public class PortfolioSection : ViewComponent
{
    private readonly IPortfolioService _portfolioService;

    public PortfolioSection(IPortfolioService portfolioService)
    {
        _portfolioService = portfolioService;
    }

    public IViewComponentResult Invoke()
    {
        var datas = _portfolioService.GetList();
        return View(datas);
    }
}
using CorePortfolio.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.Areas.Admin.ViewComponents.Dashboard;
public class PortfolioList : ViewComponent
{
    private readonly IPortfolioService portfolioService;

    public PortfolioList(IPortfolioService _portfolioService)
    {
        portfolioService = _portfolioService;
    }

    public IViewComponentResult Invoke()
    {
        var portfolioList = portfolioService.GetList();
        return View(portfolioList);
    }
}
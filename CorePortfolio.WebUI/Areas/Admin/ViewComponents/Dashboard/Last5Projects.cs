using CorePortfolio.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.Areas.Admin.ViewComponents.Dashboard;
public class Last5Projects : ViewComponent
{
    private readonly IPortfolioService portfolioService;

    public Last5Projects(IPortfolioService _portfolioService)
    {
        portfolioService = _portfolioService;
    }

    public IViewComponentResult Invoke()
    {
        var lastFiveProjects = portfolioService.Last5Projects();
        return View(lastFiveProjects);
    }
}
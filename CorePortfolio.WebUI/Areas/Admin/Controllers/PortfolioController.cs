using CorePortfolio.Business.Abstract;
using CorePortfolio.Business.ValidationRules;
using CorePortfolio.Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
public class PortfolioController : Controller
{
    private readonly IPortfolioService _portfolioService;

    public PortfolioController(IPortfolioService portfolioService)
    {
        _portfolioService = portfolioService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var datas = _portfolioService.GetList();
        return View(datas);
    }

    [HttpGet]
    public IActionResult CreatePortfolio()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreatePortfolio(Portfolio portfolio)
    {
        PortfolioAddValidator validator = new();
        ValidationResult validationResult = validator.Validate(portfolio);
        if (validationResult.IsValid)
        {
            _portfolioService.Insert(portfolio);
            return RedirectToAction(nameof(Index));
        }
        else
        {
            foreach (ValidationFailure error in validationResult.Errors)
            {
                ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
        }
        return View();
    }

    [HttpGet]
    public IActionResult GetPortfolio(int id)
    {
        var result = _portfolioService.GetById(id);
        return View(result);
    }

    [HttpPost]
    public IActionResult UpdatePortfolio(Portfolio portfolio)
    {
        _portfolioService.Update(portfolio);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult RemovePortfolio(int id)
    {
        var result = _portfolioService.GetById(id);
        _portfolioService.Delete(result);
        return RedirectToAction(nameof(Index));
    }
}
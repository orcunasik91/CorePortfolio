using CorePortfolio.Business.Abstract;
using CorePortfolio.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.Controllers;
public class HomeController : Controller
{
    private readonly IMessageService _messageService;

    public HomeController(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult SendMessage()
    {
        return PartialView();
    }

    [HttpPost]
    public IActionResult SendMessage(Message message)
    {
        message.DateSent = Convert.ToDateTime(DateTime.Now.ToString("d"));
        message.IsRead = false;
        _messageService.Insert(message);
        return RedirectToAction(nameof(Index));
    }
}
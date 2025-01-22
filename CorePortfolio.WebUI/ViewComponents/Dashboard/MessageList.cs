using CorePortfolio.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.ViewComponents.Dashboard;
public class MessageList : ViewComponent
{
    private readonly IMessageService messageService;

    public MessageList(IMessageService _messageService)
    {
        messageService = _messageService;
    }

    public IViewComponentResult Invoke()
    {
        var messages = messageService.GetList();
        return View(messages);
    }
}
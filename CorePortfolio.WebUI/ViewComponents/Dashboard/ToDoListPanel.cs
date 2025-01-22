using CorePortfolio.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.ViewComponents.Dashboard;
public class ToDoListPanel : ViewComponent
{
    private readonly IToDoListService toDoListService;

    public ToDoListPanel(IToDoListService _toDoListService)
    {
        toDoListService = _toDoListService;
    }

    public IViewComponentResult Invoke()
    {
        var todolists = toDoListService.GetList();
        return View(todolists);
    }
}
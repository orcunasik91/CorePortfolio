using CorePortfolio.DataAccess.Concrete.Context;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.Areas.Admin.ViewComponents.Dashboard;
public class FeatureStatistic : ViewComponent
{
    MyAppContext context = new();
    public IViewComponentResult Invoke()
    {
        ViewBag.SkillCount = context.Skills.Count();
        ViewBag.UnReadMessageCount = context.Messages.Where(msg => msg.IsRead == false).Count();
        ViewBag.ReadMessageCount = context.Messages.Where(msg => msg.IsRead == true).Count();
        ViewBag.ExperienceCount = context.Experiences.Count();
        return View();
    }
}
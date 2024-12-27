using CorePortfolio.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.ViewComponents.Contact;
public class ContactDetail : ViewComponent
{
    private readonly IContactService _contactService;

    public ContactDetail(IContactService contactService)
    {
        _contactService = contactService;
    }

    public IViewComponentResult Invoke()
    {
        var contactDetails = _contactService.GetList();
        return View(contactDetails);
    }
}
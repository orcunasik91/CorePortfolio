using CorePortfolio.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.WebUI.ViewComponents.Testimonial;
public class TestimonialsSection : ViewComponent
{
    private readonly ITestimonialService _testimonialService;

    public TestimonialsSection(ITestimonialService testimonialService)
    {
        _testimonialService = testimonialService;
    }

    public IViewComponentResult Invoke()
    {
        var testimonials = _testimonialService.GetList();
        return View(testimonials);
    }
}
using CorePortfolio.Business.Abstract;
using CorePortfolio.DataAccess.Abstract;
using CorePortfolio.Entities.Concrete;

namespace CorePortfolio.Business.Concrete;
public class TestimonialManager : ITestimonialService
{
    private readonly ITestimonialDal _testimonialDal;

    public TestimonialManager(ITestimonialDal testimonialDal)
    {
        _testimonialDal = testimonialDal;
    }

    public void Delete(Testimonial entity)
    {
        _testimonialDal.Delete(entity);
    }

    public Testimonial GetById(int id)
    {
        return _testimonialDal.GetById(id);
    }

    public List<Testimonial> GetList()
    {
        return _testimonialDal.GetAll();
    }

    public void Insert(Testimonial entity)
    {
        _testimonialDal.Insert(entity);
    }

    public void Update(Testimonial entity)
    {
        _testimonialDal.Update(entity);
    }
}
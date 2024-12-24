using CorePortfolio.Business.Abstract;
using CorePortfolio.DataAccess.Abstract;
using CorePortfolio.Entities.Concrete;

namespace CorePortfolio.Business.Concrete;
public class AboutManager : IAboutService
{
    private readonly IAboutDal _aboutDal;

    public AboutManager(IAboutDal aboutDal)
    {
        _aboutDal = aboutDal;
    }

    public void Delete(About entity)
    {
        _aboutDal.Delete(entity);
    }

    public About GetById(int id)
    {
        return _aboutDal.GetById(id);
    }

    public List<About> GetList()
    {
        return _aboutDal.GetAll();
    }

    public void Insert(About entity)
    {
        _aboutDal.Insert(entity);
    }

    public void Update(About entity)
    {
        _aboutDal.Update(entity);
    }
}
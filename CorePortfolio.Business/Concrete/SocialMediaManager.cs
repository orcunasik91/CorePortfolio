using CorePortfolio.Business.Abstract;
using CorePortfolio.DataAccess.Abstract;
using CorePortfolio.Entities.Concrete;

namespace CorePortfolio.Business.Concrete;
public class SocialMediaManager : ISocialMediaService
{
    private readonly ISocialMediaDal _socialMediaDal;

    public SocialMediaManager(ISocialMediaDal socialMediaDal)
    {
        _socialMediaDal = socialMediaDal;
    }

    public void Delete(SocialMedia entity)
    {
        _socialMediaDal.Delete(entity);
    }

    public SocialMedia GetById(int id)
    {
        return _socialMediaDal.GetById(id);
    }

    public List<SocialMedia> GetList()
    {
        return _socialMediaDal.GetAll();
    }

    public void Insert(SocialMedia entity)
    {
        _socialMediaDal.Insert(entity);
    }

    public void Update(SocialMedia entity)
    {
        _socialMediaDal.Update(entity);
    }
}
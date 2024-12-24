using CorePortfolio.Business.Abstract;
using CorePortfolio.DataAccess.Abstract;
using CorePortfolio.Entities.Concrete;

namespace CorePortfolio.Business.Concrete;
public class ExperienceManager : IExperinceService
{
    private readonly IExperienceDal _experienceDal;

    public ExperienceManager(IExperienceDal experienceDal)
    {
        _experienceDal = experienceDal;
    }

    public void Delete(Experience entity)
    {
        _experienceDal.Delete(entity);
    }

    public Experience GetById(int id)
    {
        return _experienceDal.GetById(id);
    }

    public List<Experience> GetList()
    {
        return _experienceDal.GetAll();
    }

    public void Insert(Experience entity)
    {
        _experienceDal.Insert(entity);
    }

    public void Update(Experience entity)
    {
        _experienceDal.Update(entity);
    }
}
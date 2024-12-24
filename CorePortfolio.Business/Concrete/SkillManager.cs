using CorePortfolio.Business.Abstract;
using CorePortfolio.DataAccess.Abstract;
using CorePortfolio.Entities.Concrete;

namespace CorePortfolio.Business.Concrete;
public class SkillManager : ISkillService
{
    private readonly ISkillDal _skillDal;

    public SkillManager(ISkillDal skillDal)
    {
        _skillDal = skillDal;
    }

    public void Delete(Skill entity)
    {
        _skillDal.Delete(entity);
    }

    public Skill GetById(int id)
    {
        return _skillDal.GetById(id);
    }

    public List<Skill> GetList()
    {
        return _skillDal.GetAll();
    }

    public void Insert(Skill entity)
    {
        _skillDal.Insert(entity);
    }

    public void Update(Skill entity)
    {
        _skillDal.Update(entity);
    }
}
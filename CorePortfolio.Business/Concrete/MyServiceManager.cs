using CorePortfolio.Business.Abstract;
using CorePortfolio.DataAccess.Abstract;
using CorePortfolio.Entities.Concrete;

namespace CorePortfolio.Business.Concrete;
public class MyServiceManager : IMyServiceService
{
    private readonly IMyServiceDal _myServiceDal;

    public MyServiceManager(IMyServiceDal myServiceDal)
    {
        _myServiceDal = myServiceDal;
    }

    public void Delete(MyService entity)
    {
        _myServiceDal.Delete(entity);
    }

    public MyService GetById(int id)
    {
        return _myServiceDal.GetById(id);
    }

    public List<MyService> GetList()
    {
        return _myServiceDal.GetAll();
    }

    public void Insert(MyService entity)
    {
        _myServiceDal.Insert(entity);
    }

    public void Update(MyService entity)
    {
        _myServiceDal.Update(entity);
    }
}
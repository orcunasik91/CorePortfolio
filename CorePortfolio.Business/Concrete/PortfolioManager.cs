using CorePortfolio.Business.Abstract;
using CorePortfolio.DataAccess.Abstract;
using CorePortfolio.Entities.Concrete;

namespace CorePortfolio.Business.Concrete;
public class PortfolioManager : IPortfolioService
{
    private readonly IPortfolioDal _portfolioDal;

    public PortfolioManager(IPortfolioDal portfolioDal)
    {
        _portfolioDal = portfolioDal;
    }

    public void Delete(Portfolio entity)
    {
        _portfolioDal.Delete(entity);
    }

    public Portfolio GetById(int id)
    {
        return _portfolioDal.GetById(id);
    }

    public List<Portfolio> GetList()
    {
        return _portfolioDal.GetAll();
    }

    public void Insert(Portfolio entity)
    {
        _portfolioDal.Insert(entity);
    }

    public List<Portfolio> Last5Projects()
    {
        return _portfolioDal.GetLastFiveProjects();
    }

    public void Update(Portfolio entity)
    {
        _portfolioDal.Update(entity);
    }
}
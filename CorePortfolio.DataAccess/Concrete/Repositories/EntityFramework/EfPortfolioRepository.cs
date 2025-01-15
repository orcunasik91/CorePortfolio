using CorePortfolio.DataAccess.Abstract;
using CorePortfolio.DataAccess.Concrete.Context;
using CorePortfolio.Entities.Concrete;

namespace CorePortfolio.DataAccess.Concrete.Repositories.EntityFramework;
public class EfPortfolioRepository : BaseEntityRepository<Portfolio>, IPortfolioDal
{
    public List<Portfolio> GetLastFiveProjects()
    {
        using (MyAppContext context = new())
        {
            return context.Portfolios.OrderByDescending(p => p.PortfolioId).Take(5).ToList();
        }
    }
}
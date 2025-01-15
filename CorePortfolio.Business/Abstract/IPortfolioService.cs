using CorePortfolio.Entities.Concrete;

namespace CorePortfolio.Business.Abstract;
public interface IPortfolioService : IBaseService<Portfolio>
{
    List<Portfolio> Last5Projects();
}
using CorePortfolio.DataAccess.Abstract;
using CorePortfolio.Entities.Concrete;

namespace CorePortfolio.DataAccess.Concrete.Repositories.EntityFramework;
public class EfExperienceRepository : BaseEntityRepository<Experience>, IExperienceDal
{
}
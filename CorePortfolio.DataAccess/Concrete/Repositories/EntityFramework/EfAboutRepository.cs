﻿using CorePortfolio.DataAccess.Abstract;
using CorePortfolio.Entities.Concrete;

namespace CorePortfolio.DataAccess.Concrete.Repositories.EntityFramework;
public class EfAboutRepository : BaseEntityRepository<About>, IAboutDal
{
}
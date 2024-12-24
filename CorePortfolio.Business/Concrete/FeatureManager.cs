﻿using CorePortfolio.Business.Abstract;
using CorePortfolio.DataAccess.Abstract;
using CorePortfolio.Entities.Concrete;

namespace CorePortfolio.Business.Concrete;
public class FeatureManager : IFeatureService
{
    private readonly IFeatureDal _featureDal;

    public FeatureManager(IFeatureDal featureDal)
    {
        _featureDal = featureDal;
    }

    public void Delete(Feature entity)
    {
        _featureDal.Delete(entity);
    }

    public Feature GetById(int id)
    {
        return _featureDal.GetById(id);
    }

    public List<Feature> GetList()
    {
        return _featureDal.GetAll();
    }

    public void Insert(Feature entity)
    {
        _featureDal.Insert(entity);
    }

    public void Update(Feature entity)
    {
        _featureDal.Update(entity);
    }
}

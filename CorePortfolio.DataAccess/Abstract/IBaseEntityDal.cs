﻿namespace CorePortfolio.DataAccess.Abstract;
public interface IBaseEntityDal<TEntity> where TEntity : class, new()
{
    void Insert(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    TEntity GetById(int id);
    List<TEntity> GetAll();
}
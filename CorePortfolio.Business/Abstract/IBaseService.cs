namespace CorePortfolio.Business.Abstract;
public interface IBaseService<T> where T : class,new()
{
    void Insert(T entity);
    void Update(T entity);
    void Delete(T entity);
    List<T> GetList();
    T GetById(int id);
}
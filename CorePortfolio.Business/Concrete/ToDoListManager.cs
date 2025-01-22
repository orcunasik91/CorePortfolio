using CorePortfolio.Business.Abstract;
using CorePortfolio.DataAccess.Abstract;
using CorePortfolio.DataAccess.Concrete.Context;
using CorePortfolio.Entities.Concrete;

namespace CorePortfolio.Business.Concrete;
public class ToDoListManager : IToDoListService
{
    private readonly IToDoListDal toDoListDal;

    public ToDoListManager(IToDoListDal _toDoListDal)
    {
        toDoListDal = _toDoListDal;
    }

    public void Delete(ToDoList entity)
    {
        using (MyAppContext context = new())
        {
            toDoListDal.Delete(entity);
        }
    }

    public ToDoList GetById(int id)
    {
        using (MyAppContext context = new())
        {
            return toDoListDal.GetById(id);
        }
    }

    public List<ToDoList> GetList()
    {
        using (MyAppContext context = new())
        {
            return toDoListDal.GetAll();
        }
    }

    public void Insert(ToDoList entity)
    {
        using (MyAppContext context = new())
        {
            toDoListDal.Insert(entity);
        }
    }

    public void Update(ToDoList entity)
    {
        using (MyAppContext context = new())
        {
            toDoListDal.Update(entity);
        }
    }
}
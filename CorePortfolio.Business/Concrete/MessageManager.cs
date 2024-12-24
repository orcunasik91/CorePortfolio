using CorePortfolio.Business.Abstract;
using CorePortfolio.DataAccess.Abstract;
using CorePortfolio.Entities.Concrete;

namespace CorePortfolio.Business.Concrete;
public class MessageManager : IMessageService
{
    private readonly IMessageDal _messageDal;

    public MessageManager(IMessageDal messageDal)
    {
        _messageDal = messageDal;
    }

    public void Delete(Message entity)
    {
        _messageDal.Delete(entity);
    }

    public Message GetById(int id)
    {
        return _messageDal.GetById(id);
    }

    public List<Message> GetList()
    {
        return _messageDal.GetAll();
    }

    public void Insert(Message entity)
    {
        _messageDal.Insert(entity);
    }

    public void Update(Message entity)
    {
        _messageDal.Update(entity);
    }
}
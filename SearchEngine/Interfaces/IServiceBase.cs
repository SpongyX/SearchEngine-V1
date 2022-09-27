using SearchEngine.ResponseMessage;

namespace SearchEngine.Interfaces
{
    public interface IServiceBase<T> where T : class
    {
        ResponseMsg FindAll();
        ResponseMsg FindById(int id);
        ResponseMsg isExists(int id);
        ResponseMsg Create(T entity);
        ResponseMsg Update(T entity);
        ResponseMsg Delete(int id);
        ResponseMsg Save();
    }
}

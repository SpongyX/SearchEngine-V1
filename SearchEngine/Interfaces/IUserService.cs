using SearchEngine.Models;
using SearchEngine.ResponseMessage;

namespace SearchEngine.Interfaces
{
    public interface IUserService : IServiceBase<UserModel>
    {
        ResponseMsg canLogin(UserModel entity);
    }
}

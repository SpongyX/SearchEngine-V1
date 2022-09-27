using SearchEngine.Data;
using SearchEngine.Interfaces;
using SearchEngine.Models;
using SearchEngine.ResponseMessage;

namespace SearchEngine.Services
{
    public class UserService : IUserService
    {
        private readonly SearchEngineContext _context;
        public UserService(SearchEngineContext searchEngineContext)
        {
            _context = searchEngineContext;
        }

        public ResponseMsg canLogin(UserModel entity)
        {
            try
            {
                var IsObjectExist = _context.Users.Where(x => x.Email == entity.Email && x.Password == entity.Password).FirstOrDefault();
                if (IsObjectExist == null)
                {
                    return ResponseMsg.PerformError("Cannot be found");
                }
                return ResponseMsg.PerformSuccess(IsObjectExist);
            }
            catch (Exception ex)
            {

                return ResponseMsg.PerformError(ex.Message);
            }
        }

        public ResponseMsg Create(UserModel entity)
        {
            throw new NotImplementedException();
        }

        public ResponseMsg Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseMsg FindAll()
        {
            throw new NotImplementedException();
        }

        public ResponseMsg FindById(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseMsg isExists(int id)
        {
            throw new NotImplementedException();
        }
      

        public ResponseMsg Save()
        {
            throw new NotImplementedException();
        }

        public ResponseMsg Update(UserModel entity)
        {
            throw new NotImplementedException();
        }
    }
}

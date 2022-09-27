using SearchEngine.Data;
using SearchEngine.Interfaces;
using SearchEngine.Models;
using SearchEngine.ResponseMessage;

namespace SearchEngine.Services
{
    public class StoredLibraryService : IStoredLibrary
    {
        private SearchEngineContext _context;
        public StoredLibraryService(SearchEngineContext searchEngineContext)
        {
            _context = searchEngineContext;
        }
        public ResponseMsg Create(StoredLibraryModel entity)
        {
            try
            {
                var newData = new StoredLibrary()
                {

                    Description = entity.Description,
                    DateAdded = DateTime.Now,
                    LastEdited = DateTime.Now,
                    Isactive = true,
                    Link = entity.Link,

                };
                _context.StoredLibraries.Add(newData);
                _context.SaveChanges();
                return ResponseMsg.PerformSuccess();
            }

            catch (Exception ex)
            {
                return ResponseMsg.PerformError(ex.Message);
            }
        }

        public ResponseMsg Delete(int id)
        {
            throw new NotImplementedException();

        }

        public ResponseMsg FindAll()
        {
            try
            {
                var repeated = _context.StoredLibraries.GroupBy(r => r.Description)
                .Where(x => x.Count() > 1)
                .Select(val => new
                {
                    name = val.Key,
                    number = val.Count()
                });
                return ResponseMsg.PerformSuccess(repeated);
            }

            catch (Exception ex)
            {

                throw new NotImplementedException(ex.Message);
            }

        }

        public ResponseMsg FindById(int id)
        {
            try
            {
                var storedLibraryObject = _context.StoredLibraries.Where(x => x.Id == id && x.Isactive == true).FirstOrDefault();
                if (storedLibraryObject == null)
                {
                    return ResponseMsg.PerformError("Cannot be found");
                }
                return ResponseMsg.PerformSuccess(storedLibraryObject);
            }
            catch (Exception ex)
            {

                throw new NotImplementedException(ex.Message);
            }

        }

        public ResponseMsg isExists(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseMsg Save()
        {
            throw new NotImplementedException();
        }

        public ResponseMsg Update(StoredLibraryModel entity)
        {
            throw new NotImplementedException();
        }
    }
}

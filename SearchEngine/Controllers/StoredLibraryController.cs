using Microsoft.AspNetCore.Mvc;
using SearchEngine.Interfaces;
using SearchEngine.Models;

namespace SearchEngine.Controllers
{
    [Route("api/[controller]")]
    public class StoredLibraryController : Controller
    {
        private IStoredLibrary _storedLibrary;
        public StoredLibraryController(IStoredLibrary storedLibrary)
        {
            _storedLibrary = storedLibrary;
        }

        [HttpPost]
        [Route("CreateStoredLibrary")]

        public IActionResult CreateStoredLibrary([FromBody] StoredLibraryModel model)
        
        {
            var response = _storedLibrary.Create(model);
            return Ok(response);
        }
        [HttpGet]
        [Route("GetStoredLibrary")]
        public IActionResult GetPerson()
        {
            var response = _storedLibrary.FindAll();
            return Ok(response);
        }
        [HttpGet]
        [Route("GetStoredLibraryById/{id}")]

        public IActionResult GetPersonById(int id)
        {
            var response = _storedLibrary.FindById(id);
            return Ok(response);
        }
    }
}

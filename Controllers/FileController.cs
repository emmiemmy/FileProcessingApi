using System;
using System.Threading.Tasks;
using FilesApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilesApi.Controllers
{

    ///Handles requsets from client, user input validation
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {
        private readonly IFileService _service;

        public FileController(IFileService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult> PostFile([FromForm] IFormFile file)
        {
            try
            {
                 if(file == null)
                 {
                     return BadRequest();
                 }

                 var processedFileDto= await _service.ProcessFile(file);

                 return StatusCode(StatusCodes.Status200OK, processedFileDto);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

    }
}

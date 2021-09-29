using System;
using System.Threading.Tasks;
using FilesApi.DTOs;
using FilesApi.Models;
using FilesApi.Repositories;
using Microsoft.AspNetCore.Http;

namespace FilesApi.Services
{
    ///Service class handling business logic, referencing FileRepositoy that handle data access by dependency injection
    public class FileService : IFileService
    {
        private readonly IFileRepo _repo;

        public FileService(IFileRepo repo)
        {
            _repo = repo;
        }

        public async Task<FileModel> ProcessFile(IFormFile file)
        {
            try
            {
                //Get file
                 FileModel fileModel = await _repo.ReadFile(file);

                //Find most occurring word

                 //Process text in file, adding foo and bar to most common word

                //TODO map to dto and return dto instead
                //return fileDto;
                 return fileModel;

            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}

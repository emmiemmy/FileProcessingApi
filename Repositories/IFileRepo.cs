using System;
using System.Threading.Tasks;
using FilesApi.Models;
using Microsoft.AspNetCore.Http;

namespace FilesApi.Repositories
{
    public interface IFileRepo
    {
        Task<FileModel> ReadFile(IFormFile file);
    }
}

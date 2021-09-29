using System;
using System.Threading.Tasks;
using FilesApi.DTOs;
using FilesApi.Models;
using Microsoft.AspNetCore.Http;

namespace FilesApi.Services
{
    ///Defines functions to be implemented in FileService
    public interface IFileService
    {
        Task<FileModel> ProcessFile(IFormFile file);

        //Task<FileDto> ProcessFile(IFormFile file);

    }
}

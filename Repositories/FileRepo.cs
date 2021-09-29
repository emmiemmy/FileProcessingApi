using System;
using System.IO;
using System.Threading.Tasks;
using FilesApi.Models;
using Microsoft.AspNetCore.Http;

namespace FilesApi.Repositories
{
    public class FileRepo : IFileRepo
    {
        public async Task<FileModel> ReadFile(IFormFile file)
        {
            string text = "";
            using(StreamReader reader = new StreamReader(file.OpenReadStream()) )
            {
                text = await reader.ReadToEndAsync();
            }

            FileModel fileModel = new FileModel(text);

            return fileModel;
        }
    }
}

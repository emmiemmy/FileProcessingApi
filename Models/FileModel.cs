using System;

namespace FilesApi.Models
{
    public class FileModel
    {
        public string Text { get; set; }

        public FileModel(string text = "test text")
        {
            Text = text;
        }
    }
}

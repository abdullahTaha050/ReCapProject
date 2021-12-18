using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Helpers.FileHelper
{
    public interface IFileHelper
    {
        public string Upload(IFormFile file, string root);
        public string Update(IFormFile file, string filePath, string root);
        void Delete(string filePath);
    }
}

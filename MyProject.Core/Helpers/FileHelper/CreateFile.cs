using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Core.Helpers.FileHelper
{
    public static class CreateFile
    {
        public static async Task<string> FileCreater(IFormFile file,string source)
        {
            if (file != null)
            {
                string fileExtension = Path.GetExtension(file.FileName);
                string fileName = Guid.NewGuid() + fileExtension;
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/{source}/" + fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                return fileName;
            }
            else
            {
                return null;
            }
        }
    }
}

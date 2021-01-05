using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace MyProject.Core.Helpers.JsonHelpers
{
    public static class SeedHelper
    {
        public static List<TEntity> SeedData<TEntity>(string fileName)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string path ="JsonFiles";
            string fullPath = Path.Combine(currentDirectory, path, fileName);

            var result = new List<TEntity>();
            using (var reader = new StreamReader(fullPath))
            {
                string json = reader.ReadToEnd();
  
                result = JsonConvert.DeserializeObject<List<TEntity>>(json, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
            }

            return result;
        }
    }
}

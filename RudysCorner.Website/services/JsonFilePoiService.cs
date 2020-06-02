using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using ContosoCrafts.Website.Models;
using Microsoft.AspNetCore.Hosting;
using RudysCorner.Website.Models;

namespace RudysCorner.Website.services
{
    public class JsonFilePoiService
    {
        public JsonFilePoiService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironmnet = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironmnet { get; }
        
        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironmnet.WebRootPath, "data", "pois.json"); }
        }
        public IEnumerable<Poi> GetPois()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Poi[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public Poi GetPoi(string poiId)
        {
            var pois = GetPois();
            return pois.First(x => x.Id == poiId);
        }
    }
}
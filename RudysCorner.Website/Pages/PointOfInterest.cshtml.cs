using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RudysCorner.Website.Models;
using RudysCorner.Website.services;

namespace RudysCorner.Website.Pages
{
    public class PointOfInterestModel : PageModel
    {
        public string Id { get; set; }
        public Poi Poi { get; private set;}
        public JsonFilePoiService PoiService { get; }
        public PointOfInterestModel(JsonFilePoiService poiService)
        {
            PoiService = poiService;
        }
        public void OnGet(string id)
        {
            Id = id;
            Poi = PoiService.GetPoi(Id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RudysCorner.Website.Models;
using RudysCorner.Website.services;

namespace RudysCorner.Website.Pages
{
    public class AnalyticsModel : PageModel
    {
        public IEnumerable<Poi> Pois;
        public JsonFilePoiService PoiService { get; }
        public AnalyticsModel(JsonFilePoiService poiService)
        {
            PoiService = poiService;
        }
        public void OnGet()
        {
            Pois = PoiService.GetPois();
        }
    }
}
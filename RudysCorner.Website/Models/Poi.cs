using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RudysCorner.Website.Models
{
    public class Poi
    {
        public string Id { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public string NextStop { get; set; }
        public string[] FAQ { get; set; }
        public string[] Answers { get; set; }

        public override string ToString() => JsonSerializer.Serialize(this);
    }
}
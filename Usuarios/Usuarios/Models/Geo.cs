using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Usuarios.Models
{

    public class Geo 
    {
        public Geo(string lat, string lng)
        {
            Lat = lat;
            Lng = lng;
        }

        [JsonProperty("lat")]
        public string Lat { get; set; }
        [JsonProperty("lng")]
        public string Lng { get; set; }
    }
}

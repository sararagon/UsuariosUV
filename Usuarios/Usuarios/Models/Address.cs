using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


namespace Usuarios.Models
{
    public class Address 
    {
        public Address(string street, string suite, string city, string zipcode, Geo geo)
        {
            Street = street;
            Suite = suite;
            City = city;
            Zipcode = zipcode;
            Geo = geo;
        }

        [JsonProperty("street")]
        public string Street { get; set; }
        [JsonProperty("suite")]
        public string Suite { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }
        [JsonProperty("geo")]
        public Geo Geo { get; set; }
    }
}

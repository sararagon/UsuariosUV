using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Usuarios.Models
{
    public class Company 
    {
        public Company(string name, string catchPhrase, string bs)
        {
            Name = name;
            CatchPhrase = catchPhrase;
            Bs = bs;
        }

        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("catchPhrase")]
        public string CatchPhrase { get; set; }
        [JsonProperty("bs")]
        public string Bs { get; set; }
    }
}

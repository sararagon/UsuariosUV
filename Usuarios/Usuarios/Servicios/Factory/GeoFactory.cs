using System;
using System.Collections.Generic;
using System.Text;
using Usuarios.Models;

namespace Usuarios.Servicios.Factory
{
    class GeoFactory
    {
        public Geo DefinirGeo(string lat, string lng)
        {
            return new Geo(lat, lng);
        }
    }
}

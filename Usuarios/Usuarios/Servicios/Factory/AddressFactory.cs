using System;
using System.Collections.Generic;
using System.Text;
using Usuarios.Models;

namespace Usuarios.Servicios.Factory
{
    class AddressFactory
    {
        public Address CrearAddress(String street, String suite, String city, String zipcode, String lat, String lng)
        {
            var GeoFc = new GeoFactory();
            return new Address(street, suite, city, zipcode, GeoFc.DefinirGeo(lat, lng));
        }
    }
}

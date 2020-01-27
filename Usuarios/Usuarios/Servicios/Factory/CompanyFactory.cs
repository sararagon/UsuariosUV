using System;
using System.Collections.Generic;
using System.Text;
using Usuarios.Models;

namespace Usuarios.Servicios.Factory
{
    class CompanyFactory
    {
        Company CrearCompany(String name, String catchPhrase, String bs)
        {
            return new Company(name, catchPhrase, bs);
        }
    }
}

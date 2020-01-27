using System;
using System.Collections.Generic;
using System.Text;
using Usuarios.Models;

namespace Usuarios.Servicios.Specification
{
    class SpecificationNombreUsuario : ISpecification
    {
        public bool IsSatisfiedBy(String s)
        {
            int palabras = s.Split(" ").Length;
   
            return (palabras <= 2);
        }
    }
}

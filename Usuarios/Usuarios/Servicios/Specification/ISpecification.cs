using System;
using System.Collections.Generic;
using System.Text;
using Usuarios.Models;

namespace Usuarios.Servicios.Specification
{
    public interface ISpecification
    {
        bool IsSatisfiedBy(String s);
        
    }
}

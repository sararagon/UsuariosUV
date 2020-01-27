using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Usuarios.Models;

namespace Usuarios.Servicios.Specification
{
    class SpecificationEmail : ISpecification
    {
        public bool IsSatisfiedBy(String s)
        {
            String pattern = @"^ ((? !\.)[\w-_.]*[^.])(@\w+)\.((com)|(me)|(info)|(biz)|(net)|(io.))$";
            return Regex.IsMatch(s, pattern);
        }
        
    }
}

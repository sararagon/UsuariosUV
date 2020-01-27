using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Usuarios.Models;
using Usuarios.Servicios.Log;
using Usuarios.Servicios.Specification;

namespace Usuarios.Servicios.Factory
{
    public class UsuarioFactory
    {
        
        public static Usuario CrearUsuario(int id, String name, String username, String email,
            Address address, String phone, string website, Company company)
        {
            ILog FailLog  = new LogFichero();
            ISpecification s = new SpecificationEmail();
            ISpecification p = new SpecificationNombreUsuario();
            if (s.IsSatisfiedBy(email) )
            {
                if (p.IsSatisfiedBy(name))
                {
                    return new Usuario(id, name, username, email, address, phone, website,
                    company);
                }
                else
                {
                    FailLog.EscribeLog("El usuario {id} tiene un nombre demasiado largo", ficheroEscritura: File.Create(@".\Fail.txt"));
                    return null;
                }
            }
            else
            {
                FailLog.EscribeLog("El usuario {id} tiene un email no válido", ficheroEscritura: File.Create(@".\Fail.txt"));
                return null;
            }
        }

        public static Usuario CrearUsuario(int id, String name, String email)
        {
            ILog FailLog = new LogFichero();
            ISpecification s = new SpecificationEmail();
            ISpecification p = new SpecificationNombreUsuario();
            if (s.IsSatisfiedBy(email))
            {
                if (p.IsSatisfiedBy(name))
                {
                    return new Usuario(id, name, null, email, null, null, null,
                    null);
                }
                else
                {
                    FailLog.EscribeLog("El usuario {id} tiene un nombre demasiado largo", ficheroEscritura: File.Create(@".\Fail.txt"));
                    return null;
                }
            }
            else
            {
                FailLog.EscribeLog("El usuario {id} tiene un email no válido", ficheroEscritura: File.Create(@".\Fail.txt"));
                return null;
            }
        }

        public static Usuario CrearUsuario(int id, String name, String email, Company company)
        {
            ILog FailLog = new LogFichero();
            ISpecification s = new SpecificationEmail();
            ISpecification p = new SpecificationNombreUsuario();
            if (s.IsSatisfiedBy(email))
            {
                if (p.IsSatisfiedBy(name))
                {
                    return new Usuario(id, name, null, email, null, null, null,
                    company);
                }
                else
                {
                    FailLog.EscribeLog("El usuario {id} tiene un nombre demasiado largo", ficheroEscritura: File.Create(@".\Fail.txt"));
                    return null;
                }
            }
            else
            {
                FailLog.EscribeLog("El usuario {id} tiene un email no válido", ficheroEscritura: File.Create(@".\Fail.txt"));
                return null;
            }
        }

        public static Usuario CrearUsuario(Usuario u)
        {
            ILog FailLog = new LogFichero();
            ISpecification s = new SpecificationEmail();
            ISpecification p = new SpecificationNombreUsuario();
            if (s.IsSatisfiedBy(u.Email))
            {
                if (p.IsSatisfiedBy(u.Name))
                {
                    return u;
                    
                }
                else
                {
                    FailLog.EscribeLog("El usuario {id} tiene un nombre demasiado largo", ficheroEscritura: File.Create(@".\Fail.txt"));
                    return null;
                }
            }
            else
            {
                FailLog.EscribeLog("El usuario {username} tiene un email no válido", ficheroEscritura: File.Create(@".\Fail.txt"));
                return null;
            }


        }
    }
}

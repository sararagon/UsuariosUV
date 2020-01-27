using System;
using System.Collections.Generic;
using System.Text;
using Usuarios.Models;
using Usuarios.Servicios.Factory;

namespace Usuarios.Servicios.Repository
{
    class FakeRepository : IRepository
    {
        
        private readonly List<Usuario> _listaUsuarios = new List<Usuario>
        {
            
        };
        public List<Usuario> LeerUsuarios()
        {
            return _listaUsuarios;
        }
    }
}

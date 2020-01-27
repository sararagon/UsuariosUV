using System;
using System.Collections.Generic;
using System.Text;
using Usuarios.Models;

namespace Usuarios.Servicios.Repository
{
    interface IRepository
    {
        List<Usuario> LeerUsuarios();
    }
}

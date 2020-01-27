using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Usuarios.Servicios.Log
{
    public interface ILog
    {
        void EscribeLog(string mensaje, Stream ficheroEscritura);
        
    }
}

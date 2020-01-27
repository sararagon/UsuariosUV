using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Usuarios.Servicios.Log
{
    class LogFichero : ILog
    {
        public void EscribeLog(string mensaje, Stream ficheroEscritura)
        {
            using (StreamWriter streamWriter = new StreamWriter(ficheroEscritura))
            {
                streamWriter.WriteLine(mensaje);
                streamWriter.WriteLine(DateTime.Today);
                streamWriter.Close();
            }
        }
    }
}

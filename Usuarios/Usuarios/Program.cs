using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using Usuarios.Models;
using Usuarios.Servicios.Factory;
using Usuarios.Servicios.Log;
using Usuarios.Servicios.Repository;

namespace Usuarios
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository repository = new WebApiRepository();
            Console.ReadLine();
            List<Usuario> usuarios = repository.LeerUsuarios();
            ILog LogCorrectas = new LogFichero();
            List<String> compañiasDeCorrectas = null;
            List<Usuario> usuariosCorrectos = null;
            Stream ficheroCorrectos = File.Create(@".\Correct.txt");
            foreach (var u in usuarios)
            {
                LogCorrectas.EscribeLog(u.Name, ficheroEscritura: ficheroCorrectos);
                usuariosCorrectos.Add(u);
            }
            LogCorrectas.EscribeLog("Compañias: ", ficheroEscritura: ficheroCorrectos);
            foreach (var item in usuariosCorrectos)
            {
                if (!compañiasDeCorrectas.Contains(item.Company.Name))
                {
                    compañiasDeCorrectas.Add(item.Company.Name);
                    LogCorrectas.EscribeLog(item.Company.Name, ficheroEscritura: ficheroCorrectos);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Usuarios.Models;
using Newtonsoft.Json;

namespace Usuarios.Servicios.Repository
{
    public class WebApiRepository : IRepository
    {
        public WebApiRepository()
        {
        }

        public List<Usuario> LeerUsuarios()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("https://jsonplaceholder.typicode.com/users").Result;
                string contenido = response.Content.ReadAsStringAsync().Result;
                {
                    List<Usuario> lista;
                    lista = JsonConvert.DeserializeObject<List<Usuario>>(contenido);
                    return lista;

                }
            }


        }

    }
}

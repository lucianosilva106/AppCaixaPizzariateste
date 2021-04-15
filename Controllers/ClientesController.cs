using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAppCaixaPizzaria.Models;

namespace WebAppCaixaPizzaria.Controllers
{
    public class ClientesController : ApiController
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public List<Cliente> Get()
        {
            return clientes;
        }

        // teste alteracao para comitar

        public void Post(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                clientes.Add(new Cliente(nome));
            }
        }

        public void Delete(string nome)
        {
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Equals(nome))));
        }
    }
}

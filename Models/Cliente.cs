using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCaixaPizzaria.Models
{
    public class Cliente
    {
        public string Nome { get; set; }

        //construtor

        public Cliente(string texto)
        {
            this.Nome = texto;
        }
    }
}
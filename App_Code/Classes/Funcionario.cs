using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCaixaPizzaria.App_Code.Classes
{
    public class Funcionario
    {
        public int Registro { get; set; }
        public string Nome { get; set; }
        public string Chapeira { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        //construtor

        public Funcionario()
        {
            // adicionar contrutor aqui
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCaixaPizzaria.App_Code.Classes
{
    public class Caixacontrole
    {
        public int Registro { get; set; }
        public DateTime Datahoraabertura { get; set; }
        public int Idfuncionario { get; set; }
        public double Valorfundocaixa { get; set; }
        public DateTime Datahorafechamento { get; set; }
        public double Valorfinalcaixa { get; set; }

        public Caixacontrole()
        {
            // construtor aqui
        }
    }
}
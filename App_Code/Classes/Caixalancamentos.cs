using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCaixaPizzaria.App_Code.Classes
{
    public class Caixalancamentos
    {
        public int Registro { get; set; }
        public int Idcaixacontrole { get; set; }
        public DateTime Datahora { get; set; }
        public string Tipolancamento { get; set; }
        public double Valor { get; set; }
        public string Formapagamento { get; set; }
        public string Observacao { get; set; }
    }
}
using FATEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using WebAppCaixaPizzaria.App_Code.Classes

namespace WebAppCaixaPizzaria.App_Code.Persistencia
{
    public class CaixacontroleBD
    {
        //metodos - insert, altera, deleta, consultas

        //insert
        public bool Insert(Caixacontrole caixacontrole)
        {
            System.Data.IDbConnection objConexão;
            System.Data.IDbCommand objCommand;

            string sql = "INSERT INTO tbl_caixacontrole(ctr_datahoraabertura, ctr_idfuncionario, ctr_valorfundocaixa, ctr_datahorafechamento, ctr_valorfinalcaixa) VALUES (?datahoraabertura, ?idfuncionario, ?valorfundocaixa, ?datahorafechamento, ?valorfinalcaixa)";

            objConexão = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexão);

            objCommand.Parameters.Add(Mapped.Parameter("?datahoraabertura", caixacontrole.Datahoraabertura));
            objCommand.Parameters.Add(Mapped.Parameter("?idfuncionario", caixacontrole.Idfuncionario));
            objCommand.Parameters.Add(Mapped.Parameter("?valorfundocaixa", caixacontrole.Valorfundocaixa));
            objCommand.Parameters.Add(Mapped.Parameter("?datahorafechamento", caixacontrole.Datahorafechamento));
            objCommand.Parameters.Add(Mapped.Parameter("?valorfinalcaixa", caixacontrole.Valorfinalcaixa));

            objCommand.ExecuteNonQuery();
            objConexão.Close();
            objCommand.Dispose();
            objConexão.Dispose();

            return true;
        }

        public CaixacontroleBD()
        {
            // construtor aqui
        }
    }
}
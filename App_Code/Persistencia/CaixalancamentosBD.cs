using FATEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using WebAppCaixaPizzaria.App_Code.Classes

namespace WebAppCaixaPizzaria.App_Code.Persistencia
{
    public class CaixalancamentosBD
    {
        //metodos - insert, altera, deleta, consultas

        //insert
        public bool Insert(Caixalancamentos caixalancamentos)
        {
            System.Data.IDbConnection objConexão;
            System.Data.IDbCommand objCommand;

            string sql = "INSERT INTO tbl_caixalancamento(cxl_idcaixacontrole, cxl_datahora, cxl_tipolancamento, cxl_valor, cxl_formapagamento, cxl_observacao) VALUES (?idcaixacontrole, ?datahora, ?tipolancamento, ?valor, ?formapagamento, ?observacao)";

            objConexão = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexão);

            objCommand.Parameters.Add(Mapped.Parameter("?idcontrolecaixa", caixalancamentos.Idcaixacontrole));
            objCommand.Parameters.Add(Mapped.Parameter("?datahora", caixalancamentos.Datahora));
            objCommand.Parameters.Add(Mapped.Parameter("?tipolancamento", caixalancamentos.Tipolancamento));
            objCommand.Parameters.Add(Mapped.Parameter("?valor", caixalancamentos.Valor));
            objCommand.Parameters.Add(Mapped.Parameter("?formapagamento", caixalancamentos.Formapagamento));
            objCommand.Parameters.Add(Mapped.Parameter("?observacao", caixalancamentos.Observacao));

            objCommand.ExecuteNonQuery();
            objConexão.Close();
            objCommand.Dispose();
            objConexão.Dispose();

            return true;
        }

        public CaixalancamentosBD()
        {
            // construtor aqui
        }
    }
}
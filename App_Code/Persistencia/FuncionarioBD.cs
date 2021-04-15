using FATEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppCaixaPizzaria.App_Code.Classes;
using System.Data;

namespace WebAppCaixaPizzaria.App_Code.Persistencia
{
    public class FuncionarioBD
    {
        //metodos - insert, altera, deleta, consultas

        //insert
        public bool Insert(Funcionario funcionario)
        {
            System.Data.IDbConnection objConexão;
            System.Data.IDbCommand objCommand;

            string sql = "INSERT INTO tbl_funcionario(fun_nome, fun_chapeira, fun_login, fun_senha) VALUES (?nome, ?chapeira, ?login, ?senha)";

            objConexão = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexão);

            objCommand.Parameters.Add(Mapped.Parameter("?nome", funcionario.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?chapeira", funcionario.Chapeira));
            objCommand.Parameters.Add(Mapped.Parameter("?login", funcionario.Login));
            objCommand.Parameters.Add(Mapped.Parameter("?senha", funcionario.Senha));

            objCommand.ExecuteNonQuery();
            objConexão.Close();
            objCommand.Dispose();
            objConexão.Dispose();

            return true;
        }

        public FuncionarioBD()
        {
            // construtor aqui
        }
    }
}
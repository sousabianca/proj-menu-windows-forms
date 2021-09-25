using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjMenu.DAL
{
    class LoginDAOComandos
    {
        public bool tem;
        public String mensagem;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;


        public bool verficarLogin(String login, String senha)
        {
            //comandos sql para a verificação no BD
            cmd.CommandText = "Select * logins from where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader(); //pega a informação do bd pra ser guardado

                if (dr.HasRows) //se houver linhas no bd o login será verdadeiro
                {
                    tem = true;
                }
            
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";
            }

            return tem;
        }

        public String cadastrar(String nome, int cpf, int cell, String email, String senha, String conSenha)
        {
            //comandos para inserir no BD e retorna com alguma mensagem de erro ou sucesso
            return mensagem;
        }
    }
}

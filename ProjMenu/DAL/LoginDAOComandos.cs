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
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;


        public bool verficarLogin(String login, String senha)
        {
            //comandos sql para a verificação no BD
            cmd.CommandText = "select * from usuario where email = @login and senha = @senha";
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
                con.desconectar();
                dr.Close();
            
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";
            }

            return tem;
        }

        public String cadastrar(String nome, String cpf, String cell, String email, String senha, String confSenha)
        {
            //comandos para inserir no BD e retorna com alguma mensagem de erro ou sucesso

            tem = false; //inicializando como falso para se caso não ocrrer tudo bem saber qual a mensagem de erro
            if (senha.Equals(confSenha)) //verficando a igualdade das senhas
            {
                cmd.CommandText = "insert into usuario values (@nome, @cpf, @cell, @email, @senha);";
                cmd.Parameters.AddWithValue("@nome", nome);//adicionando os parametros do formulário no bd
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@cell", cell);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    //se conseguir executar todos acima exibirá a mensagem abaixo
                    this.mensagem = "Cadastrado com o sucesso! Faça o login.";

                    tem = true; // se ocorrer tudo bem será verdadeiro
                
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com o Banco de Dados";
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }
            
            return mensagem;
        }
    }
}

using ProjMenu.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjMenu.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = ""; //irá retornar um cadastrado com sucesso ou algum erro
        public bool acessar(String login, String senha)
        {
            LoginDAOComandos loginDAO = new LoginDAOComandos();
            tem = loginDAO.verficarLogin(login, senha);
            if (!loginDAO.mensagem.Equals("")) //se for diferente de vazio vai enviar uma mensagem de erro
            {
                this.mensagem = loginDAO.mensagem; //vai verificar se houve algum erro no código
            }
            return tem; //receber a chamada do método verificar
        }

        public String cadastrar (String nome, String cpf, String cell, String email, String senha, String confSenha)
        {
            LoginDAOComandos loginDAO = new LoginDAOComandos();
            this.mensagem = loginDAO.cadastrar(nome, cpf, cell, email, senha, confSenha);
            
            if (loginDAO.tem) //se for verdade mostrar uma mensagem de sucesso
            {
                this.tem = true;
            }

            return mensagem;
        }


    }
}

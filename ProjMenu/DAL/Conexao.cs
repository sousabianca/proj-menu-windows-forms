using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjMenu.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        public Conexao()
        {
            con.ConnectionString= @"Data Source=MOONBI\SQLEXPRESS;Initial Catalog=BDLogin;Integrated Security=True";

        }

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed) // se a conexão estiver fechada ai sim que poderá ser aberta
            {
                con.Open();
            }
            return con;
        }

        public void desconectar() //precisa estar aberto para desconectar
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}

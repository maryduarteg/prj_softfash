using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace soft_code
{
    public class Conexao
    {   //Criei a variável aqui, a bicha é de classe - M
        MySqlConnection con = new MySqlConnection();
        
        public Conexao()
        {
            //A variável aqui recebeua conexão dela, virou mocinha - M
            con.ConnectionString = @"Server = LAPTOP-63TU1SJI\SQLEXPRESS; Database=db_softfash; Trusted_Connection = True";
            
        }

        //conectar ao db, que na verdade é só para ver o estado se  aberto ou fechado - M
        public  MySqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //desconectar ao db - M
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            return;
        }
    }
}

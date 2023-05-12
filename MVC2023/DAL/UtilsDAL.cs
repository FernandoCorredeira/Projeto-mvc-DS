using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace MVC2023.DAL
{
    class UtilsDAL
    {
        public static MySqlConnection GetConnection()
        {

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Database = "bd_teste", //nome do banco
                UserID = "root",
                Password = ""   //Senha do banco
            };

            //Criando a conexão
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();

            return connection;
        }
    }
}

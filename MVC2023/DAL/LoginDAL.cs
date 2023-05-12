using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC2023.DTO;
using MySqlConnector;


namespace MVC2023.DAL
{
    class LoginDAL
    {
        // verificar o login no banco de dados
        public bool GetLoginDal(LoginDTO DadosLogin)
        {
            // conexão com o banco de dados
            try
            {
                //criar conexão
                MySqlConnection conn = UtilsDAL.GetConnection();
                //Testar conexão

                if(conn.State == ConnectionState.Open)
                {
                    //Pesquisar no Banco de Dados se o usuario existe

                    string sql = $"SELECT * FROM usuarios WHERE email = '{DadosLogin.Email}' AND senha = '{DadosLogin.Senha}'";

                    MySqlCommand retorno = new MySqlCommand(sql, conn);

                    MySqlDataReader reader = retorno.ExecuteReader();
                    if (reader.Read())
                    {
                        return true;
                    }
                    return false;
                            
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
                return false;

            }
            return false;

        }


    }
}

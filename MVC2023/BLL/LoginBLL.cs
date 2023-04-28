using MVC2023.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC2023.DTO;
using MVC2023.DAL;

namespace MVC2023.BLL
{
    class LoginBLL
    {
        // metodo de controle
        public bool GetLoginBLL(LoginDTO DadosLogin)
        {
            //Validação
            if(DadosLogin.Nome == null)
            {
                return false;
            }
            //criar um objeto da Dal
            LoginDAL login = new LoginDAL();

            // chamar o LoginDal
            login.GetLoginDal(DadosLogin);

            return true;
        }

        
    }
}

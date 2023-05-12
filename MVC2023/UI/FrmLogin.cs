using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC2023.DTO;
using MVC2023.BLL;
using MVC2023.DAL;
using MVC2023.UI;

namespace MVC2023
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void LblSenha_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginDTO DadosLogin = new LoginDTO
            {
                Email = txtEmail.Text,
                Senha = txtSenha.Text,

            };
            LoginBLL LoginBLL = new LoginBLL();
            bool retorno = LoginBLL.GetLoginBLL(DadosLogin);

            if (retorno)
            {
                //Carregar o frmMenu criando um objeto primeiro
                FrmMenu frmMenu = new FrmMenu();

                //Carregar o menu na tela
                frmMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro de login");

            }

        }
    }
}

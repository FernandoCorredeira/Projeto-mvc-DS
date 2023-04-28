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
            LoginDTO DadosLogin = new LoginDTO
            {
                Nome = txtNome.Text,
                Senha = txtSenha.Text,

            };
            LoginBLL LoginBLL = new LoginBLL();
            LoginBLL.GetLoginBLL(DadosLogin);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void LblSenha_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}

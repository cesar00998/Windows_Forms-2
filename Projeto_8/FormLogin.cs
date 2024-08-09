using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_8
{
    public partial class FormLogin : Form
    {
        public static bool Cancelar = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button_entrar_Click(object sender, EventArgs e)
        {
            string nome = textBox_usu.Text;
            string senha = textBox_senha.Text;
            if (CadastroUsuarios.Login(nome, senha))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Acesso negado");
                textBox_usu.Text = "";
                textBox_senha.Text = "";
                textBox_usu.Focus();
                Close();


            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();

        }
    }
}

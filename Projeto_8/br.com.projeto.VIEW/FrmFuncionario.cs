using Projeto_8.br.com.projeto.DAO;
using Projeto_8.br.com.projeto.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_8.br.com.projeto.VIEW
{
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Funcionarios obj = new Funcionarios();

            //1º passo - Receber os dados
            obj.nome = txt_nome.Text;
            obj.rg = txt_rg.Text.Replace(",", ".");
            obj.cpf = txt_cpf.Text.Replace(",", ".");
            obj.email = txt_email.Text;
            obj.senha = txt_senha.Text;
            obj.Cargo = comboBox_cargo.Text;
            obj.Nivel_acesso = comboBox_nivel.Text;
            obj.telefone = txt_telefone.Text;
            obj.celular = txt_celular.Text;
            obj.cep = txt_cep.Text;
            obj.endereco = txt_endereco.Text;
            obj.numero = int.Parse(txt_n.Text);
            obj.complemento = txt_compl.Text;
            obj.bairro = txt_bairro.Text;
            obj.cidade = txt_cidade.Text;
            obj.estado = cb_uf.Text;

            //2º passo - Criar o Objeto e chamar o metodo
            FuncionarioDao dao = new FuncionarioDao ();
            dao.cadastrarFuncionario(obj);


            //Recarregar o dataGrid
          

        }
    
    }
}

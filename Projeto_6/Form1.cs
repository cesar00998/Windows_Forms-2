﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_6
{
    public partial class Form1 : Form
    {

        List<Pessoa> pessoas;

        public Form1()
        {
            InitializeComponent();

            pessoas = new List<Pessoa> ();

            comboBox_estCivil.Items.Add("Casado");
            comboBox_estCivil.Items.Add("Solteiro");
            comboBox_estCivil.Items.Add("Viúvo");
            comboBox_estCivil.Items.Add("Divorciado");

            comboBox_estCivil.SelectedIndex = 0;

            //dataGridView
            dataGridView_pessoa.Columns.Add("Nome", "Nome");
            dataGridView_pessoa.Columns.Add("DataNascimento", "Data de Nascimento");
            dataGridView_pessoa.Columns.Add("EstadoCivil", "Estado Civil");
            dataGridView_pessoa.Columns.Add("Telefone", "Telefone");
            dataGridView_pessoa.Columns.Add("CasaPropria", "Casa Própria");
            dataGridView_pessoa.Columns.Add("Veiculo", "Veículo");
            dataGridView_pessoa.Columns.Add("Sexo", "Sexo");



        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_cadastrar_alterar_Click(object sender, EventArgs e)
        {
            int index = -1; //Verifica se o usuário já está cadastrado

            //Verifica se os nomes são iguais (Nome é nosso parametro)
            foreach(Pessoa pessoa in pessoas)
            {
                if(pessoa.Nome == textBox_nome.Text)
                {
                    index = pessoas.IndexOf(pessoa);
                }
            }

            //Verifica se os campos foram preenchidos
            if(textBox_nome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome!",
                    "Caixa mensagem",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox_nome.Focus();
                return;
            }

            if(maskedTextBox_telefone.Text == "(  )       -")
            {
                MessageBox.Show("Preencha o campo telefone");
                maskedTextBox_telefone.Focus();
                return;
            }

            char sexo;
            if (radioButton_masc.Checked)
            {
                sexo = 'M';
            }
            else if (radioButton_fem.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }

            //Atribuir Valores

            Pessoa p = new Pessoa();

            p.Nome = textBox_nome.Text;
            p.DataNascimento = dateTimePicker_dn.Text;
            p.EstadoCivil = comboBox_estCivil.SelectedItem.ToString();
            p.Telefone = maskedTextBox_telefone.Text;
            p.CasaPropria = checkBox_casaPropria.Checked;
            p.Veiculo = checkBox_veiculo.Checked;
            p.Sexo = sexo;

            //Verifica se já está cadastrado
            if(index < 0)
            {
                pessoas.Add(p);
            }
            else{
                pessoas[index] = p;
            }

            button_limpar_Click(button_limpar, EventArgs.Empty);

            Listar();

        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            //int indices = listBox_lista.SelectedIndex;
            int indices = dataGridView_pessoa.CurrentCell.RowIndex;


            pessoas.RemoveAt(indices);

            Listar();
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            //LIMPAR

            textBox_nome.Text = "";
            dateTimePicker_dn.Value = DateTime.Now;
            comboBox_estCivil.SelectedIndex = 0;
            maskedTextBox_telefone.Text = "";
            checkBox_casaPropria.Checked = false;
            checkBox_veiculo.Checked = false;
            radioButton_masc.Checked = false;
            radioButton_fem.Checked = false;
            radioButton_outros.Checked = false;

            textBox_nome.Focus();
        }

        private void Listar()
        {
            //LISTAR

            //listBox_lista.Items.Clear();
            dataGridView_pessoa.Rows.Clear();

            foreach(Pessoa p in pessoas)
            {
                //listBox_lista.Items.Add(p.Nome);
                //listBox_lista.Items.Add(p.Telefone);
                //listBox_lista.Items.Add(p.ToString());

                dataGridView_pessoa.Rows.Add(
                    p.Nome,
                    p.DataNascimento,
                    p.EstadoCivil,
                    p.Telefone,
                    p.CasaPropria ? "SIM" : "NÃO",
                    p.Veiculo ? "SIM" : "NÃO",
                    p.Sexo
                    );

            }
        }

        private void listBox_lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Alterar
            int indice = listBox_lista.SelectedIndex;

            Pessoa p = pessoas[indice];

            textBox_nome.Text = p.Nome;
            dateTimePicker_dn.Text = p.DataNascimento;
            comboBox_estCivil.SelectedItem = p.EstadoCivil;
            maskedTextBox_telefone.Text = p.Telefone;
            checkBox_casaPropria.Checked = p.CasaPropria;
            checkBox_veiculo.Checked = p.Veiculo;

            switch(p.Sexo)
            {
                case 'M':
                    radioButton_masc.Checked = true;
                    break;
                case 'F':
                    radioButton_fem.Checked = true;
                    break;
                default:
                    radioButton_outros.Checked = true;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_pessoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Alterar
            int indice = e.RowIndex;

            Pessoa p = pessoas[indice];

            textBox_nome.Text = p.Nome;
            dateTimePicker_dn.Text = p.DataNascimento;
            comboBox_estCivil.SelectedItem = p.EstadoCivil;
            maskedTextBox_telefone.Text = p.Telefone;
            checkBox_casaPropria.Checked = p.CasaPropria;
            checkBox_veiculo.Checked = p.Veiculo;

            switch (p.Sexo)
            {
                case 'M':
                    radioButton_masc.Checked = true;
                    break;
                case 'F':
                    radioButton_fem.Checked = true;
                    break;
                default:
                    radioButton_outros.Checked = true;
                    break;
            }
        }
    }
}

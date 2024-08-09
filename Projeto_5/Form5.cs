using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_5
{
    public partial class Form_reserva : System.Windows.Forms.Form
    {
        public Form_reserva()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(640, 180);
            groupBox2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label_reserva_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button_limpar_Click(object sender, EventArgs e)
        {


            textBox_nome.Text = "";
            comboBox_destino.Text = "";
            radioButton_aviao.Checked = false;
            radioButton_onibus.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button_confirma_Click(object sender, EventArgs e)
        {
            if(textBox_nome.Text.Length == 0)
            {
                MessageBox.Show("Digite seu nome");
                textBox_nome.Focus();
            }

            if (comboBox_destino.Text =="")
            {
                MessageBox.Show("Destino nao selecionado");
               comboBox_destino.Focus();
            }

            if(radioButton_aviao.Checked == false && radioButton_onibus.Checked == false)
            { radioButton_aviao.Focus(); }
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            double gasto_destino, gasto_transporte, gasto_total;

            switch(comboBox_destino.Text.ToUpper())
            {
                case "SP":
                    gasto_destino = 1000;
                    break;

                case "RJ":
                    gasto_destino = 1500;
                    break;

                case "SC":
                    gasto_destino = 2000;
                    break;
                default:
                    gasto_destino = 0;
                        break;


            }

            if (!radioButton_aviao.Checked == true) {
                gasto_transporte = 30;
            }
            else
            {
                gasto_transporte = 100;
            }

            gasto_total = gasto_transporte + gasto_destino;

            this.ClientSize = new System.Drawing.Size(640, 300);
            groupBox2.Visible = true;

            label_tranporte.Text = gasto_transporte.ToString("F2");
            label_destino.Text = gasto_destino.ToString("C2");
            label_total.Text = gasto_total.ToString("C2");
        }

        private void textBox_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

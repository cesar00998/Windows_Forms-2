using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto3
{
    public partial class label_IMC : Form
    {
        public label_IMC()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

            double Altura, peso, imc;

            peso = double.Parse(textBox_Peso.Text);

            imc = peso / ( Altura * Altura);

            label_result_imc.Text = imc.ToString();
            if (imc >= 19 && imc < 25) ;
            {
                label_resultado_situação.Text = "peso ideal";
            }
            else { 
            
            label_resultado_situação.Text}

            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair",
                    "Confimação", 
                MessageBoxButtons.  YesNo
                ) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

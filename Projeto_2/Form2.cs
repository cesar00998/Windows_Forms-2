using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_2
{
    public partial class Form_saudaçao : Form
    {
        public Form_saudaçao()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show($"ola {button1.Text}");

            string nome = textBox1.Text;

            MessageBox.Show($"OLA {nome}", "titulo da resposta " ,MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                
                );
        }
    }
}

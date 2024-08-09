namespace Projeto3
{
    partial class label_IMC
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label_peso = new System.Windows.Forms.Label();
            this.textBox_Peso = new System.Windows.Forms.TextBox();
            this.label_altura = new System.Windows.Forms.Label();
            this.textBox_Altura = new System.Windows.Forms.TextBox();
            this.label_4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_resultado_situação = new System.Windows.Forms.Label();
            this.label_result_imc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de IMC";
            // 
            // label_peso
            // 
            this.label_peso.AutoSize = true;
            this.label_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_peso.Location = new System.Drawing.Point(81, 111);
            this.label_peso.Name = "label_peso";
            this.label_peso.Size = new System.Drawing.Size(49, 20);
            this.label_peso.TabIndex = 1;
            this.label_peso.Text = "Peso";
            // 
            // textBox_Peso
            // 
            this.textBox_Peso.Location = new System.Drawing.Point(16, 146);
            this.textBox_Peso.Name = "textBox_Peso";
            this.textBox_Peso.Size = new System.Drawing.Size(170, 20);
            this.textBox_Peso.TabIndex = 2;
            // 
            // label_altura
            // 
            this.label_altura.AutoSize = true;
            this.label_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_altura.Location = new System.Drawing.Point(73, 195);
            this.label_altura.Name = "label_altura";
            this.label_altura.Size = new System.Drawing.Size(57, 20);
            this.label_altura.TabIndex = 3;
            this.label_altura.Text = "Altura";
            // 
            // textBox_Altura
            // 
            this.textBox_Altura.Location = new System.Drawing.Point(17, 227);
            this.textBox_Altura.Name = "textBox_Altura";
            this.textBox_Altura.Size = new System.Drawing.Size(169, 20);
            this.textBox_Altura.TabIndex = 4;
            // 
            // label_4
            // 
            this.label_4.AutoSize = true;
            this.label_4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_4.Location = new System.Drawing.Point(81, 269);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(33, 20);
            this.label_4.TabIndex = 5;
            this.label_4.Text = "IMC";
            this.label_4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Situação";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_resultado_situação
            // 
            this.label_resultado_situação.AutoSize = true;
            this.label_resultado_situação.Location = new System.Drawing.Point(71, 376);
            this.label_resultado_situação.Name = "label_resultado_situação";
            this.label_resultado_situação.Size = new System.Drawing.Size(61, 13);
            this.label_resultado_situação.TabIndex = 9;
            this.label_resultado_situação.Text = "Resultado,,";
            // 
            // label_result_imc
            // 
            this.label_result_imc.AutoSize = true;
            this.label_result_imc.Location = new System.Drawing.Point(83, 312);
            this.label_result_imc.Name = "label_result_imc";
            this.label_result_imc.Size = new System.Drawing.Size(55, 13);
            this.label_result_imc.TabIndex = 10;
            this.label_result_imc.Text = "resultados";
            // 
            // label_IMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 496);
            this.Controls.Add(this.label_result_imc);
            this.Controls.Add(this.label_resultado_situação);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_4);
            this.Controls.Add(this.textBox_Altura);
            this.Controls.Add(this.label_altura);
            this.Controls.Add(this.textBox_Peso);
            this.Controls.Add(this.label_peso);
            this.Controls.Add(this.label1);
            this.Name = "label_IMC";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_peso;
        private System.Windows.Forms.TextBox textBox_Peso;
        private System.Windows.Forms.Label label_altura;
        private System.Windows.Forms.TextBox textBox_Altura;
        private System.Windows.Forms.Label label_4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_resultado_situação;
        private System.Windows.Forms.Label label_result_imc;
    }
}


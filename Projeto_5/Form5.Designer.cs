namespace Projeto_5
{
    partial class Form_reserva
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
            this.label_reserva = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_destino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_onibus = new System.Windows.Forms.RadioButton();
            this.radioButton_aviao = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label_destino = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_tranporte = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_confirma = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.button_calcular = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_reserva
            // 
            this.label_reserva.AutoSize = true;
            this.label_reserva.BackColor = System.Drawing.Color.SteelBlue;
            this.label_reserva.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reserva.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_reserva.Location = new System.Drawing.Point(11, 9);
            this.label_reserva.Name = "label_reserva";
            this.label_reserva.Padding = new System.Windows.Forms.Padding(160, 0, 160, 0);
            this.label_reserva.Size = new System.Drawing.Size(469, 20);
            this.label_reserva.TabIndex = 0;
            this.label_reserva.Text = "Reserva De Passagens";
            this.label_reserva.Click += new System.EventHandler(this.label_reserva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(59, 50);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(309, 20);
            this.textBox_nome.TabIndex = 2;
            this.textBox_nome.TextChanged += new System.EventHandler(this.textBox_nome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino";
            // 
            // comboBox_destino
            // 
            this.comboBox_destino.FormattingEnabled = true;
            this.comboBox_destino.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "SC"});
            this.comboBox_destino.Location = new System.Drawing.Point(72, 87);
            this.comboBox_destino.Name = "comboBox_destino";
            this.comboBox_destino.Size = new System.Drawing.Size(121, 21);
            this.comboBox_destino.TabIndex = 4;
            this.comboBox_destino.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_onibus);
            this.groupBox1.Controls.Add(this.radioButton_aviao);
            this.groupBox1.Location = new System.Drawing.Point(208, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 60);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meios de transportes";
            // 
            // radioButton_onibus
            // 
            this.radioButton_onibus.AutoSize = true;
            this.radioButton_onibus.Location = new System.Drawing.Point(117, 30);
            this.radioButton_onibus.Name = "radioButton_onibus";
            this.radioButton_onibus.Size = new System.Drawing.Size(58, 17);
            this.radioButton_onibus.TabIndex = 1;
            this.radioButton_onibus.TabStop = true;
            this.radioButton_onibus.Text = "Onibus";
            this.radioButton_onibus.UseVisualStyleBackColor = true;
            // 
            // radioButton_aviao
            // 
            this.radioButton_aviao.AutoSize = true;
            this.radioButton_aviao.Location = new System.Drawing.Point(30, 30);
            this.radioButton_aviao.Name = "radioButton_aviao";
            this.radioButton_aviao.Size = new System.Drawing.Size(52, 17);
            this.radioButton_aviao.TabIndex = 0;
            this.radioButton_aviao.TabStop = true;
            this.radioButton_aviao.Text = "Aviao";
            this.radioButton_aviao.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label_total);
            this.groupBox2.Controls.Add(this.label_destino);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label_tranporte);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(59, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 69);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores do Pacote";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(238, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "R$ ";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(263, 44);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(28, 13);
            this.label_total.TabIndex = 9;
            this.label_total.Text = "0,00";
            this.label_total.Click += new System.EventHandler(this.label9_Click);
            // 
            // label_destino
            // 
            this.label_destino.AutoSize = true;
            this.label_destino.Location = new System.Drawing.Point(176, 44);
            this.label_destino.Name = "label_destino";
            this.label_destino.Size = new System.Drawing.Size(28, 13);
            this.label_destino.TabIndex = 8;
            this.label_destino.Text = "0,00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(146, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "R$ ";
            // 
            // label_tranporte
            // 
            this.label_tranporte.AutoSize = true;
            this.label_tranporte.Location = new System.Drawing.Point(54, 44);
            this.label_tranporte.Name = "label_tranporte";
            this.label_tranporte.Size = new System.Drawing.Size(28, 13);
            this.label_tranporte.TabIndex = 6;
            this.label_tranporte.Text = "0,00";
            this.label_tranporte.Click += new System.EventHandler(this.label10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "R$ ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Valor Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Gastos com Destinoi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gastto do transporte";
            // 
            // button_confirma
            // 
            this.button_confirma.Location = new System.Drawing.Point(428, 47);
            this.button_confirma.Name = "button_confirma";
            this.button_confirma.Size = new System.Drawing.Size(75, 23);
            this.button_confirma.TabIndex = 9;
            this.button_confirma.Text = "Confirmar";
            this.button_confirma.UseVisualStyleBackColor = true;
            this.button_confirma.Click += new System.EventHandler(this.button_confirma_Click);
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(509, 47);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(75, 23);
            this.button_limpar.TabIndex = 10;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(428, 87);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(75, 23);
            this.button_calcular.TabIndex = 11;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // button_sair
            // 
            this.button_sair.Location = new System.Drawing.Point(509, 87);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 23);
            this.button_sair.TabIndex = 12;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = true;
            // 
            // Form_reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(624, 261);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_confirma);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_destino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_reserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_reserva";
            this.Text = "Reserva de passagem";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_reserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_destino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_onibus;
        private System.Windows.Forms.RadioButton radioButton_aviao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_confirma;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Label label_tranporte;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_destino;
        private System.Windows.Forms.Label label13;
    }
}


namespace Projeto_8
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_usu = new System.Windows.Forms.Label();
            this.textBox_usu = new System.Windows.Forms.TextBox();
            this.label_senha = new System.Windows.Forms.Label();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_usu
            // 
            this.label_usu.AutoSize = true;
            this.label_usu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usu.Location = new System.Drawing.Point(32, 40);
            this.label_usu.Name = "label_usu";
            this.label_usu.Size = new System.Drawing.Size(100, 25);
            this.label_usu.TabIndex = 0;
            this.label_usu.Text = "Usuario:";
            // 
            // textBox_usu
            // 
            this.textBox_usu.Location = new System.Drawing.Point(20, 87);
            this.textBox_usu.Name = "textBox_usu";
            this.textBox_usu.Size = new System.Drawing.Size(315, 20);
            this.textBox_usu.TabIndex = 1;
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_senha.Location = new System.Drawing.Point(32, 123);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(86, 25);
            this.label_senha.TabIndex = 2;
            this.label_senha.Text = "Senha:";
            // 
            // textBox_senha
            // 
            this.textBox_senha.Location = new System.Drawing.Point(20, 161);
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.Size = new System.Drawing.Size(315, 20);
            this.textBox_senha.TabIndex = 3;
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(20, 197);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(81, 31);
            this.button_cancelar.TabIndex = 4;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_entrar
            // 
            this.button_entrar.Location = new System.Drawing.Point(139, 197);
            this.button_entrar.Name = "button_entrar";
            this.button_entrar.Size = new System.Drawing.Size(81, 31);
            this.button_entrar.TabIndex = 5;
            this.button_entrar.Text = "Entrar";
            this.button_entrar.UseVisualStyleBackColor = true;
            this.button_entrar.Click += new System.EventHandler(this.button_entrar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 326);
            this.ControlBox = false;
            this.Controls.Add(this.button_entrar);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.textBox_senha);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.textBox_usu);
            this.Controls.Add(this.label_usu);
            this.Name = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_usu;
        private System.Windows.Forms.TextBox textBox_usu;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_entrar;
    }
}
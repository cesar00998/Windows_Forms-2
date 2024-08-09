using MySql.Data.MySqlClient;
using projeto_9.br.com.projeto.CONEXAO;
using projeto_9.br.com.projeto.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace projeto_9.br.com.projeto.DAO
{
    internal class ClientDAO
    {
        #region Conexao 
        private MySqlConnection conexao;

        public ClientDAO()
        {
            conexao = new MySqlConnection();
        }
    }
    #endregion

    #region  Cadastar 
    public void cadastrarCliente(Clientes obj)
    {
        try
        {
            //1 passe definir um comando sql 

            string sql = @"INSERT INTO  tb_clientes (nome, rg , cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, estado )
         VALUES (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @estado )";

            MySqlCommand executarcmd = new MySqlCommand(sql, conexao);

            executarcmd.Parameters.AddWithValue("@nome", obj.Nome);
            executarcmd.Parameters.AddWithValue("@rg", obj.Rg);
            executarcmd.Parameters.AddWithValue("@cpf", obj.cpf);
            executarcmd.Parameters.AddWithValue("@email", obj.email);
            executarcmd.Parameters.AddWithValue("@telefone", obj.telefone);
            executarcmd.Parameters.AddWithValue("@celular", obj.celular);
            executarcmd.Parameters.AddWithValue("@cep", obj.cep);
            executarcmd.Parameters.AddWithValue("@endereço", obj.endereço);
            executarcmd.Parameters.AddWithValue("@numero", obj.num);
            executarcmd.Parameters.AddWithValue("@complemento", obj.complento);
            executarcmd.Parameters.AddWithValue("@bairro", obj.bairro);
            executarcmd.Parameters.AddWithValue("@cidade", obj.cidade);
            executarcmd.Parameters.AddWithValue("@estados", obj.estado);

            Conexao

        }
    }
}



﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_6
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string EstadoCivil { get; set; }
        public string Telefone { get; set; }
        public bool CasaPropria { get; set; }
        public bool Veiculo { get; set; }
        public char Sexo { get; set; }
        //GET = Leitura
        //SET = Modificação

        public override string ToString()
        {
            return $"Nome: {Nome}, Telefone: {Telefone}";
        }

    }
}

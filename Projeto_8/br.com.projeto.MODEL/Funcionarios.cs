﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_8.br.com.projeto.MODEL
{
    internal class Funcionarios : Clientes
    {
       public string senha {  get; set; }

        public string Cargo { get; set; }

        public string Nivel_acesso { get; set; }
    }
}

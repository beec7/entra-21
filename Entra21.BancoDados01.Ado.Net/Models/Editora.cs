﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Models
{
    public class Editora
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Faturamento { get; set; }

        public DateTime DataCriacao { get; set; }

        public string Apelido { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDadoCidades.Ado.Net.Models
{
    public class Cidade
    {
        //PK
        public int Id { get; set; }

        public string Nome { get; set; }
        public int QuantidadeHabitante { get; set; }
        public DateTime DataHoraFundacao { get; set; }
        public double Pib { get; set; }


        //FK
        public UnidadeFederativa UnidadeFederativa { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio17
    {
        public void Executar()
        {
            int hora = 23, minuto = 59, segundo = 59;

            while (hora >= 0 && minuto >= 0 && segundo >= 0)
            {
                DateTime temporizador = new DateTime(1, 1, 1, hora, minuto, segundo);
                Console.WriteLine(temporizador.ToString("T"));
                segundo = segundo - 1;
                //Console.ReadKey();
                if (segundo < 0)
                {
                    segundo = 59;
                    minuto = minuto - 1;
                    if (minuto < 0)
                    {
                        minuto = 59;
                        hora = hora - 1;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

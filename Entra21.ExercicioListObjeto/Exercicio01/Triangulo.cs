using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioListObjeto.Exercicio01
{
    internal class Triangulo
    {
        public int Lado1;
        public int Lado2;
        public int Lado3;
        public int Codigo;

        public bool ValidorTriangulo()
        {
            if (Lado1 != 0)
            {
                if (Lado2 != 0)
                {
                    if (Lado3 != 0)
                    {
                        return true;
                    }
                }
            }  
            return false;
        }
    }
}

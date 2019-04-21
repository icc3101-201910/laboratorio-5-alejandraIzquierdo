using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5__Alejandra_Izquierdo
{
    class PerroFactorial
    {
        public int numero;

        public PerroFactorial(int numero)
        {
            this.numero = numero;
        }

        public static int Calcular(int numero)
        {
            if (numero > 13)
            {
                numero = 13;
            }

            
            int n;
            int final;
            final = 1;
            
            for (n = 1; n < numero; n++)
            {
                final = final * n;
                
            }
            return final;
        }
        public int GetNumero()
        {
            return numero;
        }
    }
}

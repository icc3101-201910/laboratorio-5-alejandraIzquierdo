using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5__Alejandra_Izquierdo
{
    class RobotFibonacci
    {
        public int numero;

        public RobotFibonacci(int numero)
        {
            this.numero = numero;
        }

        public static int Calcular(int numero)
        {
            if (numero > 46)
            {
                numero = 46;
            }

            int antiguo;
            int final;
            final = 1;
            antiguo = 1;
            int antiguo2;
            antiguo2 = 1;
            int n;
            for (n=0 ; n < numero;  n++)
            {
                //Console.WriteLine("hola");
                antiguo2 = antiguo;
                antiguo = final;
                final = antiguo2 + antiguo;
            }
            return final;
        }
        public int GetNumero(int numero)
        {
            return numero;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5__Alejandra_Izquierdo
{
    public class Cubo
    {
        public int numero;

        public Cubo(int numero)
        {
            this.numero = numero;
        }

        public static int Calcular(int numero)
        {
            
            return (numero*numero*numero);
        }
        public int GetNumero()
        {
            return numero;
        }
    }
}

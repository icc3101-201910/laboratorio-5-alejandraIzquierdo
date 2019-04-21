using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5__Alejandra_Izquierdo
{
    class Calculadora: ICalcular
    {
        private  int numero;
        public List<ICalcular> Calculadoras;

        public Calculadora(int numero, List<ICalcular> calculadoras)
        {
            this.numero = numero;
            Calculadoras = calculadoras;
        }

        public int Calcular(int numero)
        {
           return 8;
        }
        public int GetNumero()
        {
             return 9;
        }

        //List Calculadoras.Add(PerroFactorial);

    }
}

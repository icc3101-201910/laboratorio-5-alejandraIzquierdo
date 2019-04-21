using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5__Alejandra_Izquierdo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            while (a = true)
            {
                Console.WriteLine("Bienvenido a nuestra increible calculadora");
                Console.WriteLine("Por favor ingrese un numero");
                int numero;
                numero = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Por favor elija una operación a realizar con su número");
                Console.WriteLine("a) Cuadrado");
                Console.WriteLine("b) Cubo");
                Console.WriteLine("c) Fibonacci");
                Console.WriteLine("d) Factorial");
                Console.WriteLine("e) Persona que suma 5");
                Console.WriteLine("f) Salir");
                Console.WriteLine("Escriba la letra de la operación que desea realizar: ");
                string operacion;
                operacion = Console.ReadLine();
                int numerofinal;
                if (operacion == "a") 
                {
                    numerofinal = Cuadrado.Calcular(numero);
                    Console.WriteLine(numerofinal);

                }
                else if (operacion == "b") 
                {
                    numerofinal = Cubo.Calcular(numero);
                }
               
                else if (operacion == "c")
                {
                    numerofinal = RobotFibonacci.Calcular(numero);
                    Console.WriteLine(numerofinal);
                    //Console.WriteLine()
                }
                else if (operacion == "d")
                {
                    numerofinal = PerroFactorial.Calcular(numero);
                    Console.WriteLine(numerofinal);
                    //Console.WriteLine()
                }
                else  if (operacion == "e") 
                {
                    numerofinal = PersonaQueSuma5.Calcular(numero);
                    Console.WriteLine(numerofinal);
                }
                else if (operacion == "f") 
                {
                    a = false;
                }
            }





        }

         
    }
}

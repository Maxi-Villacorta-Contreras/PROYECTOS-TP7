using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        /* Realizar un programa que lea 10 números reales por teclado, los almacene en un arreglo y muestre por 
           pantalla la suma, resta y multiplicación de todos los números ingresados al arreglo. */

        static void Main(string[] args)
        {
            double suma = 0, resta, multiplicacion = 1, num = 1;
            double[] array = new double[10];

            Console.WriteLine("Ingrese 10 numeros Reales");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("\nIngrese el " + num + " numero: ");
                array[i] = Double.Parse(Console.ReadLine());

                num++;
            }

            resta = array[0] + array[0];

            for (int i = 0; i < 10; i++)
            {
                suma += array[i];
                resta -= array[i];
                multiplicacion *= array[i];
            }

            Console.Clear();

            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------\n");

            Console.WriteLine("\nLa suma de todos los numeros Ingresados es: " + suma);
            Console.WriteLine("\nLa resta de todos los numeros Ingresados es: " + resta);
            Console.WriteLine("\nLa multiplicacion de todos los numeros Ingresados es: " + multiplicacion);

            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------\n");

            Console.ReadKey();

        }
    }
}
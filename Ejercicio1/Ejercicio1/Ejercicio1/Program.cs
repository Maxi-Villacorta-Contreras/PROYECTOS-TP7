using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        /* Realizar un programa que rellene un vector con 5 valores ingresados por el usuario y los muestre por pantalla. */

        static void Main(string[] args)
        {
            int[] array = new int[5];

            for (int j = 0; j < 5; j++)
            {
                Console.Write("\nIngrese un numero para rellenar el vector: ");
                array[j] = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------\n");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------\n");

            Console.ReadKey();
        }
    }
}
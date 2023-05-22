using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        /* Realizar un programa que rellene un vector de tamaño N, con valores ingresados por el usuario. 
         * A continuación, se debe buscar un elemento dentro del arreglo (el número a buscar también debe ser
         * ingresado por el usuario). El programa debe indicar la posición donde se encuentra el valor. En caso que el
         * número se encuentre repetido dentro del arreglo se deben imprimir todas las posiciones donde se
         * encuentra ese valor. Finalmente, en caso que el número a buscar no está adentro del arreglo se debe
         * mostrar un mensaje. */

        static void Main(string[] args)
        {
            int max, contador = 1, num = 0;
            bool aux = false;

            Console.Write("Ingrese el tamaño del Vector: ");
            max = int.Parse(Console.ReadLine());

            int[] array = new int[max];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("\nIngrese el " + contador + " numero: ");
                array[i] = int.Parse(Console.ReadLine());

                contador++;
            }

            Console.Clear();

            Console.Write("Ingrese el numero que desea encontrar en el Vector: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n--------------------------------------------------------------------------------------------------------------\n");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    Console.WriteLine("El numero " + num + " se encuentra en la posicion numero " + i + " del Vector");

                    aux = true;
                }
            }

            if (!aux)
            {
                Console.WriteLine("El numero " + num + " no se encuentra en el Vector");
            }

            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------\n");

            Console.ReadKey();
        }
    }
}
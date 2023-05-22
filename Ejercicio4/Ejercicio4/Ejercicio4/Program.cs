using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        /* 
                 Disponemos de un vector unidimensional de 20 elementos de tipo carácter. Se pide desarrollar un programa que:
                   a) Pida una frase al usuario y luego ingrese la frase dentro del arreglo letra por letra. 
                   b) Una vez completado lo anterior, pedirle al usuario un carácter cualquiera y una posición dentro del arreglo, y el programa debe intentar 
                   ingresar el carácter en la posición indicada, si es que hay lugar (es decir la posición está vacía o es un espacio en blanco). De ser posible
                   debe mostrar el vector con la frase y el carácter ingresado, de lo contrario debe darle un mensaje al usuario de que esa posición estaba ocupada.
        */

        static void Main(string[] args)
        {
            int posicion;
            char caracter;
            string frase;
            char[] array = new char[20];


            Console.Write("Ingrese una frase: ");
            frase = Console.ReadLine();

            for (int i = 0; i < frase.Length && i < 20; i++)
            {
                array[i] = frase[i];

            }

            Console.Write("\nIngrese el caracter que desea agregar a la frase: ");
            caracter = char.Parse(Console.ReadLine());

            Console.Write("\nIngrese la posición  donde desea agregar el caracter (entre 0 y 19): ");
            posicion = int.Parse(Console.ReadLine());

            if (posicion >= 0 && posicion <= 19)
            {
                if (array[posicion] == '\0')
                {
                    array[posicion] = caracter;

                    Console.Clear();

                    Console.Write("La frase con el caracter ingresado es: \n");

                    Console.WriteLine("\n\n----------------------------------------------------------------------------------------\n");

                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write(array[i]);
                    }

                    Console.WriteLine("\n\n----------------------------------------------------------------------------------------\n");

                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("La posición indicada está ocupada por otro caracter");
                }
            }
            else
            {
                Console.Clear();

                Console.WriteLine("La posición indicada no se encuentra entre 1 y 19");
            }


            Console.ReadKey();
        }
    }
}
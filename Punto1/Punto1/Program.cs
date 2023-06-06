using System;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Ingrese el tamaño del array:");
                int tamañoArray = Convert.ToInt32(Console.ReadLine());

                int[] array = new int[tamañoArray];

                Console.WriteLine("Ingrese un número para generar los múltiplos:");
                int numero = Convert.ToInt32(Console.ReadLine());

                RellenarArrayConMultiplos(array, numero);
                MostrarMultiplos(array);

                Console.WriteLine("¿Desea ingresar otro array y número? (s/n)");
                string respuesta = Console.ReadLine();

                if (respuesta.ToLower() != "s")
                {
                    continuar = false;
                }

                Console.WriteLine();
            }

        }
        static void RellenarArrayConMultiplos(int[] array, int numero)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = numero * (i + 1);
            }
        }


        static void MostrarMultiplos(int[] array)
        {
            Console.WriteLine("Los múltiplos generados son:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}

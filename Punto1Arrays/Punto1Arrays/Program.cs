using System;

namespace Punto1Arrays
{
    public class Punto1Arrays
    {
        static void Main(string[] args)
        {
            int size, numero;
            bool exit = false;
            string respuesta;

            while (!exit)
            {
                Console.WriteLine("Ingrese el tamaño del array:");
                size = Convert.ToInt32(Console.ReadLine());

                int[] array = new int[size];

                Console.WriteLine("Ingrese el número para generar los múltiplos:");
                numero = Convert.ToInt32(Console.ReadLine());

                RellenarArrayMultiplos(array, numero);
                MostrarArray(array);

                Console.WriteLine("¿Desea ingresar otro array y número? (S/N)");
                respuesta = Console.ReadLine();

                if (respuesta.ToUpper() == "N")
                    exit = true;
            }
        }

        static void RellenarArrayMultiplos(int[] array, int numero)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = numero * (i + 1);
            }
        }

        static void MostrarArray(int[] array)
        {
            Console.WriteLine("Los múltiplos generados son:");

            foreach (int numero in array)
            {
                Console.Write(numero + " ");
            }

            Console.WriteLine();
        }
    }
}

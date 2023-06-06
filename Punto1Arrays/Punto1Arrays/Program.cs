using System;

namespace Punto1Arrays
{
    internal class Punto1Arrays
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

                
            }
        }
    }
}

using System;

namespace Punto1Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool nuevoArray = true;

            while (nuevoArray)
            {
                Console.Write("Ingrese el tamaño del arreglo: ");
                int m = Convert.ToInt32(Console.ReadLine());

                int[] array = new int[m];

                Console.Write("Ingrese un número: ");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("¿Desea conocer los multiplos de otro número? (Si/No)");
                string opcion = Console.ReadLine();
                nuevoArray = (opcion.ToLower() == "Si");
            }
        }
    }
}

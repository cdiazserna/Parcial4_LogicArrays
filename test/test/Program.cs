using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)

        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Ingrese el tamaño del array: ");
                int tamaño = int.Parse(Console.ReadLine());

                int[] array = new int[tamaño];

                Console.WriteLine("Ingrese un número para calcular sus múltiplos: ");
                int numero = int.Parse(Console.ReadLine());

                RellenarArray(array, numero);
                MostrarMultiplos(array);

                Console.WriteLine("¿Desea continuar? (S/N)");
                string opcion = Console.ReadLine().ToUpper();

                if (opcion == "N")
                {
                    continuar = false;
                }

                Console.Clear();
            }
        }

        static void RellenarArray(int[] array, int numero)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = numero * (i + 1);
            }
        }

        static void MostrarMultiplos(int[] array)
        {
            Console.WriteLine("Los múltiplos son:");
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }


    }
}




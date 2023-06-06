using System;

namespace Punto1Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamañoarray, multpnum;
            int menu = 1;

            while (menu==1)
            {
                Console.WriteLine("De qué temaño desea que sea el Array?");
                tamañoarray = Convert.ToInt32(Console.ReadLine());

                int[] array = new int[tamañoarray];

                Console.WriteLine("De qué número desea optener sus múltiplos?");
                multpnum = Convert.ToInt32(Console.ReadLine());

                CompletarElArray (array, multpnum);
                Multiplos (array);

                Console.WriteLine("Presione 1 para volver a realizar la operación o 0 para salir");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            
        }

        static void CompletarElArray (int[] array, int num)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = num * (i + 1);
            }
        }
        static void Multiplos (int[] array)
        {
            Console.WriteLine("Los múltiplos del número elegido son: ");
            foreach (int numero in array)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }

    }
}

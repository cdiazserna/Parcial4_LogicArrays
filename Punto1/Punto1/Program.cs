using System;

namespace Punto1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamaño del array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine("Ingrese un número");
            int number = Convert.ToInt32(Console.ReadLine());

            FilloutArray(number, array);
            ShowResult();

            Console.WriteLine();
        }

        static void FilloutArray(int number, int[] array)

        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = number * (i + 1);
            }
    
        }

        static void FilloutArray(int number, int[] array)

        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = number * (i + 1);
            }

        }
    }

using System;

namespace Punto1Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {

            int num;
            bool Nuevoarray = true;
            

            while (Nuevoarray)
            {
                Console.Write("Ingrese el tamaño del array: ");
                int m = Convert.ToInt32(Console.ReadLine());

                int[] arrayM = new int[m];

                Console.Write("Ingrese un número: ");
                num = Convert.ToInt32(Console.ReadLine());

                Multiplos(arrayM, num);
                mostrarMultiplos(arrayM);

                Console.WriteLine("¿Desea crear otro multiplo? (si/no)");
                string opcion = Console.ReadLine();
                Nuevoarray = (opcion.ToLower() == "si");


            }
        }

        static void Multiplos(int[] arrayM, int num)
        {
            for (int i = 0; i < arrayM.Length; i++)
            {
                arrayM[i] = num * (i + 1);
            }
        }

        static void mostrarMultiplos(int[] arrayM)
        {
            Console.WriteLine("Los múltiplos del arreglo son:");
            for (int i = 0; i < arrayM.Length; i++)
            {
                Console.WriteLine(arrayM[i]);
            }

            
        }
    }
}


    
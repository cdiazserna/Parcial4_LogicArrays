using System;

namespace Punto1Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool continu=true;
           
            while (continu) 
            {

                Console.WriteLine("Ingrese el tamaño del array: ");
                int tamaño = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[tamaño];
                Console.WriteLine("Ingrese un número para calcular sus múltiplos: ");
                int numero = Convert.ToInt32(Console.ReadLine());


                RellenarArray(array, numero);
                MostrarMultiplos(array);

               
                Console.WriteLine("¿Desea continuar? (S/N)");
                string opcion = Console.ReadLine().ToUpper();

                if (opcion == "N")
                {
                   continu = false;
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
    
        
    


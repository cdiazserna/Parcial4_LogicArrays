using System;

namespace Punto1Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {// utilizamos le condicional while luego definimos el trigger del while

            bool continu=true;
            // definimos la variable boleana para activar la condicion, la inicializamos en true
            while (continu) 
            {

                Console.WriteLine("Ingrese el tamaño del array: ");//pedimos los datos al usuario
                int tamaño = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[tamaño];//Creamos el array pero lo ato al valor ingresado por el usuario
                Console.WriteLine("Ingrese un número para calcular sus múltiplos: ");
                int numero = Convert.ToInt32(Console.ReadLine());


                RellenarArray(array, numero);//referenciamos los metodos
                MostrarMultiplos(array);

                // creamos la opcion para continuar
                //Console.WriteLine("¿Desea continuar? (S/N)");
                //string opcion = Console.ReadLine().ToUpper();//aseguramos  que siempre se convierta a mayusculas

                //if (opcion == "N")//Condicional para enviar a while
                //{
                //    continu = false;
                //}
                // metodos para mostras  y para rellenar los array


                Console.Clear(); //limpiamos la pantalla
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
    
        
    


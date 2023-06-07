using System;

namespace Punto1Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Punto 1:Crea un array donde el usuario le indique el tamaño por teclado.
            //Crear un subprograma que rellene el array con los múltiplos de un número pedido por teclado.
            //Por ejemplo, si defino un array de tamaño 5 y elijo un 3 en el subprograma,
            //el array contendrá(debe comenzar desde el número ingresado):3691215Muestra
            //los  múltiplos  resultantes  por  pantalla  usando  otro  subprograma, Además,
            //el algoritmo debe estar en la capacidad de volver al inicio para pedir un nuevo array y número.
            int stwh = 1;

            while(stwh == 1)
            {
                EnterData();

            }

        }
        public static void EnterData()
        {
            int n;
            Console.WriteLine(" por favor introduce el tamaño del recuadro");
            n=Convert.ToInt32(Console.ReadLine());
            int[] Stuffed=new int[n];
        }
    }
}
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
            int stwh = 1,n;
            int[] stuffed;
            while(stwh == 1)
            {
                EnterData(out n,out stuffed);
                stuffed=ArrayPadding( n, stuffed);
                ShowResults(stuffed,out stwh);
            }

        }
        public static void EnterData(out int n, out int[] Stuffed)
        {
          
            Console.WriteLine(" por favor introduce el tamaño del recuadro");
            n=Convert.ToInt32(Console.ReadLine());
             Stuffed=new int[n];
        }
        public static int[] ArrayPadding(int n,int[] STuffed)
        {
            
            STuffed = new int[n];
            
            Console.WriteLine("por favor ingresa el numero que deseas ver los multiplos");
            STuffed[0]= Convert.ToInt32(Console.ReadLine());
            
            for (int i=1;i<STuffed.Length;i++) 
            {
                STuffed[i] = STuffed[0] * (i + 1);
                
            }
            return STuffed;
            
        }
        public static void ShowResults(int[] stuffed,out int stwh)
        {
            Console.WriteLine("\n los multimplos son : \n");
            for (int i = 0; i < stuffed.Length; i++)
            {
                
                Console.WriteLine(stuffed[i]);
            }
            Console.WriteLine("\n Si deseas introducir otro numero marca 1 o cualquiera para finalizar");
            stwh= Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }
    }
}
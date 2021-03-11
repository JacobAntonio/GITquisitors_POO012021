using System;

namespace Program2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa que resta dos numeros");  
             
            int a=0, b=0;

            Console.WriteLine ("Ingrese primer numero: ");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine ("Ingrese segundo numero: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine ($"Restando {a} - {b} que es igual a { AddNumbers (a, b) }");
        }
        public static int AddNumbers(int a, int b)
        {
          return a - b;
        }

    }
    
    
}

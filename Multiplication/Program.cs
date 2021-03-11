using System;
/*XD se me ocurrió de la nada venir aquí y copiar la Biblia entera en este comentario solo 
para fregar, tal vez lo haga en álguna otra ocasión, xd, en un exámen o algo, copiar libros 
enteros intercalados en el código solo para fregar. Creo que los coordinadores no lo van a 
apreciar a decir verdad y me van a bajar puntos, pero a decir verdad, estoy algo tentado a
hacerlo. Tal vez pixel art o algo así será menos molesto, la verdad no sé, pero me gustaría
intentarlo al menos una vez. Será la signatura mía cada vez que haga un programa, en los
comentarios copiar y pegar algún texto extremadamente largo, como la Mahabaratha, el Corán,
La Canción de Hielo y Fugo o la serie entera de Dune. Bueno A saber
Disfruten para mientras sus códigos limpios.
Porque no van a dura mucho.*/

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = 0, b = 0;
           
            Console.WriteLine("Enter a value for a: ");
            a=Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b: ");
            b=Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplying {a} * {b} equals {AddNumbers(a, b)}");
        }
        public static int AddNumbers(int a, int b)
        {
            //¿Solamente esto? ¿Náda más? Un buen comienzo a decir verdad, sirve para refrescar el conocimiento previo.
            return a * b;
        }
    }
}

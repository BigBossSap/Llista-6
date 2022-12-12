using System;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5. Demanar una frase (string) i la mostri al revés
   */

            string frase;
           

            Console.WriteLine("frase: ");
            frase = Console.ReadLine();


            for (int i = 1; i <= frase.Length; i++)
            {

                Console.Write(frase[frase.Length-i]);
            }

            
            
        }
    }
}

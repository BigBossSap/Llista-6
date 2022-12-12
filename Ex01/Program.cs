using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            
            Console.WriteLine("Frase: ");
            frase = Console.ReadLine();

            for (int i=0; i<frase.Length; i++)
            {
                Console.WriteLine(frase[i]);
            }


        }
    }
}

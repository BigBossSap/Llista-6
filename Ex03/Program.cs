using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. Demanar una frase (string) i comptar vocals*/


            string frase;
            int cont = 0;

            Console.WriteLine("frase: ");
            frase = Console.ReadLine();

            for (int i = 0; i < frase.Length;i++)
            {
                //if (frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u')
                //   cont++;
                if ("aeiou".Contains(frase[i]))
                    cont++;
            }

            Console.WriteLine($"{cont} vocals");
        }
    }
}

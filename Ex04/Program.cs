using System;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4.Demanar una frase(string) i comptar diftongs(2 vocals seguides mirar
 diftongs existents) */



            string frase;
            int cont = 0;

            Console.WriteLine("frase: ");
            frase = Console.ReadLine();

            for (int i = 0; i < frase.Length-1; i++)
            {
                
                if ("aeiou".Contains(frase[i])&& ("iu".Contains(frase[i + 1])))
                    if(frase[i]!='i' || frase [i+1]!='i')
                         cont++;
                

               
                    
            }

            Console.WriteLine(cont);

            //ai ei oi ui au eu iu ou uu


        }
    }
}

using System;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7. Demanar una frase (string) i canviar espais per asteriscos sense mètodes i
amb metode Replace*/

            //amb metodes
            string frase;


            Console.WriteLine("frase: ");
            frase = Console.ReadLine();

            Console.WriteLine(frase.Replace(' ', '*'));

            //sense metodes

            string frase2 = "";

            for (int i=0; i<frase.Length; i++)
            {
                if (frase[i] != ' ')
                    frase2 += frase[i];
                else
                    frase2 += "*";
            }

            Console.WriteLine(frase2);

            

            

        }
    }
}

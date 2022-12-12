using System;

namespace Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 8.Demanar una frase(string) i posar-la en majúscules. Si ja ho és que no la
 toqui sense mètodes i amb mètodes
            */

            //Sense metodes

            string frase, fraseM="";


            Console.WriteLine("frase: ");
            frase = Console.ReadLine();


            for (int i = 0; i <= frase.Length-1; i++)
            {
                if (frase[i] == ' ')
                    fraseM += frase[i];

                else if ("a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,v,w,z".Contains(frase[i]))
                    fraseM += ((char)(frase[i] - 32));
            }

            Console.WriteLine(fraseM);


            //Amb metodes

            Console.WriteLine(frase.ToUpper());


        }
    }
}

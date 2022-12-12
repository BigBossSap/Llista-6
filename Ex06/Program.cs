using System;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {



            /*
           6. Demanar una frase (string) i dir si és un palíndrom
            */

            string frase, fraseO = "", fraseReves = "";

            Console.WriteLine("frase: ");
            frase = Console.ReadLine();

            


            for (int i = frase.Length-1; i >= 0; i--)
            {
                if("a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,v,w,z".Contains(frase[i]))
                fraseReves += (frase[i]);
            }

            
            for ( int j=0;j<frase.Length;j++)
            {
                
                if ("a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,v,w,z".Contains(frase[j]))
                fraseO += (frase[j]);
            }

            


          
            
            Console.WriteLine(fraseReves);
            Console.WriteLine(fraseO);
            if (fraseO==fraseReves)
                Console.WriteLine("Es palindrom");
            else
                Console.WriteLine("No es palindrom");

           




        }
    }
}

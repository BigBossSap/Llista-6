using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*10. Quan fem n=Convert.ToInt32(Console.ReadLine()); el convert pot petar.
Fes el codi que faríem per saber si petarà o no. Peta quan no només hi ha
dígits, quan és na frase buida i quan l'enter que hi ha és superior a
2147483647*/



            string n;
            string comparador = "2147483647";
            int cont = 0;
            
            Console.WriteLine("n");
            n = Console.ReadLine();


            for (int i = 0; i < n.Length; i++)
            {
                if ("0123456789".Contains(n[i]))
                    cont++;
               
            }

            if (cont != n.Length)
                Console.WriteLine("Fallarà");
            else if (cont == 0)
                Console.WriteLine("Fallarà");
           
            else if (n.Length>10)
                Console.WriteLine("Fallarà");
            else if(String.Compare(n,comparador)==1 &&n.Length==10)
                Console.WriteLine("Fallarà");

            Console.WriteLine(comparador);
            Console.WriteLine(cont);
            Console.WriteLine(n.Length);

            
        }
    }
}

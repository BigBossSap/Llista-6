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
                if ("0,1,2,3,4,5,6,7,8,9".Contains(n[i]))
                    cont++;
               
            }

            if (cont != n.Length)
                Console.WriteLine("Fallarà");
            if (cont == 0)
                Console.WriteLine("Fallarà");
            if(n.Length>10)
                Console.WriteLine("Fallarà");
            if(String.Compare(n,comparador)==1)
                Console.WriteLine("Fallarà");

            Console.WriteLine(comparador);
            Console.WriteLine(cont);
            Console.WriteLine(n.Length);

            
        }
    }
}

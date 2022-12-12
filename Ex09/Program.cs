using System;

namespace Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*9.Demanar 2 cadenes(strings) i que miri totes les vegades que la 2ª està dins
 de la primera(pensar quants cops trobem frase 2 dintre de
 frase1.Substring...)
 */



            string frase, paraula, aux;
            int cont = 0;
            Console.WriteLine("frase");
            frase = Console.ReadLine();
            Console.WriteLine("paraula");
            paraula = Console.ReadLine();



            aux = frase;
            while(aux.Contains(paraula))
            {
                aux = aux.Substring(aux.IndexOf(paraula) + paraula.Length);
                cont++;
            }

            Console.WriteLine(cont);

        
        }
    }
}

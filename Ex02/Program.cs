using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2. Demanar el nom i cognoms per separat de 2 persones i dir quina va
    alfabèticament abans. Seguim ordre de primer cognom, segon cognom i
    nom. Fer sense i amb mètodes de l’string.
    */


            string nom1, nom2, cognom1, cognom2, cognom12, cognom11; 

            Console.WriteLine("nom1: ");
            nom1 = Console.ReadLine();
            Console.WriteLine("cognom1: ");
            cognom1 = Console.ReadLine();
            Console.WriteLine(": ");
            cognom11 = Console.ReadLine();
            Console.WriteLine("nom2: ");
            nom2 = Console.ReadLine();
            Console.WriteLine("nom1: ");
            cognom2 = Console.ReadLine();
            Console.WriteLine("nom2: ");
            cognom12 = Console.ReadLine();


            if (String.Compare(cognom1,cognom2)>0)
                Console.WriteLine($"{cognom2} va alfabeticament abans que {cognom1}");
            else if (String.Compare(cognom1, cognom2) < 0)
                Console.WriteLine($"{cognom1} va alfabeticament abans que {cognom2}");
            else
            {
                if (String.Compare(cognom11, cognom12) > 0)
                    Console.WriteLine($"{cognom12} va alfabeticament abans que {cognom12}");
                else if (String.Compare(cognom11, cognom12) < 0)
                    Console.WriteLine($"{cognom11} va alfabeticament abans que {cognom12}");

                else
                {

                    if (String.Compare(nom1, nom2) > 0)
                        Console.WriteLine($"{nom2} va alfabeticament abans que {nom1}");
                    else if (String.Compare(cognom11, cognom12) < 0)
                        Console.WriteLine($"{nom1} va alfabeticament abans que {nom2}");
                }
            }



        }
    }
}

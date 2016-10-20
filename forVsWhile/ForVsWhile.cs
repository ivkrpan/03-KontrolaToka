using System;

namespace Vsite.CSharp
{
    public class ForVsWhile
    {
        public static void PetljaFor(int n)
        {
            // TODO: Napisati petlju for koja će ispisati brojeve od 0 do (uključivo) n
            for (int i = 0; i <= n; ++i) {
                Console.WriteLine(i);
            }
        }

        public static void PetljaWhile(int n)
        {
        int j =0;
            // TODO: Napisati petlju while koja će ispisati brojeve od 0 do (uključivo) n
        while (j <= n){
            Console.WriteLine(j);
            ++j;
        }
        }

        static void Main(string[] args)
        {
            PetljaFor(10);

            PetljaWhile(10);

            // TODO: Prevesti program te programom ILDasm usporediti međukod gornjih metoda.

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}

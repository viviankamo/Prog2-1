using System;
using System.Collections.Concurrent;
using System.Diagnostics.SymbolStore;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] _siffror = { 1, 2, 3, 4 };
            string[] _namn = { "vivian", "philip", "filippa", "mary", "amanda" };
            int[] _slumptal = { 1, 2, 3, 4, 5 };

            Console.WriteLine(hello(_siffror));
            hello(_namn);
            bye(_slumptal);
        }
        static int hello(int[] siffror)
        {
            var sum = 0;
            for (int i = 0; i < siffror.Length; i++)
            {
                sum = sum + siffror[i];
            }
            return sum;
        }
        static void hello(string[] namn)
        {
            for(int i = namn.Length -1; i >= 0; i--)
            {
                Console.WriteLine(namn[i]);
            }

        }
        static int[] bye(int[] slumptal)
        {
            int största = slumptal[0];
            int minsta = slumptal[0];
            int[] resultat = { största, minsta };

            for(int i = 1; i < slumptal.Length; i++)
            {
                if (slumptal[i] > största)
                {
                    största = slumptal[i];
                }
                if (slumptal[i] < minsta)
                {
                    minsta = slumptal[i];
                }
            }
            Console.WriteLine(största);
            Console.WriteLine(minsta);
            return resultat;

        }
    }
}

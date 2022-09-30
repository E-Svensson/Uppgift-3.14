using System;
using System.Globalization;

namespace Uppgift_314
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? (JA eller NEJ)");
            Console.Write("Svara här: "); string svar1 = Console.ReadLine().ToLower();
            Console.WriteLine("Hur gammal är du?");
            Console.Write("Svara här: "); int svar2 = int.Parse(Console.ReadLine());

            char[] svar = svar1.ToCharArray();

            if (svar[0] == 'j' && svar2 < 22)
            {
                Console.WriteLine("Vi vil gärna anställa sig.");
            }

            else
            {
                Console.WriteLine("Vi leter tyvärr efter annan personal just nu.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Terulet
{
    internal class Program
    {
        static void terulet() 
        {
            Console.WriteLine("Téglalap területének számítása");

            int a;
            int b;
            int T;

            do
            {
                Console.WriteLine("Kérem az 'a' oldal értékét (0-nál nagyobb).");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a <= 0);

            do
            {
                Console.WriteLine("Kérem a 'b' oldal értékét (0-nál nagyobb)");
                b = Convert.ToInt32(Console.ReadLine());
            } while (b <= 0);

            T = a * b;

            //Console.WriteLine("A téglalap területe: {0}", T);
            Console.WriteLine($"A téglalap területe: {T}");

        }
        static void Main(string[] args)
        {
            terulet ();
        }
    }
}

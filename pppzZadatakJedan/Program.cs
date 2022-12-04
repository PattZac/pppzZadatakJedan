using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pppzZadatakJedan
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            //Korisnik upiše broj stranice
            do {
                Console.WriteLine("Unesite x stranicu pravokutnog trokuta: ");
                x = Convert.ToInt32(Console.ReadLine());
                if (x < 1) {
                    Console.WriteLine("\r\nMora biti veči od 0!\r\n");
                }
            } while (x < 1);
            do
            {
                Console.WriteLine("\r\nUnesite y stranicu pravokutnog trokuta: ");
                y = Convert.ToInt32(Console.ReadLine());
                if (y < 1)
                {
                    Console.WriteLine("\r\nMora biti veči od 0!");
                }
            } while (y < 1);
            do
            {
                Console.WriteLine("\r\nUnesite z stranicu pravokutnog trokuta: ");
                z = Convert.ToInt32(Console.ReadLine());
                if (z < 1)
                {
                    Console.WriteLine("\r\nMora biti veči od 0!");
                }
            } while (z < 1);

            //Provjeri prvo koji je stranica je najduža, i povjeri jeli je vrijednost taj staranica jednak hipotenuza.

            if(x>y && x>z && x == Convert.ToInt32( Math.Sqrt(Math.Pow(y, 2) + Math.Pow(z, 2) ) ) )
            {
                Console.WriteLine("\r\nVrijednosti stranice pravokutnog trokuta su točne!");
            }
            else if (y > x && y > z && y == Convert.ToInt32(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(z, 2))))
            {
                Console.WriteLine("\r\nVrijednosti stranice pravokutnog trokuta su točne!");
            }
            else if (z > y && z > x && z == Convert.ToInt32(Math.Sqrt(Math.Pow(y, 2) + Math.Pow(x, 2))))
            {
                Console.WriteLine("\r\nVrijednosti stranice pravokutnog trokuta su točne!");
            }
            else
            {
                Console.WriteLine("\r\nVrijednosti stranice pravokutnog trokuta su netočne!");
            }
            Console.ReadKey();
        }
    }
}

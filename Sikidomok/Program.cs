using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    internal class Program
    {
        static List<Sikidom> sikidomok = new List<Sikidom>();
        static void Main(string[] args)
        {
            //kor.Atmero = 6;
            try
            {
                sikidomok.Add(new Teglalap(2.8, 4));
                sikidomok.Add(new Kor(3));
                sikidomok.Add(new Haromszog(9, 8, 10));
                sikidomok.Add(new Haromszog(9, 10));
                sikidomok.Add(new Haromszog(5));

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            } 
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach (Sikidom item in sikidomok)
            {
                Console.WriteLine($"{item.Nev}\tkerülete: {item.Kerulet:N2}\tterülete:{item.Terulet:N2}");
            }
            //kor.Sugar = 3;
            Console.WriteLine("\nProgram vége!");
            Console.ReadKey();
        }
    }
}

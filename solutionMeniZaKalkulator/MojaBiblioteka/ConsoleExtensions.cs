using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaBiblioteka
{
    public static class ConsoleExtensions
    {
        public static void ShowMessage(string poruka)
        {
            Console.Clear();
            Console.WriteLine(poruka);
            Console.WriteLine("Priitisni ENTER za nastavak");
            Console.ReadLine();
        }
        public static void ShowError(string poruka)
        {
            ConsoleColor currentColor = Console.ForegroundColor;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(poruka);
            Console.WriteLine("Priitisni ENTER za nastavak");
            Console.ReadLine();
            Console.ForegroundColor = currentColor;
        }
        public static double ReadDouble(string poruka)
        {
            Console.Clear();
            Console.WriteLine(poruka);
            string prviBroj = Console.ReadLine();
            double broj = double.Parse(prviBroj);

            return broj;
        }
        public static double Stepenovanje(double x, double y)
        {
            Console.Clear();

            double rezultat = 1;
            if (y == 0)
                rezultat = 1;
            else if (y > 0)
            {
                for (int i = 0; i < y; i++)
                    rezultat *= x;
            }
            else
            {
                y = y * -1;
                for (int i = 0; i < y; i++)
                    rezultat *= x;
                rezultat = 1 / rezultat;
            }
            return rezultat;
        }               
    }    
}

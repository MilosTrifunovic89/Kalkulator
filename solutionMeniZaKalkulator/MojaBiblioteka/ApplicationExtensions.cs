using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaBiblioteka
{
    public static class ApplicationExtensions
    {
        public static void WriteAppHeader(string naziv)
        {
            Console.WriteLine("".AlignRight(80, '*'));
            Console.WriteLine(naziv.AlignCenter(80, '*'));
            Console.WriteLine("".AlignLeft(80, '*'));
        }
    }
}

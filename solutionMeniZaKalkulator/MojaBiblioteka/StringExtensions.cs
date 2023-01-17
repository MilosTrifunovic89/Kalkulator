using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaBiblioteka
{
    public static class StringExtensions
    {
        
        public static string AlignRight(this string tekst, int duzina, char karakter)
        {
            string result = tekst;
            while (result.Length < duzina)
            {
                result = karakter.ToString() + result;
            }

            return result;
        }
        public static string AlignLeft(this string tekst, int duzina, char karakter)
        {
            string result = tekst;
            while (result.Length < duzina)
            {
                result = result + karakter.ToString();
            }

            return result;
        }
        public static string AlignCenter(this string tekst, int duzina, char karakter)
        {
            string result = tekst;

            int left = (duzina - tekst.Length) / 2;

            while (result.Length < left + tekst.Length)
            {
                result = karakter.ToString() + result;
            }
            while (result.Length < duzina)
            {
                result = result + karakter.ToString();
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MojaBiblioteka;

namespace MeniZaKalkulator
{

    class Program
    {
        

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            bool krajRada = false;

            string izbor;
            do
            {
                Console.Clear();
                string nazivPrograma = "KALKULATOR ver 1.0";

                ApplicationExtensions.WriteAppHeader(nazivPrograma);

                Console.WriteLine("\nMENI");
                Console.WriteLine("\t1. Sabiranje");
                Console.WriteLine("\t2. Oduzimanje");
                Console.WriteLine("\t3. Mnozenje");
                Console.WriteLine("\t4. Deljenje");
                Console.WriteLine("\t5. Stepenovanje");
                Console.WriteLine("\t6. Korenovanje");
                Console.WriteLine("\t7. Binarni broj u decimalni");
                Console.WriteLine("\t8. Datum i vreme DD/MM/YYYY");
                Console.WriteLine("\t9. Datum i vreme dd/mm/yyyy");
                Console.WriteLine("\t10. Pretvaranje decimalnog u binarni");
                Console.WriteLine("\t11. Pretvaranje binarnog u heksadecimalni");
                Console.WriteLine("\tX. Izlaz\n");
                Console.Write("VAS IZBOR: ");

                izbor = Console.ReadLine();

                Console.Clear();

                switch (izbor.ToLower())
                {
                    case "1":
                        {
                            double brojJedan = ConsoleExtensions.ReadDouble("unesi prvi broj"); //ConsoleExtensions je klasa u biblioteci MojaBiblioteka koja sadrzi funkciju ReadDoubl3 koju pozivamo za ucitavanje broja
                            double brojDva = ConsoleExtensions.ReadDouble("unesi drugi broj");

                            double rezultat = brojJedan + brojDva;
                            ConsoleExtensions.ShowMessage($"{brojJedan} + {brojDva} = {rezultat}");
                            break;
                        }
                    case "2":
                        {
                            double brojJedan = ConsoleExtensions.ReadDouble("unesi prvi broj");
                            double brojDva = ConsoleExtensions.ReadDouble("unesi drugi broj");

                            double rezultat = brojJedan - brojDva;
                            ConsoleExtensions.ShowMessage($"{brojJedan} - {brojDva} = {rezultat}");
                            break;
                        }
                    case "3":
                        {
                            double brojJedan = ConsoleExtensions.ReadDouble("unesi prvi broj");
                            double brojDva = ConsoleExtensions.ReadDouble("unesi drugi broj");

                            double rezultat = brojJedan * brojDva;
                            ConsoleExtensions.ShowMessage($"{brojJedan} * {brojDva} = {rezultat}");
                            break;
                        }
                    case "4":
                        {
                            double brojJedan = ConsoleExtensions.ReadDouble("unesi prvi broj");
                            double brojDva = ConsoleExtensions.ReadDouble("unesi drugi broj");

                            double rezultat = brojJedan / brojDva;
                            ConsoleExtensions.ShowMessage($"{brojJedan} / {brojDva} = {rezultat}");
                            break;
                        }
                    case "5":
                        {
                            double brojJedan = ConsoleExtensions.ReadDouble("unesi osnovu");
                            double brojDva = ConsoleExtensions.ReadDouble("unesi eksponent");

                            double rezultat = ConsoleExtensions.Stepenovanje(brojJedan, brojDva);

                            ConsoleExtensions.ShowMessage($"{brojJedan} ^ {brojDva} = {rezultat}");
                            break;
                        }
                    case "6":
                        {
                            double brojJedan = ConsoleExtensions.ReadDouble("unesi broj");
                            double rezultat = Math.Sqrt(brojJedan);
                            ConsoleExtensions.ShowMessage($"Rezultat je: {rezultat}");
                            break;
                        }
                    case "7":
                        {
                            ConvertBinaryToDecimal();
                            break;
                        }
                    case "8":
                        {
                            //uneti datum
                            string dateTime1 = "DD/MM/YYYY";
                            Console.WriteLine($"Unesi datum u formatu {dateTime1}");
                            string datum = Console.ReadLine();                           

                            //deklarisati dan, mesec, godinu kao string
                            string d = "", m = "", g = "";

                            //deklarisati dan, mesec, godinu kao int
                            int dan, mesec, godina;

                            //pronaci pozicije na kojima se nalaze kose crte
                            int index1 = -1, index2 = -1, i = 0;
                            while (index2 == -1 && i < dateTime1.Length)
                            {
                                if (dateTime1[i] == '/')
                                    if (index1 == -1)
                                        index1 = i;
                                    else
                                        index2 = i;
                                i++;
                            }
                            if (dateTime1.Length != datum.Length)
                                ConsoleExtensions.ShowError("Nepravilno unet datum.");

                            //proveriti da li se kose crte nalaze na tacnim pozicijama
                            else if (datum[index1] != '/' || datum[index2] != '/')
                                ConsoleExtensions.ShowError($"Kose crte nisu na tacnim mestima!");
                            else
                            {
                                //pronaci dan, mesec i godinu i upisati ih u odgovarajuci string
                                for (int j = 0; j < index1; j++)
                                    d += datum[j];
                                for (int j = index1 + 1; j < index2; j++)
                                    m += datum[j];
                                for (int j = index2 + 1; j < datum.Length; j++)
                                    g += datum[j];

                                //konvertovati ih u int
                                dan = Convert.ToInt32(d);
                                mesec = Convert.ToInt32(m);
                                godina = Convert.ToInt32(g);

                                //ispitati da li su u opsegu
                                if (dan > 0 && dan < 32 && mesec > 0 && mesec < 13 && godina > 1899 && godina < 2051)
                                    ConsoleExtensions.ShowMessage($"Datum je pravilno upisan, {dan}/{mesec}/{godina}");
                                else if (dan < 1 || dan > 31)
                                    ConsoleExtensions.ShowError($"Nepravilno unet dan, ne postoji {dan} dan/a");
                                else if (mesec < 1 || mesec > 12)
                                    ConsoleExtensions.ShowError($"Nepravilno unet mesec, ne postoji {mesec} mesec/i");
                                else if (godina < 1900 || godina > 2050)
                                    ConsoleExtensions.ShowError($"Nepravilno uneta godina, ne podrzava godinu {godina}");
                            }
                            break;
                        }
                    case "9":
                        {
                            //uneti datum
                            Console.WriteLine("Unesi datum");
                            string datum = Console.ReadLine();

                            //deklarisati dan, mesec, godinu kao string
                            string d = "", m = "", g = "";

                            //deklarisati dan, mesec, godinu kao int
                            int dan, mesec, godina;

                            //naci pozicije na kojima se nalaze kose crte
                            int index1 = -1, index2 = -1, i = 0;
                            while (index2 == -1 && i < datum.Length)
                            {
                                if (datum[i] == '/')
                                    if (index1 == -1)
                                        index1 = i;
                                    else
                                        index2 = i;
                                i++;
                            }

                            //pronaci dan, mesec i godinu i upisati ih u odgovarajuci string
                            for (int j = 0; j < index1; j++)
                                d += datum[j];
                            for (int j = index1 + 1; j < index2; j++)
                                m += datum[j];
                            for (int j = index2 + 1; j < datum.Length; j++)
                                g += datum[j];

                            //konvertovati ih u int
                            dan = Convert.ToInt32(d);
                            mesec = Convert.ToInt32(m);
                            godina = Convert.ToInt32(g);

                            //ispitati da li su u opsegu
                            if (dan > 0 && dan < 32 && mesec > 0 && mesec < 13)
                                ConsoleExtensions.ShowMessage($"Datum je pravilno upisan, {dan}/{mesec}/{godina}");
                            else 
                            if (dan < 1 || dan > 31)
                                ConsoleExtensions.ShowError($"Nepravilno unet dan, ne postoji {dan} dan/a");
                            else if (mesec < 1 || mesec > 12)
                                ConsoleExtensions.ShowError($"Nepravilno unet mesec, ne postoji {mesec} mesec/i");
                            break;
                        }
                    case "10":
                        {
                            Console.WriteLine("uneti decimanli broj");
                            string br = Console.ReadLine();
                            int broj = Convert.ToInt32(br);

                            string bin = "";
                            string bin32 = "";

                            //racunanje binarnog sve dok je broj veci od 0
                            do
                            {
                                if (broj % 2 != 0)
                                    bin += '1';
                                else
                                    bin += '0';
                                broj = broj / 2;
                            }
                            while (broj > 0);

                            //pisanje u obrnutom redosledu
                            for (int i = bin.Length-1; i >= 0; i--)
                            {
                                bin32 += bin[i];
                            }

                            //dodavanje nula do 32 bita
                            DodavanjeNula(bin32);

                            ConsoleExtensions.ShowMessage($"Broj {br} u binarnom obliku iznosi {DodavanjeNula(bin32)}");
                            break;
                        }
                    case "11":
                        {
                            ConvertBinaryToHexadecimal();
                            break;
                        }
                    case "x":
                        {
                            ConsoleExtensions.ShowMessage($"Izabrali ste opciju 'x'za kraj rada");
                            krajRada = true;
                            break;
                        }
                    default:
                        {
                            ConsoleExtensions.ShowError($"Izabrali ste nepostojecu opciju '{izbor}'! Probajte ponovo.");
                            break;
                        }
                }
            }
            while (!krajRada);

            Console.WriteLine("kraj rada ... <ENTER>");

            Console.ReadLine();
        }
        public static void ConvertBinaryToDecimal()
        {
            //uneti binarni broj kao string
            Console.WriteLine("Unesi binarni broj");
            string strbin = Console.ReadLine();


            // dopuni strbin nulama s leva do duzime 32
            string strBin1 = DodavanjeNula(strbin);

            //proveri format unetog broja
            bool validFormat = IsBinary32Format(strBin1);

            if (validFormat)
            {

                //inicijalizuj sumu na nulu
                int rezultat = 0;

                //od pozicije u strintu 31 do 0 za svaki izracunaj vrednost i dodaj u sumu
                //ispisi decimalni broj

                for (int i = strBin1.Length - 1; i >= 0; i--)
                {
                    //inicijalizuj vrednost i dodaj sumu
                    int vrednost = 0;
                    if (strBin1[i] == '1')
                    {
                        vrednost = Stepen(2, strBin1.Length - 1 - i);
                        rezultat = rezultat + vrednost;
                    }
                }
                ConsoleExtensions.ShowMessage($"decimalni broj za uneti binarni '{strBin1}' je '{rezultat}'");
            }
            else
            {
                ConsoleExtensions.ShowError("Uneti binarni broj nije u dobrom formatu ");
            }
        }
        public static void ConvertBinaryToHexadecimal()
        {
            //uneti binarni broj
            string strBinary = LoadBinary();
            if (strBinary == null)
            {
                ConsoleExtensions.ShowError("Nepravilno unet binarni broj");
                return;
            }

            string[] strBinaryGroup = GroupBinaryByBits(strBinary);
            int[] decimalGroup = BinaryGroupToDecimalGroup(strBinaryGroup);
            string result = DecimalGroupToHexadecimal(decimalGroup);

            ConsoleExtensions.ShowMessage($"hexadecimalni broj za uneti binarni '{strBinary}' je '{result}'");

            //dopuni do 32 bita
            //proveri format broja
        }
        public static string LoadBinary()
        {
            Console.WriteLine("Unesi binarni broj");
            string strbin = Console.ReadLine();

            // dopuni strbin nulama s leva do duzime 32
            string strBin1 = DodavanjeNula(strbin);

            //proveri format unetog broja
            bool validFormat = IsBinary32Format(strBin1);

            return ( validFormat ) ? strBin1: null;

            //if(!validFormat)
            //    return null;

            //return strBin1;
        }
        private static string[] GroupBinaryByBits(string binary)
        {
            string temp = "";
            string[] result = new string[8];
            int brojac = 0;

            for (int i = 0; i < 32; i++)
            {
                //temp = $"{temp}{binary[i]}";
                temp = temp + binary[i];
                if (temp.Length == 4) 
                {
                    result[brojac] = temp;
                    temp = string.Empty;
                    brojac++;
                }
            }
            return result;

        }
        private static int[] BinaryGroupToDecimalGroup(string[] strBinaryGroup)
        {
            int[] nizDecimal = new int[strBinaryGroup.Length];
            int rezultat;
            for (int i = strBinaryGroup.Length-1; i >=0; i--)
            {
                int vrednost = 0;
                rezultat = 0;
                for (int j = strBinaryGroup[i].Length-1; j >= 0; j--)
                {
                    //inicijalizuj vrednost i dodaj sumu                   
                    if (strBinaryGroup[i][j] == '1')
                    {
                        vrednost = Stepen(2, strBinaryGroup[j].Length - 1 - j);
                        rezultat = rezultat + vrednost;
                    }
                    nizDecimal[i] = rezultat;
                }
            }
            return nizDecimal;
            //for (int i = 0; i < strBinaryGroup.Length; i++)
            //{
            //    nizDecimal[i] = ConvertBinaryToDecimal(strBinaryGroup[i]);
            //}
            //return nizDecimal;
        }
        private static string DecimalGroupToHexadecimal(int[] decimalGroup)
        {
            string result = string.Empty;

            for (int i = 0; i < decimalGroup.Length; i++)
            {
                result += ConvertDecimalToHoxadecimal(decimalGroup[i]).ToString();
            }

            //foreach  (int decimalGroupItem in decimalGroup)
            //{
            //    result += ConvertDecimalToHoxadecimal(decimalGroup[0]).ToString();
            //}
           
            return $"#{result}";
        }
        private static int ConvertBinaryToDecimal(string strBinary)
        {
            int result = 0;

            for (int i = strBinary.Length - 1; i >= 0; i--)
            {
                result += int.Parse(strBinary[i].ToString()) * Stepen(2, (strBinary.Length-1)-i);
            }            
            return result;
        }
        private static char ConvertDecimalToHoxadecimal(int dec)
        {
            char[] mapping = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            //switch (dec)
            //{
            //    case 1:
            //        return '1';
            //    case 2:
            //        return '2';
            //    case 10:
            //        return 'A';
            //    default:
            //        break;
            //}

            return mapping[dec];
        }
        private static bool IsBinary32Format(string strbin)
        {
            if (strbin.Length != 32)
                return false;
            for (int i = 0; i < strbin.Length; i++)
            {
                if (strbin[i] != '0' && strbin[i] != '1')
                    return false;
            }
            return true;
        }
        private static int Stepen(int osnova, int eksponent)
        {
            int rezultat = 1;
            for (int i = 1; i <= eksponent; i++)
            {
                rezultat *= osnova;
            }
            return rezultat;
        }
        private static string DodavanjeNula(string broj)
        {
            while (broj.Length<32)
            {
                broj = $"0{broj}";
                //broj = "0" + broj;
            }
            return broj;
        }
    }
}

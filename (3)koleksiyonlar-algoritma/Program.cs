// Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

using System;
using System.Collections.Generic;

namespace _3_koleksiyonlar_algoritma // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle yazınız");
            string cumle = Console.ReadLine();

            List<char> sesliHarflerListesi = new List<char>();
            List<char> harfListesi = new List<char>();

            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            foreach (char karakter in cumle)
            {
                if (Char.IsLetter(karakter))
                {
                    harfListesi.Add(karakter);
                }
            }

            foreach (char harf in harfListesi)
            {
                if (Array.Exists(sesliHarfler, element => element == char.ToLower(harf)))
                {
                    sesliHarflerListesi.Add(char.ToLower(harf));
                }
            }

            sesliHarflerListesi.Sort();

            Console.WriteLine("Sesli Harfler:");
            foreach (char sesliHarf in sesliHarflerListesi)
            {
                Console.Write(sesliHarf + " ");
            }
        }
    }
}

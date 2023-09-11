using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş","Balık" };
            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim
            renkler[0] = "Mavi";
            
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerde Dizi Kullanımı
            //Klavyeden girilen n tane sayının ortalamsını hesapkayan program
            Console.Write("Lütfen dizinin eleman sayısını giriniz : ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0} . sayıyı giriniz",i+1);
                sayıDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var sayi in sayıDizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("Ortalamanız = "+toplam/diziUzunlugu);

        }
    }
}
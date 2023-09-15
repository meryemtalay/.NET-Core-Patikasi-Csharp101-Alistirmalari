using System;
using System.Collections;

namespace  koleksiyonlar_algoritma_sorular_
{ 
    internal class Program
    {
      
    static void Main(string[] args)
    {
        // Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

        // Negatif ve numeric olmayan girişleri engelleyin.
        // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
        // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.


        //asal sayılar ve asal olmayan sayılar için arraylistler oluşturuldu.
        ArrayList asalSayilar = new ArrayList();
        ArrayList asalOlmayanlar = new ArrayList();

        //asal ve asal olmayan sayıların ortalamsını bulmak için toplam alındı.
        int toplamAsal = 0;
        int toplamAsalOlmayan = 0;

        //1'den 20e kadar döngüye sokuldu.
        for (int i = 0; i < 20; i++)
        {
            // Negatif ve numeric olmayan girişleri engellemek için try catch kullanıldı.
            

            try
            {
                Console.Write((i + 1) + ". pozitif sayıyı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi <= 0)
                {
                    Console.WriteLine("Pozitif bir sayı girmelisiniz. Tekrar deneyin.");
                    i--;
                    continue;
                }

                if (IsAsal(sayi))
                {
                    asalSayilar.Add(sayi);
                    toplamAsal += sayi;
                }
                else
                {
                    asalOlmayanlar.Add(sayi);
                    toplamAsalOlmayan += sayi;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
                i--;
            }
        }

        // Asal sayıları büyükten küçüğe sırala
        asalSayilar.Sort(new AsalComparer());

        // Asal olmayan sayıları büyükten küçüğe sırala
        asalOlmayanlar.Sort(new AsalComparer());

        // Sonuçları yazdır
        Console.WriteLine("\nAsal Sayılar:");
        foreach (int sayi in asalSayilar)
        {
            Console.WriteLine(sayi);
        }
        Console.WriteLine("\nAsal Olmayan Sayılar:");
        foreach (int sayi in asalOlmayanlar)
        {
            Console.WriteLine(sayi);
        }

        // Ortalamaları hesapla ve yazdır
        double ortalamaAsal = (double)toplamAsal / asalSayilar.Count;
        double ortalamaAsalOlmayan = (double)toplamAsalOlmayan / asalOlmayanlar.Count;

        Console.WriteLine("\nAsal Sayıların Toplamı: " + toplamAsal);
        Console.WriteLine("Asal Sayıların Ortalaması: " + ortalamaAsal);
        Console.WriteLine("\nAsal Olmayan Sayıların Toplamı: " + toplamAsalOlmayan);
        Console.WriteLine("Asal Olmayan Sayıların Ortalaması: " + ortalamaAsalOlmayan);
    }

    static bool IsAsal(int sayi)
    {
        if (sayi < 2) return false;
        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if (sayi % i == 0) return false;
        }
        return true;
    }

    class AsalComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((int)y).CompareTo((int)x);
        }
    }        

    }
}
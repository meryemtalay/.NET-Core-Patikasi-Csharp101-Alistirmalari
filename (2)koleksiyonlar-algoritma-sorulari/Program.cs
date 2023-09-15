// Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
// her iki grubun kendi içerisinde ortalamalarını alan
// ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
// (Array sınıfını kullanarak yazınız.)


using System;

namespace _2_koleksiyonlar_algoritma_sorulari // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] sayi=new int[20];
          
           int[] enBuyukUc = new int[3];
           int[] enKucukUc = new int[3];

           for (int i = 0; i < 20; i++)
           {
            Console.Write((i + 1) +". pozitif sayı giriniz: ");
            sayi[i] = Convert.ToInt32(Console.ReadLine());
           }
              Array.Sort(sayi);
            // sayi dizisinin(kaynak) başlangıç indexinden(0) başlanıp hedef dizisine(enKucukUc) 0.indexinden başlanıp 3 eleman kopyalanır. 
            Array.Copy(sayi, 0, enKucukUc, 0, 3);
            // sayi dizisinin(kaynak) baslangıç indexi(sayi length-3, yani sondan 3.) başlanıp hedef dizisine 0.indexinden 3 elemanın kopyalanması.
            Array.Copy(sayi, sayi.Length - 3, enBuyukUc, 0, 3);

            
            double kucukOrt = (enKucukUc[0]+enKucukUc[1]+enKucukUc[2])/3;
            double buyukOrt = (enBuyukUc[0]+enBuyukUc[1]+enBuyukUc[2])/3;

            // Ortalama toplamlarını hesapla
            double toplamOrtalamalar = kucukOrt + buyukOrt;

            Console.WriteLine("\nEn Küçük 3 Sayılar:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(enKucukUc[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nEn Büyük 3 Sayılar:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(enBuyukUc[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nOrtalama Küçük: " + kucukOrt);
            Console.WriteLine("Ortalama Büyük: " + buyukOrt);
            Console.WriteLine("Ortalama Toplamları: " + toplamOrtalamalar);


        }
    }
}
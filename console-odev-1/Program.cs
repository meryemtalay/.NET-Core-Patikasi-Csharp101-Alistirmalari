using System;

namespace console__dev_1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

        //SORU 1:
        // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
        // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

        //     Console.Write("Pozitif bir sayı giriniz: ");
        //     int n = Convert.ToInt32(Console.ReadLine());

        //     if (n <= 0)
        //     {
        //         Console.WriteLine("Hatalı giriş! Pozitif bir sayı girmelisiniz.");
        //         return;
        //     }

        //     Console.WriteLine($"{n} adet pozitif sayı giriniz:");
        // for (int i = 0; i < n; i++)
        // {
        //     int num = Convert.ToInt32(Console.ReadLine());

        //     if (num <= 0)
        //     {
        //         Console.WriteLine("Hatalı giriş! Pozitif bir sayı girmelisiniz.");
        //         return;
        //     }

        //     if (num % 2 == 0)
        //     {
        //         Console.WriteLine(num);
        //     }
        // }

        //SORU 2:
        // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
        // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

        // Console.WriteLine("");
        // Console.WriteLine("Lütfen Birinci Sayıyı Giriniz");
        //     int n = Int32.Parse(Console.ReadLine());


        // Console.WriteLine("Lütfen İkinci Sayıyı Giriniz (m)");
        //     int m = Int32.Parse(Console.ReadLine());

        // Console.WriteLine($"{n} adet pozitif sayı giriniz:");

       
        // for (int i = 0; i < n; i++)
        // {
        //     int sayi = Convert.ToInt32(Console.ReadLine());

            
        //     if (sayi>0 && (sayi == m || sayi % m == 0) )
        //     {
        //         Console.WriteLine("Girilen sayilardan m sayısına eşit ya da tam bölünenlerin sayısı: "+sayi);
        //     }
        // }


        // SORU 3:
        // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
        // Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

        // Console.Write("Pozitif bir sayı giriniz: ");
        //     int n = Convert.ToInt32(Console.ReadLine());
            
        //     string[] kelimeler = new string[n];

        // Console.WriteLine($"{n} adet kelime giriniz:");

        // for (int i = 0; i < n; i++)
        // {
        //     kelimeler[i] = Console.ReadLine();
        // }

        // Array.Reverse(kelimeler);

        // Console.WriteLine("Girilen kelimeler sondan başa doğru:");

        // foreach (var kelime in kelimeler)
        // {
        //     Console.WriteLine(kelime);
        // }



        // SORU 4:
        // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.    

        Console.WriteLine("Bir cümle giriniz. Bu alıştırma girdiğiniz cümledeki toplam kelime ve harf sayısını hesaplar.");

                string cumle = Console.ReadLine();

        // Kelime sayısını hesaplar.
        string[] kelimeler = cumle.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int kelimeSayisi = kelimeler.Length;

        // Harf sayısını hesaplar.
        int harfSayisi = 0;
        foreach (char karakter in cumle)
        {
            if (char.IsLetter(karakter))
            {
                harfSayisi++;
            }
        }

        Console.WriteLine($"Toplam {kelimeSayisi} kelime ve {harfSayisi} harf bulunmaktadır.");

        }
    }
}
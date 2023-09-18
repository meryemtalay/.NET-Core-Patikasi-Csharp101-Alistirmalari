using System;

namespace telefon_rehberi_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {

            // Rehber nesnesi oluşturuldu.    
            Rehber rehber = new Rehber();

            rehber.BaslangicVerileriniEkle();

            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                Console.WriteLine("(exit) Çıkış");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        rehber.YeniNumaraKaydet();
                        break;
                    case "2":
                        rehber.VarolanNumarayiSil(); 
                        break;
                    case "3":
                        rehber.VarolanNumarayiGuncelle();
                        break;
                    case "4":
                        rehber.RehberiListele();
                        break;
                    case "5":
                        rehber.RehberdeAramaYap();
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçenek. Lütfen tekrar deneyin.");
                        break;
                }

                Console.WriteLine("\nDevam etmek için bir tuşa basınız...");
                //kullanıcıdan tuş girişi alır.
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

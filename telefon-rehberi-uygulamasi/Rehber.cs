using System;
using System.Collections.Generic;
using System.Linq;

namespace telefon_rehberi_uygulamasi
{
    public class Rehber
    {
        private List<Kisi> kisiler = new List<Kisi>();

        public void BaslangicVerileriniEkle()
        {
            kisiler.Add(new Kisi("Başak", "Bal", "555-150-5551"));
            kisiler.Add(new Kisi("Mehmet", "Demirci", "555-150-5556"));
            kisiler.Add(new Kisi("Musab", "Talay", "555-150-5557"));
            kisiler.Add(new Kisi("Aybüke", "Kaya", "555-150-5558"));
            kisiler.Add(new Kisi("Emre", "Düzen", "555-150-5559"));
        }

        public void YeniNumaraKaydet()
        {
            Console.Write("Lütfen isim giriniz: ");
            string isim = Console.ReadLine();

            Console.Write("Lütfen soyisim giriniz: ");
            string soyisim = Console.ReadLine();

            Console.Write("Lütfen telefon numarası giriniz: ");
            string telefon = Console.ReadLine();

            Kisi yeniKisi = new Kisi(isim, soyisim, telefon);
            kisiler.Add(yeniKisi);
            Console.WriteLine("Kişi başarıyla kaydedildi.");
        }

        public void VarolanNumarayiSil()
        {
            Console.Write("Lütfen isim ya da soyisim giriniz: ");
            string aranan = Console.ReadLine();

            Kisi kisi = kisiler.Find(k => k.Isim.Equals(aranan, StringComparison.OrdinalIgnoreCase) || k.Soyisim.Equals(aranan, StringComparison.OrdinalIgnoreCase));

            if (kisi != null)
            {
                kisiler.Remove(kisi);
                Console.WriteLine($"{kisi.Isim} {kisi.Soyisim} başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.");
                Console.WriteLine("(1) Silmeyi sonlandırmak için (2) Yeniden denemek için");
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    return;
                }
                else if (secim == "2")
                {
                    VarolanNumarayiSil(); // Yeniden deneme
                }
                else
                {
                    Console.WriteLine("Geçersiz seçenek. Lütfen tekrar deneyin.");
                }
            }
        }

        public void VarolanNumarayiGuncelle()
        {
            Console.Write("Lütfen isim ya da soyisim giriniz: ");
            string aranan = Console.ReadLine();

            Kisi kisi = kisiler.Find(k => k.Isim.Equals(aranan, StringComparison.OrdinalIgnoreCase) || k.Soyisim.Equals(aranan, StringComparison.OrdinalIgnoreCase));

            if (kisi != null)
            {
                Console.WriteLine($"{kisi.Isim} {kisi.Soyisim} kişisinin yeni bilgilerini giriniz:");

                Console.Write("Lütfen yeni isim giriniz: ");
                string yeniIsim = Console.ReadLine();

                Console.Write("Lütfen yeni soyisim giriniz: ");
                string yeniSoyisim = Console.ReadLine();

                Console.Write("Lütfen yeni telefon numarası giriniz: ");
                string yeniTelefon = Console.ReadLine();

                kisi.Isim = yeniIsim;
                kisi.Soyisim = yeniSoyisim;
                kisi.TelefonNumarasi = yeniTelefon;

                Console.WriteLine($"{kisi.Isim} {kisi.Soyisim} başarıyla güncellendi.");
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.");
                Console.WriteLine("(1) Güncellemeyi sonlandırmak için (2) Yeniden denemek için");

                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    return;
                }
                else if (secim == "2")
                {
                    VarolanNumarayiGuncelle(); // Yeniden deneme
                }
                else
                {
                    Console.WriteLine("Geçersiz seçenek. Lütfen tekrar deneyin.");
                }
            }
        }

        public void RehberiListele()
        {
            if (kisiler.Count > 0)
            {
                Console.WriteLine("Telefon Rehberi");
                kisiler.ForEach(k => Console.WriteLine($"isim: {k.Isim} Soyisim: {k.Soyisim} Telefon Numarası: {k.TelefonNumarasi}"));
            }
            else
            {
                Console.WriteLine("Rehberde hiç kayıtlı kişi yok.");
            }
        }

        public void RehberdeAramaYap()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz:");
            Console.WriteLine("(1) İsim veya soyisime göre arama yapmak için");
            Console.WriteLine("(2) Telefon numarasına göre arama yapmak için");

            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.Write("Aramak istediğiniz ismi veya soyismi giriniz: ");
                string aranan = Console.ReadLine();

                List<Kisi> sonuclar = kisiler.FindAll(k => 
                    k.Isim.Contains(aranan, StringComparison.OrdinalIgnoreCase) || 
                    k.Soyisim.Contains(aranan, StringComparison.OrdinalIgnoreCase)
                );

                if (sonuclar.Count > 0)
                {
                    Console.WriteLine("Arama Sonuçlarınız:");
                    sonuclar.ForEach(k => Console.WriteLine($"isim: {k.Isim} Soyisim: {k.Soyisim} Telefon Numarası: {k.TelefonNumarasi}"));
                }
                else
                {
                    Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.");
                }
            }
            else if (secim == "2")
            {
                Console.Write("Aramak istediğiniz telefon numarasını giriniz: ");
                string aranan = Console.ReadLine();

                List<Kisi> sonuclar = kisiler.FindAll(k => k.TelefonNumarasi.Contains(aranan));

                if (sonuclar.Count > 0)
                {
                    Console.WriteLine("Arama Sonuçlarınız:");
                    sonuclar.ForEach(k => Console.WriteLine($"isim: {k.Isim} Soyisim: {k.Soyisim} Telefon Numarası: {k.TelefonNumarasi}"));
                }
                else
                {
                    Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.");
                }
            }
            else
            {
                Console.WriteLine("Yanlış ya da eksik bir seçenek seçiyorsunuz. Lütfen tekrar deneyin.");
            }
        }
    }    
} 

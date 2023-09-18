namespace telefon_rehberi_uygulamasi
{
    public class Kisi
    {
        //Kişi sınıfı 3 property içerir.
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TelefonNumarasi { get; set; }

        // Kişi sınıfının constructorı
        public Kisi(string isim, string soyisim, string telefonNumarasi)
        {
            Isim = isim;
            Soyisim = soyisim;
            TelefonNumarasi = telefonNumarasi;
        }
    }
}

using System;

namespace class_kavrami // Note: actual namespace depends on the project name.
{
    public class Program
	{
		static void Main(string[] args)
		{
			// Söz dizimi
			// class sinifAdi
			//{
			//[Erişim belirleyici] [Veri tipi] OzellikAdi;
			//[Erişim belirleyici] [Geri dönüş tipi] MetotAdi([Parametre Listesi])
			//{
			//Metot komutları
			//}
			//}

			//Erişim belirleyiciler
			// * Public
			// * Private
			// * Internal
			// * Protected
			Console.WriteLine("*****Çalışan 1******");
			Calisan calisan1 = new Calisan("Meryem","Talay",4561759,"IT");
			calisan1.CalisanBilgileri();

			Console.WriteLine("*****Çalışan 2******");
			Calisan calisan2 = new Calisan();

			calisan1.Ad = "Serpil";
			calisan1.Soyad = "Düzen";
			calisan1.No = 123856;
			calisan1.Departman = "IT";
			calisan1.CalisanBilgileri();

	
		}

		class Calisan
		{
			public string Ad;
			public string Soyad;
			public int No;
			public string Departman;

			public Calisan(string ad, string soyad, int no, string departman) // Constructor 
			{
				this.Ad = ad;
				this.Soyad = soyad;
				this.No = no;	
				this.Departman = departman;	
			}
			public Calisan() { } //Constructor 

			public Calisan(string ad, string soyad) { } // Constructor 
			public void CalisanBilgileri()
			{
				Console.WriteLine("Çalışanın Adı: {0}", Ad);
				Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
				Console.WriteLine("Çalışanın Numarası: {0}", No);
				Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
			}
		}
	}
}










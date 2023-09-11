using System;
using System.Security.Claims;

namespace donguler_for_loop 
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Lütfen bir sayı giriniz");

          int sayac=int.Parse(Console.ReadLine());
          for(int i=1;i<=sayac;i++)
          {
            if(i%2==1){
                Console.WriteLine(i);
            } 
          }

          int tektoplam=0;
          int cifttoplam=0;

          for(int i=0;i<=1000;i++){
            if(i%2==1){
                tektoplam+=i;

            }
            if(i%2==0){
                cifttoplam+=i;
            }

          }
            Console.WriteLine("Çift sayıların toplamı" + cifttoplam);
            Console.WriteLine("Çift sayıların toplamı" + tektoplam);

            // break, continue
			for (int i = 1; i < 10; i++)
			{
				if (i == 4)
					break;
				Console.WriteLine(i);
			}
			for (int i = 1; i < 10; i++)
			{
				if (i == 4)
					continue;
				Console.WriteLine(i);
			}

        }
    }
}
using System;
using System.Collections;

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
                      her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını 
                      console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
            */

            /*Değişkenlerin Tanımlanması*/
            ArrayList numbers = new ArrayList();
            int sayi = 0;
            int b1 = 0;
            int b2 = 0;
            int b3 = 0;
            int k1 = 0;
            int k2 = 0;
            int k3 = 0;
            int bOrtalama = 0;
            int kOrtalama = 0;
            int toplam = 0;
            int turningPoint = 0;

            Console.WriteLine("20 adet Toplamda Sayı Girmeniz Beklenmektedir"); 

            /*Kullanıcıdan Sayıların Alınması ve Array'a Eklenmesi*/
            while (turningPoint < 20)
            {
                Console.WriteLine("Lütfen {0}. Sayıyı Giriniz",turningPoint+1);
                bool sonuc = Int32.TryParse(Console.ReadLine(), out sayi);
                if (sonuc)
                {
                    numbers.Add(sayi);
                }
                else
                {
                    System.Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz");
                }
                turningPoint ++;
            }

            /*En Büyük 3 Sayı Bulma İşlemleri*/
            int[] myArray = (int[])numbers.ToArray(typeof(int));
  
            foreach (var item in myArray)
            {
                if (item>b1)
                {
                    b2 = b1;
                    b1 = item;
                }
            }

            foreach (var item in myArray)
            {
                if (b2>item && item>b3 )
                {
                    b3 = item;
                }
            }

            /*En Küçük 3 Sayıyı Bulma İşlemleri*/
            Array.Sort(myArray);
            Array.Reverse(myArray);
            k3 = b1;
            k2 = b1;
            k1 = b1;
            foreach (var item in myArray)
            {
                if (item<k3)
                {
                    k2 = k3;
                    k3 = item;
                }
            }

            foreach (var item in myArray)
            {
                if (k2<k1 && item>k2)
                {
                    k1 = item;
                }
            }

            /*Ortalama ve Toplamın Hesaplanması*/
            bOrtalama = (b1+b2+b3)/3;
            kOrtalama = (k1+k2+k3)/3;
            toplam = bOrtalama + kOrtalama;

            /*Ekran Çıktılarının Yazdırılması*/
            System.Console.WriteLine($"En Büyük 1.Sayı : {b1}, 2.Sayı : {b2}, 3.Sayı : {b3}");
            System.Console.WriteLine($"En küçük 1.Sayı : {k3}, 2.Sayı : {k2}, 3.Sayı : {k1}");
            System.Console.WriteLine($"Büyük Sayıların Ortalaması : {bOrtalama}");
            System.Console.WriteLine($"Küçük Sayıların Ortalaması : {kOrtalama}");
            System.Console.WriteLine($"Ortalamarın Toplamı : {toplam}");
        }
    }
}

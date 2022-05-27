using System;
using System.Collections;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
            (ArrayList sınıfını kullanara yazınız.)
            Negatif ve numeric olmayan girişleri engelleyin.
            Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            */

            //Değişkenlerin tanımlanması
            ArrayList asal = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();

            int turningPoint = 0;
            int asalToplam = 0;
            int asalOrtalama = 0;
            int asalOlmayanToplam = 0;
            int asalOlmayanOrtalama = 0;

            Console.WriteLine("20 adet Toplamda Asal ve Asal Olmayan Sayı Girmeniz Beklenmektedir");

            //Sayıların Kullanıcıdan Alınması Kontrolü ve Listelere Eklenmesi
            while(turningPoint < 20)
            {            
                int Sayi;
                Console.WriteLine("Lütfen {0}. Sayıyı Giriniz",turningPoint+1);
                bool Sonuc = int.TryParse(Console.ReadLine(), out Sayi);

                if (Sonuc && Sayi>0)
                {
                    if(Sayi%2==0 || Sayi%5==0)
                    {
                        asalOlmayan.Add(Sayi);
                        turningPoint++;
                    }
                    else
                    {
                        asal.Add(Sayi);
                        turningPoint ++;
                    }
                }

                else
                {
                    //Dönüşüm mümkün değilse burası tetiklenecektir.
                    Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz");
                }
                
            }

            System.Console.WriteLine("*****************************************************************");
            /*Asal Sayı İşlemlerinin Yapılması ve Ekrana Yazdırılma İşlemleri*/
            asal.Sort();
            asal.Reverse();

            foreach(var item in asal)
            {
                System.Console.WriteLine(item);
            }
            
            var asalCount = asal.Count;
            System.Console.WriteLine("Asal Olan Eleman Sayısı : " + asalCount);

            foreach(int i in asal)
            {
                asalToplam = asalToplam + i;
            }

            asalOrtalama = asalToplam / asalCount;
            System.Console.WriteLine("Asal Sayıların Ortalaması : " + asalOrtalama);

            System.Console.WriteLine("*****************************************************************");
            /*Asal Olmayan Sayı İşlemlerinin Yapılması ve Ekrana Yazdırılma İşlemleri*/
            asalOlmayan.Sort();
            asalOlmayan.Reverse();

            foreach(var item in asalOlmayan)
            {
                System.Console.WriteLine(item);
            }

            var asalOlmayanCount = asalOlmayan.Count;
            System.Console.WriteLine("Asal Olan Eleman Sayısı : " + asalOlmayanCount);
            
            foreach(int i in asalOlmayan)
            {
                asalOlmayanToplam = asalOlmayanToplam + i;
            }

            asalOlmayanOrtalama = asalOlmayanToplam / asalOlmayanCount;
            System.Console.WriteLine("Asal Sayıların Ortalaması : " + asalOlmayanOrtalama);
        }
    }
}

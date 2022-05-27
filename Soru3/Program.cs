using System;
using System.Text.RegularExpressions;

namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan 
                ve dizinin elemanlarını sıralayan programı yazınız.*/

            System.Console.WriteLine("Lütfen Bir Metin Giriniz");
            string str = Console.ReadLine();
            str = str.ToLower().Trim();
            Regex rgx = new Regex(@"[aeıiuüoö]");
            var result = rgx.Matches(str);
            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}

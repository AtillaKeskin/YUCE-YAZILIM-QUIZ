using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2liktaban
{
    class Program
    {
        static void Main(string[] args)
        {
            Hesapla();
        }
       
        static void Hesapla()
        {
           
            double sonuc = 0;
           
            Console.Write("2lik tabandaki sayıyı giriniz.");
            string sayi1;
            sayi1 = (Console.ReadLine());
            var chars = sayi1.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                double ussu = ((chars.Length - 1) - i);
                int number = (int)Char.GetNumericValue(chars[i]);
                sonuc = sonuc + ( Convert.ToDouble(number)* Math.Pow(2,ussu));
            }
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}

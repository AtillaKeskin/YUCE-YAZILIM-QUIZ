using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

      

        static void Main(string[] args)
        {
            Hesapla();
            
        }

        static void Hesapla()
        {

             int[] array1 = { 1, 3, 2, 7, 11, 14, 20 };
             int[] array2 = { 5, 6, 7, 8, 15, 16, 22 };
             int[] result = new int[2];
            int firstNumber = 1;
            int secondNumber = 1;
            
            for (int i=0; i < array1.Length; i++)
            {
                firstNumber = firstNumber * array1[i];//birinci arraydeki elemanların çarpımı
            }

            for (int i = 0; i < array2.Length; i++)
            {
                secondNumber = secondNumber * array2[i];//ikinci arraydeki elemanların çarpımı
            }

            Console.WriteLine("1 :" + firstNumber);
            Console.WriteLine("2 :"+ secondNumber);

            result[0] = firstNumber % 5;//çarpılmıs 1.arrayde ki sayının sonucunun mod 5 i
            result[1] = secondNumber % 5; //çarpılmıs 2. arraydeki sayının sonucunun mod 5 i

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Sonuc["+i+"] :" + result[i]);
            }

            Console.ReadLine();
        } 
    }
}

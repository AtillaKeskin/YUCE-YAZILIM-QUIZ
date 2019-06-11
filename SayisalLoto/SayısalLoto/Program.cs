using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayısalLoto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] Random = new int[6];
            int[] Guess = new int[6];


            Random rand = new Random();
            for (int i = 0; i < Random.Length; i++)
            {
                Random[i] = rand.Next(1, 50);
            }
            Array.Sort(Random);

            for (int i = 0; i < Guess.Length; i++)
            {
                Console.Write((i + 1) + ". Sayı giriniz: ");
                Guess[i] = int.Parse(Console.ReadLine());
            }
           
            int DogruTahmin = 0;

           
            Console.WriteLine("Çekilen Sayısal Loto Sonuçları.");
            for (int i = 0; i < Random.Length; i++)
            {
                Console.WriteLine(Random[i]);
                for (int j = 0; j < Guess.Length; j++)
                {
                    if (Random[i] == Guess[j])
                        DogruTahmin++;
                }
            }
           
            Console.WriteLine("Doğru Tahmin: " + DogruTahmin);
            Console.ReadLine();
        }
    }
}

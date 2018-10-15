using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[50];
            array[0] = 1;
            Random rnd = new Random();
            while (Console.ReadLine() != "exit")
            {
                Console.Clear();
                for (int i = 1; i < array.Length; i++)
                    array[i] = rnd.Next(array[i - 1], array[i - 1] + 8);

                for (int i = 0; i < array.Length; i++)
                    Console.Write(array[i] + " ");

                Console.WriteLine("min=" + calc(array));
            }
            
            Console.ReadKey();
        }
        static int calc(int[] S)
        {
            int sumElements = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] <= sumElements + 1)
                    sumElements += S[i];
                else
                {
                    Console.WriteLine("\n" + i);
                    return sumElements + 1;
                }
            }
            Console.WriteLine("\n100");
            return sumElements + 1;
        }
    }
}

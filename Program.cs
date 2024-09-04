using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberArray2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] randomNumbers = new int[100];
            Random random = new Random();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(100, 901);
            }

            int min = randomNumbers.Min();
            int secondMin = randomNumbers.Where(x => x > min).Min();

            Console.WriteLine("Масив випадкових чисел:");
            Console.WriteLine(string.Join(", ", randomNumbers));
            
            Console.WriteLine($"Друге найменше число: {secondMin}");
        }
    }
}

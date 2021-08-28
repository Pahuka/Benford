using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benford
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(GetBenfordStatistics("1"));
            PrintNumbers(GetBenfordStatistics("abc"));
            PrintNumbers(GetBenfordStatistics("123 456 789"));
            PrintNumbers(GetBenfordStatistics("abc 123 def 456 gf 789 i"));
        }

        public static void PrintNumbers(int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        public static int[] GetBenfordStatistics(string text)
        {
            var statistics = new int[10];
            var numbers = text.Split(' ')
                .Where(x => char.IsNumber(x[0]))
                .Select(x => int.Parse(x.FirstOrDefault().ToString()))
                .ToList();

            foreach (var item in numbers)
            {
                statistics[item]++;
            }

            return statistics;
        }
    }
}

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
            int T = int.Parse(Console.ReadLine());
            for(int t = 0; t < T; t++)
            {
                string line = Console.ReadLine();
                string[] space = line.Split(' ');
                decimal num1 = decimal.Parse(space[0]);
                decimal num2 = decimal.Parse(space[1]);
                decimal result = (num1 + num2) / 2;
                Console.WriteLine($"{Math.Floor(result)}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTTERY
{
    class Program
    {
        static void Main(string[] args)
        {
            // 宣告一個亂數並給予範圍
            Random rand = new Random();
            Console.WriteLine(rand.Next(0, 100));

            Console.ReadLine();
        }
    }
}

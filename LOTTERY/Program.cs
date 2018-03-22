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
            // 產生一個亂數
            Random rand = new Random();

            // 紀錄產生次數
            int count = 1;

            while (count <= 10)
            {
                int r1 = rand.Next(1, 43);
                int r2 = rand.Next(1, 43);
                int r3 = rand.Next(1, 43);
                int r4 = rand.Next(1, 43);
                int r5 = rand.Next(1, 43);
                int r6 = rand.Next(1, 43);

                // 顯示
                Console.WriteLine("你的號碼為:");
                Console.WriteLine("{0:00} {1:00} {2:00} {3:00} {4:00} {5:00} ", r1, r2, r3, r4, r5, r6);

                // 累加次數
                count += 1;
            }

            // 防止視窗自動關閉
            Console.ReadLine();
        }
    }
}

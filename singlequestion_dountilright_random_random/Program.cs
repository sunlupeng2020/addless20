using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//20以内的加法之一道题，
//一道题，题目中的两个加数随机产生，用户回答后给予反馈，直到答对为止
namespace singlequestion_dountilright_random
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;
            Random r = new Random();
            a = r.Next(1, 10);
            b = r.Next(1, 10);
            do
            {
                Console.WriteLine(a + "+" + b + "=?");
                sum = int.Parse(Console.ReadLine());
                if (sum != a + b)
                {
                    Console.WriteLine("请再想一想！");
                }
            } while (sum != a + b);
            Console.WriteLine("答对了！你真棒！");
            Console.ReadKey();

        }
    }
}

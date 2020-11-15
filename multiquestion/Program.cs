using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//20以内的加法之多道题，测验完给成绩
//题目中的两个加数随机产生
//两个加数的范围是从0到20，和大于10，不超过20
namespace singlequestion_dountilright_random
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum, achievement = 0;
            int questionNum = 5;
            Random r = new Random();
            for (int i = 0; i < questionNum; i++)
            {
                do
                {
                    a = r.Next(0, 20);
                    b = r.Next(0, 20);
                } while (a + b > 20 || a + b <= 10);
                Console.WriteLine(a + "+" + b + "=?");
                sum = int.Parse(Console.ReadLine());
                if (sum == a + b)
                {
                    achievement += 20;
                }

            }
            Console.WriteLine("您的成绩是：{0}分。", achievement);
            Console.ReadKey();
        }
    }
}

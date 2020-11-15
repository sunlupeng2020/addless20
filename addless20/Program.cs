using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//20以内的加法之一道题，
//一道题，题目中的两个加数固定（写在程序里），用户回答后给予反馈,只有一次回答机会

namespace addless20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;
            a = 7;
            b = 12;
            Console.WriteLine(a + "+" + b + "=?");
            sum = int.Parse(Console.ReadLine());
            if (sum == a + b)
            {
                Console.WriteLine("答对了！你真棒！");
            }
            else
            {
                Console.WriteLine("请再想一想！");
            }
            Console.ReadKey();
        }
    }
}

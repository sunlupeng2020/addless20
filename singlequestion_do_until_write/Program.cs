using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//20以内的加法之一道题，
//一道题，题目中的两个加数固定（写在程序里），用户回答后给予反馈，直到答对为止
namespace singlequestion_do_until_write
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;
            a = 7;
            b = 12;
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

            //A a1 = new A();
            //Console.WriteLine(a1.add001(1, 2+3));

            Console.ReadKey();

        }
    }
    //class A
    //{
    //    protected int add(int a, int b)
    //    {
    //        return a + b;
    //    }
    //    protected internal int add001(int a, int b)
    //    {
    //        return a + b;
    //    }
    //}

}

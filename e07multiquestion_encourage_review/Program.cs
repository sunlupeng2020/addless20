﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//20以内的加法之多道题，测验完给成绩
//题目中的两个加数随机产生
//两个加数的范围是从0到20，和大于10，不超过20
//根据测试成绩，按照不同等级，给出不同的鼓励。
//100-优秀，80-良好,60-中等，60以下-不及格
//最后显示本次题目的记录
namespace singlequestion_dountilright_random
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum, achievement = 0;
            int questionNum = 5;
            Random r = new Random();
            StringBuilder sb = new StringBuilder();
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
                    sb.Append(string.Format("{0}.{1}+{2}=? 正确答案是:{3},你的回答是：{4},回答正确！本题得分20分。\n", i + 1, a, b, a + b, sum));
                }
                else
                {
                    sb.Append(string.Format("{0}.{1}+{2}=? 正确答案是:{3},你的回答是：{4},回答错误。本题得分0分。\n", i + 1, a, b, a + b, sum));
                }
            }
            Console.WriteLine("您的成绩是：{0}分。", achievement);
            switch (achievement)
            {
                case 100:
                    Console.WriteLine("哇哦~~~ 你太棒了！你是我们的骄傲！继续努力！");
                    break;
                case 80:
                    Console.WriteLine("你真棒！继续努力！");
                    break;
                case 60:
                    Console.WriteLine("不错哦！继续努力！");
                    break;
                default:
                    Console.WriteLine("你有很大的进步空间！继续努力！");
                    break;
            }
            Console.Write(sb.ToString());
            Console.ReadKey();
        }
    }
}

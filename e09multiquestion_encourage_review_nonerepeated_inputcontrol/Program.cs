using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//20以内的加法之多道题，测验完给成绩
//题目中的两个加数随机产生
//两个加数的范围是从0到20，和大于10，不超过20
//根据测试成绩，按照不同等级，给出不同的鼓励。
//100-优秀，80-良好,60-中等，60以下-不及格
//最后显示本次题目的记录
//防止题目重复
namespace singlequestion_dountilright_random
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;//两个加数，和
            int achievement = 0;//成绩
            int questionNum = 5;//题目数量
            bool rightInput = false;//是否正确输入
            Random r = new Random();
            StringBuilder sb = new StringBuilder();//用于保存题目
            string question;//用于生成题目字符串
            for (int i = 0; i < questionNum; i++)
            {
                do
                {
                    a = r.Next(0, 20);
                    b = r.Next(0, 20);
                    question = string.Format("{0}+{1}=", a, b);
                } while (a + b > 20 || a + b <= 10 || sb.ToString().Contains(question));//和<=20,和>10,题目没有出现过
                sum = -1;
                rightInput = true;
                do//检测用户输入的是否整数，能否转换为整数
                {
                    Console.WriteLine(a + "+" + b + "=?");//显示题目
                    try
                    {
                        sum = int.Parse(Console.ReadLine());//输入答案
                        rightInput = true;
                    }
                    catch
                    {
                        rightInput = false;
                    }
                }while (!rightInput);//如果输入的内容不能转换为整数，则重新显示题目，用户需再次输入。
                if (sum == a + b)
                {
                    achievement += 20;//计算成绩
                    //生成复习信息
                    sb.Append(string.Format("{0}.{1}+{2}=? 正确答案是:{3},你的回答是：{4},回答正确！本题得分20分。\n", i + 1, a, b, a + b, sum));
                }
                else
                {
                    sb.Append(string.Format("{0}.{1}+{2}=? 正确答案是:{3},你的回答是：{4},回答错误。本题得分0分。\n", i + 1, a, b, a + b, sum));
                }
            }
            Console.WriteLine("您的成绩是：{0}分。", achievement);
            switch (achievement)//根据不同成绩显示不同的鼓励。
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
            Console.Write(sb.ToString());//显示题目记录
            Console.ReadKey();
        }
    }
}
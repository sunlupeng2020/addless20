using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary_Addless20;

namespace Addless20useClasslibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionAddLess20 ques = new QuestionAddLess20();
            Console.WriteLine(ques.ToString());
            Console.ReadKey();

        }
    }
}

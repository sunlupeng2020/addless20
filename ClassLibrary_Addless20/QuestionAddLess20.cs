using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary_Addless20
{
   public class QuestionAddLess20
    {
        private int num1;
        public int Num1
        {
            get { return num1; }
        }
        private int num2;
        public int Num2
        {
            get { return num2; }
        }
        public QuestionAddLess20()
        {
            Random r = new Random();
            do
            {
                this.num1 = r.Next(0, 20);
                this.num2 = r.Next(0, 20);
            } while (num1 + num2 > 20);
        }
        public override bool Equals(object obj)
        {
            QuestionAddLess20 t = (QuestionAddLess20)obj;
            return (this.Num1 == t.Num1) && (this.Num2 == t.Num2);
            //return base.Equals(obj);
        }
        public new string ToString()
        {
            return num1.ToString()+"+"+num2.ToString()+"=";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

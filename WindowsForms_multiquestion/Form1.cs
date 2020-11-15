using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_multiquestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int a, b, sum=0;
        int questionNo = 1;
        int score = 0;
        StringBuilder questionSb = new StringBuilder();
        private void Form1_Load(object sender, EventArgs e)
        {
            //生成题目,题目的两个数属于[0,20],和不大于20.
            GetQuestion(out a, out b, out sum);
            Lb_question.Text = string.Format("{0}+{1}=?", a, b);
            //显示题号
            lb_questionNo.Text = questionNo.ToString();
        }

        private void btn_nextquestion_Click(object sender, EventArgs e)
        {
            bool rightInput = true;
            int answer=0;
            try
            {
                answer = int.Parse(Tb_answer.Text.Trim());
            }
            catch
            {
                rightInput = false;
            }
            questionSb.AppendFormat("{0}.{1}+{2}=? 答案是：{3},你的回答是：{4}，", questionNo, a, b, sum, answer);
            if (rightInput && answer == sum)
            {
                //MessageBox.Show("答对了！你太棒了！");
                score += 20;
                questionSb.Append("回答正确！本题得分：20分。\n");
            }
            else
            {
                questionSb.Append("回答错误！本题得分：0分。\n");
            }
            questionNo++;
            if (questionNo > 5)
            {
                MessageBox.Show(questionSb.ToString() + "你的成绩是：" + score.ToString() + "分。\n"+GetEncourageString(score));
                btn_nextquestion.Enabled = false;
            }
            else
            {
                GetQuestion(out a, out b, out sum);
                lb_questionNo.Text = questionNo.ToString();
                Lb_question.Text = string.Format("{0}+{1}=?", a, b);
                Tb_answer.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("正确答案是："+sum.ToString()+"。");
        }
        /// <summary>
        /// 生成两个和在[10,20]区间内的整数
        /// </summary>
        /// <param name="number1">第一个加数</param>
        /// <param name="number2">第二个加数</param>
        /// <param name="sum">两个数的和</param>
        private void GetQuestion(out int number1, out int number2, out int sum)
        {
            Random r = new Random();
            do
            {
                number1 = r.Next(0, 20);
                number2 = r.Next(0, 20);
                sum = number1 + number2;
            } while (sum < 10 || sum > 20);
        }
        private string GetEncourageString(int scroe)
        {
            switch (scroe)
            {
                case 100:
                    return "哇~~~ 你太棒了！你是我们的骄傲！继续努力！";
                case 80:
                    return "你真棒！继续努力！";
                case 60:
                    return "不错哦！继续努力！";
                default:
                    return "你有很大的进步空间！继续努力！";
            }
        }
    }
}

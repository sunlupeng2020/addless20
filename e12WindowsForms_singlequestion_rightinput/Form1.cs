using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace e12WindowsForms_singlequestion_rightinput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        public int a, b, sum = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            //生成题目,题目的两个数属于[0,20],和不大于20.
            do
            {
                a = r.Next(0, 20);
                b = r.Next(0, 20);
                sum = a + b;
            } while (sum < 10 || sum > 20);
            Lb_question.Text = string.Format("{0}+{1}=?", a, b);
        }

        private void btn_nextquestion_Click(object sender, EventArgs e)
        {
            bool rightInput = true;
            int answer = 0;
            try
            {
                answer = int.Parse(Tb_answer.Text.Trim());
            }
            catch
            {
                rightInput = false;
            }
            if (rightInput)
            {
                if (answer == sum)
                {
                    MessageBox.Show("答对了！你太棒了！");
                }
                else
                {
                    MessageBox.Show("请再想一想！");
                }
            }
            else
            {
                MessageBox.Show("请输入一个整数！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("正确答案是：" + sum.ToString() + "。");
        }
    }
}

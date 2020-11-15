namespace WindowsForms_multiquestion
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_question = new System.Windows.Forms.Label();
            this.Tb_answer = new System.Windows.Forms.TextBox();
            this.btn_nextquestion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_questionNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "题目：";
            // 
            // Lb_question
            // 
            this.Lb_question.AutoSize = true;
            this.Lb_question.Location = new System.Drawing.Point(95, 51);
            this.Lb_question.Name = "Lb_question";
            this.Lb_question.Size = new System.Drawing.Size(41, 12);
            this.Lb_question.TabIndex = 2;
            this.Lb_question.Text = "label2";
            // 
            // Tb_answer
            // 
            this.Tb_answer.Location = new System.Drawing.Point(107, 117);
            this.Tb_answer.Name = "Tb_answer";
            this.Tb_answer.Size = new System.Drawing.Size(100, 21);
            this.Tb_answer.TabIndex = 3;
            // 
            // btn_nextquestion
            // 
            this.btn_nextquestion.Location = new System.Drawing.Point(107, 191);
            this.btn_nextquestion.Name = "btn_nextquestion";
            this.btn_nextquestion.Size = new System.Drawing.Size(75, 23);
            this.btn_nextquestion.TabIndex = 4;
            this.btn_nextquestion.Text = "下一题";
            this.btn_nextquestion.UseVisualStyleBackColor = true;
            this.btn_nextquestion.Click += new System.EventHandler(this.btn_nextquestion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "请输入答案：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "题号：";
            // 
            // lb_questionNo
            // 
            this.lb_questionNo.AutoSize = true;
            this.lb_questionNo.Location = new System.Drawing.Point(74, 13);
            this.lb_questionNo.Name = "lb_questionNo";
            this.lb_questionNo.Size = new System.Drawing.Size(41, 12);
            this.lb_questionNo.TabIndex = 8;
            this.lb_questionNo.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lb_questionNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_nextquestion);
            this.Controls.Add(this.Tb_answer);
            this.Controls.Add(this.Lb_question);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "20以内加法练习";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_question;
        private System.Windows.Forms.TextBox Tb_answer;
        private System.Windows.Forms.Button btn_nextquestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_questionNo;
    }
}


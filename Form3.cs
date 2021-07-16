using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 中考查分小助手
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int sum = 0,now=0;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
            now = now * 10 + e.KeyChar - '0';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sum = 0;
            label2.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "") now = 0;
            sum -= now;
            label2.Text = sum.ToString();
            now = 0;
            textBox2.Text = "";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
            now = now * 10 + e.KeyChar - '0';
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                panel1.Visible = true;
                int num=1;
                num = sum * 100 / 750;
                label4.Text = num.ToString();

                int ans1, ans2, ans3, ans4, ans5, ans6;
                if (num >= 97)
                {
                    ans1 = 99; ans2 = 99; ans3 = 99; ans4 = 99; ans5 = 99;
                }
                else if (num >= 96)
                {
                    ans1 = 90; ans2 = 99; ans3 = 99; ans4 = 99; ans5 = 99;
                }
                else if (num >= 95)
                {
                    ans1 = 60; ans2 = 90; ans3 = 99; ans4 = 99; ans5 = 99;
                }
                else if (num >= 94)
                {
                    ans1 = 20; ans2 = 70; ans3 = 99; ans4 = 99; ans5 = 99;
                }
                else if (num >= 93)
                {
                    ans1 = 10; ans2 = 40; ans3 = 99; ans4 = 99; ans5 = 99;
                }
                else if (num >= 92)
                {
                    ans1 = 1; ans2 = 10; ans3 = 80; ans4 = 99; ans5 = 99;
                }
                else if (num >= 91)
                {
                    ans1 = 1; ans2 = 1; ans3 = 30; ans4 = 99; ans5 = 99;
                }
                else if (num >= 90)
                {
                    ans1 = 1; ans2 = 1; ans3 = 10; ans4 = 99; ans5 = 99;
                }
                else if (num >= 87)
                {
                    ans1 = 1; ans2 = 1; ans3 = 1; ans4 = 80; ans5 = 99;
                }
                else if (num >= 85)
                {
                    ans1 = 1; ans2 = 1; ans3 = 1; ans4 = 50; ans5 = 99;
                }
                else if (num >= 84)
                {
                    ans1 = 1; ans2 = 1; ans3 = 1; ans4 = 30; ans5 = 99;
                }
                else if (num >= 83)
                {
                    ans1 = 1; ans2 = 1; ans3 = 1; ans4 = 10; ans5 = 99;
                }
                else if (num >= 74)
                {
                    ans1 = 1; ans2 = 1; ans3 = 1; ans4 = 1; ans5 = 80;
                }
                else if (num >= 71)
                {
                    ans1 = 1; ans2 = 1; ans3 = 1; ans4 = 1; ans5 = 50;
                }
                else if (num >= 70)
                {
                    ans1 = 1; ans2 = 1; ans3 = 1; ans4 = 1; ans5 = 20;
                }
                else
                {
                    ans1 = 1; ans2 = 1; ans3 = 1; ans4 = 1; ans5 = 1;
                }
                if (ans1 > 60) label11.ForeColor = Color.Green;
                if (ans2 > 60) label12.ForeColor = Color.Green;
                if (ans3 > 60) label13.ForeColor = Color.Green;
                if (ans4 > 60) label14.ForeColor = Color.Green;
                if (ans5 > 60) label16.ForeColor = Color.Green;
                if (ans1 <= 60&&ans1>=20) label11.ForeColor = Color.Orange;
                if (ans2 <= 60&&ans2>=20) label12.ForeColor = Color.Orange;
                if (ans3 <= 60&&ans3>=20) label13.ForeColor = Color.Orange;
                if (ans4 <= 60&&ans4>=20) label14.ForeColor = Color.Orange;
                if (ans5 <= 60&&ans5>=20) label16.ForeColor = Color.Orange;
                if (ans1 <= 20 && ans1 >= 10) label11.ForeColor = Color.Red;
                if (ans2 <= 20 && ans2 >= 10) label12.ForeColor = Color.Red;
                if (ans3 <= 20 && ans3 >= 10) label13.ForeColor = Color.Red;
                if (ans4 <= 20 && ans4 >= 10) label14.ForeColor = Color.Red;
                if (ans5 <= 20 && ans5 >= 10) label16.ForeColor = Color.Red;
                label11.Text = ans1.ToString();
                label12.Text = ans2.ToString();
                label13.Text = ans3.ToString();
                label14.Text = ans4.ToString();
                label16.Text = ans5.ToString();
                if (num >= 100)
                {
                    label11.Text = "你的分数太高啦，这边建议去工地哦！";
                    label12.Text = "你的分数太高啦，这边建议去工地哦！";
                    label13.Text = "你的分数太高啦，这边建议去工地哦！";
                    label14.Text = "你的分数太高啦，这边建议去工地哦！";
                    label16.Text = "你的分数太高啦，这边建议去工地哦！";
                }
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            int num = 1;
            num = sum * 100 / 750;
            label4.Text = num.ToString();

            int ans1, ans2, ans3, ans4, ans5, ans6;
            if (num >= 97)
            {
                ans1 = 99; ans2 = 99; ans3 = 99; ans4 = 99; ans5 = 99;
            }
            else if (num >= 96)
            {
                ans1 = 90; ans2 = 99; ans3 = 99; ans4 = 99; ans5 = 99;
            }
            else if (num >= 95)
            {
                ans1 = 60; ans2 = 90; ans3 = 99; ans4 = 99; ans5 = 99;
            }
            else if (num >= 94)
            {
                ans1 = 20; ans2 = 70; ans3 = 99; ans4 = 99; ans5 = 99;
            }
            else if (num >= 93)
            {
                ans1 = 10; ans2 = 40; ans3 = 99; ans4 = 99; ans5 = 99;
            }
            else if (num >= 92)
            {
                ans1 = 1; ans2 = 10; ans3 = 80; ans4 = 99; ans5 = 99;
            }
            else if (num >= 91)
            {
                ans1 = 1; ans2 = 1; ans3 = 30; ans4 = 99; ans5 = 99;
            }
            else if (num >= 90)
            {
                ans1 = 1; ans2 = 1; ans3 = 10; ans4 = 99; ans5 = 99;
            }
            else if (num >= 87)
            {
                ans1 = 1; ans2 = 1; ans3 = 1; ans4 = 80; ans5 = 99;
            }
            else if (num >= 85)
            {
                ans1 = 1; ans2 = 1; ans3 = 1; ans4 = 50; ans5 = 99;
            }
            else if (num >= 84)
            {
                ans1 = 1; ans2 = 1; ans3 = 1; ans4 = 30; ans5 = 99;
            }
            else if (num >= 83)
            {
                ans1 = 1; ans2 = 1; ans3 = 1; ans4 = 10; ans5 = 99;
            }
            else if (num >= 74)
            {
                ans1 = 1; ans2 = 1; ans3 = 1; ans4 = 1; ans5 = 80;
            }
            else if (num >= 71)
            {
                ans1 = 1; ans2 = 1; ans3 = 1; ans4 = 1; ans5 = 50;
            }
            else if (num >= 70)
            {
                ans1 = 1; ans2 = 1; ans3 = 1; ans4 = 1; ans5 = 20;
            }
            else
            {
                ans1 = 1; ans2 = 1; ans3 = 1; ans4 = 1; ans5 = 1;
            }
            if (ans1 > 60) label11.ForeColor = Color.Green;
            if (ans2 > 60) label12.ForeColor = Color.Green;
            if (ans3 > 60) label13.ForeColor = Color.Green;
            if (ans4 > 60) label14.ForeColor = Color.Green;
            if (ans5 > 60) label16.ForeColor = Color.Green;
            if (ans1 <= 60 && ans1 >= 20) label11.ForeColor = Color.Orange;
            if (ans2 <= 60 && ans2 >= 20) label12.ForeColor = Color.Orange;
            if (ans3 <= 60 && ans3 >= 20) label13.ForeColor = Color.Orange;
            if (ans4 <= 60 && ans4 >= 20) label14.ForeColor = Color.Orange;
            if (ans5 <= 60 && ans5 >= 20) label16.ForeColor = Color.Orange;
            if (ans1 <= 20 && ans1 >= 10) label11.ForeColor = Color.Red;
            if (ans2 <= 20 && ans2 >= 10) label12.ForeColor = Color.Red;
            if (ans3 <= 20 && ans3 >= 10) label13.ForeColor = Color.Red;
            if (ans4 <= 20 && ans4 >= 10) label14.ForeColor = Color.Red;
            if (ans5 <= 20 && ans5 >= 10) label16.ForeColor = Color.Red;
            label11.Text = ans1.ToString();
            label12.Text = ans2.ToString();
            label13.Text = ans3.ToString();
            label14.Text = ans4.ToString();
            label16.Text = ans5.ToString();
            if (num >= 100)
            {
                label11.Text = "你的分数太高啦，这边建议去工地哦！";
                label12.Text = "你的分数太高啦，这边建议去工地哦！";
                label13.Text = "你的分数太高啦，这边建议去工地哦！";
                label14.Text = "你的分数太高啦，这边建议去工地哦！";
                label16.Text = "你的分数太高啦，这边建议去工地哦！";
            }
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") now = 0;
            sum += now;
            label2.Text = sum.ToString();
            now = 0;
            textBox1.Text = "";
        }
    }
}

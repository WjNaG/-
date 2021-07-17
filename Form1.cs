using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace 中考查分小助手
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WebBrowser wb = new WebBrowser();
        int Mode;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "http://www.shmeea.edu.cn/page/index.html";
            }
            //wb.Dispose();
            //wb = new WebBrowser();
            //直接用就好了，为什么要dispose掉再新建。。。
            //Controls.Add(wb);
            wb.Visible = true;
            wb.Size = new Size(1157, 471);
            wb.Location = new Point(1, 100);
            wb.ScriptErrorsSuppressed = true;
            wb.Navigate(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wb.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
            panel1.Visible = false;
            wb = new WebBrowser();
            Controls.Add(wb);
            wb.Size = new Size(1157, 471);
            wb.Location = new Point(1, 100);
            wb.ScriptErrorsSuppressed = true;
            wb.Navigate(textBox1.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Left = 1;
            panel1.Width = 900;
            Mode = 1;

            panel1.Size = new Size(1157, 471);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (panel1.Width < 900 && Mode == 1)
            {
                panel1.Left -= 90;
                panel1.Width += 90;
            }
            if (panel1.Width > 90 && Mode == 2)
            {
                panel1.Width -= 90;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (panel1.Width > 90 && Mode == 1)
            {
                panel1.Left += 90;
                panel1.Width -= 90;
            }
            if (panel1.Width < 900 && Mode == 2)
            {
                panel1.Width += 90;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要打开的文件";
            ofd.Multiselect = false;
            ofd.Filter = "图像文件|*.jpg;*.png;*.jpeg|所有文件|*.*";
            if (ofd.ShowDialog() == DialogResult.Cancel) return;
            Image img = Image.FromFile(ofd.FileName);
            pB1.Image = img;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Left = 1;
            panel1.Width = 900;
            Mode = 2;

            panel1.Size = new Size(1157, 471);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void 截图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Size mySize = wb.Document.Window.Size;
                Bitmap myPic = new Bitmap(mySize.Width, mySize.Height);
                Rectangle myRec = new Rectangle(0, 0, mySize.Width, mySize.Height);
                Size tmp = wb.Size;
                wb.Size = mySize;
                wb.DrawToBitmap(myPic, myRec);
                wb.Size = tmp;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "请选择要保存的位置";
                sfd.Filter = "图像文件|*.jpg|所有文件|*.*";
                sfd.ShowDialog();

                string path = sfd.FileName;
                if (path == "")
                {
                    return;
                }
                myPic.Save(path);
                MessageBox.Show(" OK ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void 系统计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void 中考计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }
        SoundPlayer sp;
        List<string> urlList = new List<string>();
        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要打开的文件";
            ofd.Multiselect = false;
            ofd.Filter = "(*.wav)|*.wav";
            if (ofd.ShowDialog() == DialogResult.Cancel) return;
            sp = new SoundPlayer();
            sp.SoundLocation = Path.GetFileNameWithoutExtension(ofd.FileName);
            sp.Play();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sp.Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Visible = false;
        }

        private void 关于作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linkLabel1.Visible = true;
        }

        bool MoveFlag; int xPos, yPos;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MoveFlag = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveFlag)
            {
                Panel picBox = (Panel)sender;
                picBox.Left += Convert.ToInt16(e.X - xPos);//设置x坐标.
                picBox.Top += Convert.ToInt16(e.Y - yPos);//设置y坐标.
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFlag = true;//已经按下.
            xPos = e.X;//当前x坐标.
            yPos = e.Y;//当前y坐标.
        }
    }
}

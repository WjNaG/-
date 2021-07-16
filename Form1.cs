using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
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
            string add = "";
            if (textBox1.Text == "")
            {
                textBox1.Text = "http://www.shmeea.edu.cn/page/index.html";
            }
            wb.Dispose();
            wb = new WebBrowser();
            Controls.Add(wb);
            wb.Size = new Size(900, 400);
            wb.Location = new Point(1, 90);
            wb.ScriptErrorsSuppressed = true;
            wb.Navigate(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wb.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
            panel1.Visible = false;
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
            ofd.Filter = "图像文件|*.jpg|所有文件|*.*";
            ofd.ShowDialog();

            string path = ofd.FileName;
            if (path == "")
            {
                return;
            }
            string filename = Path.GetFileName(path);
            Image img = Image.FromFile(path);
            pB1.Image = img;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Left = 1;
            panel1.Width = 900;
            Mode = 2;
        }

        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void 截图ToolStripMenuItem_Click(object sender, EventArgs e)
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
            ofd.ShowDialog();

            string path = ofd.FileName;
            if (path == "")
            {
                return;
            }
            
            
            sp = new SoundPlayer();
            sp.SoundLocation = Path.GetFileNameWithoutExtension(path);
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
    }
}

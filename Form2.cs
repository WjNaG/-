using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 中考查分小助手
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //        Process[] pros = Process.GetProcesses();
            //          foreach (var item in pros)
            //          {
            //              item.Kill();
            //              Console.WriteLine(item);
            //          }
            System.Diagnostics.Process.Start("shutdown.exe", "-s");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

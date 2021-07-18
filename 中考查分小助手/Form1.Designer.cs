
namespace 中考查分小助手
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pB1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中考计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.截图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于作者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "欢迎来到中考查分小程序！";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "登录查分网址：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 54);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 21);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "http://www.shmeea.edu.cn/page/index.html";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 22);
            this.button1.TabIndex = 16;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(571, 54);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 22);
            this.button2.TabIndex = 15;
            this.button2.Text = "close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(643, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "北京时间：";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(706, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pB1
            // 
            this.pB1.Location = new System.Drawing.Point(228, 78);
            this.pB1.Margin = new System.Windows.Forms.Padding(2);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(75, 40);
            this.pB1.TabIndex = 0;
            this.pB1.TabStop = false;
            this.pB1.Click += new System.EventHandler(this.pB1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1180, 186);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 36);
            this.button3.TabIndex = 12;
            this.button3.Text = "从左往右查分";
            this.toolTip1.SetToolTip(this.button3, "刮刮乐，保留悬念");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1180, 146);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 36);
            this.button4.TabIndex = 11;
            this.button4.Text = "直接查分";
            this.toolTip1.SetToolTip(this.button4, "一步到位，惊险刺激");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pB1);
            this.panel1.Location = new System.Drawing.Point(1, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 512);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1010, 37);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 39);
            this.button5.TabIndex = 9;
            this.button5.Text = "<<";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1070, 37);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 39);
            this.button6.TabIndex = 8;
            this.button6.Text = ">>";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(1180, 266);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 35);
            this.button7.TabIndex = 7;
            this.button7.Text = "自定义遮挡图片";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1320, 25);
            this.menuStrip1.TabIndex = 6;
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计算器ToolStripMenuItem,
            this.截图ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 计算器ToolStripMenuItem
            // 
            this.计算器ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统计算器ToolStripMenuItem,
            this.中考计算器ToolStripMenuItem});
            this.计算器ToolStripMenuItem.Name = "计算器ToolStripMenuItem";
            this.计算器ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.计算器ToolStripMenuItem.Text = "计算器";
            // 
            // 系统计算器ToolStripMenuItem
            // 
            this.系统计算器ToolStripMenuItem.Name = "系统计算器ToolStripMenuItem";
            this.系统计算器ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.系统计算器ToolStripMenuItem.Text = "本机计算器";
            this.系统计算器ToolStripMenuItem.Click += new System.EventHandler(this.系统计算器ToolStripMenuItem_Click);
            // 
            // 中考计算器ToolStripMenuItem
            // 
            this.中考计算器ToolStripMenuItem.Name = "中考计算器ToolStripMenuItem";
            this.中考计算器ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.中考计算器ToolStripMenuItem.Text = "考试计算器";
            this.中考计算器ToolStripMenuItem.Click += new System.EventHandler(this.中考计算器ToolStripMenuItem_Click);
            // 
            // 截图ToolStripMenuItem
            // 
            this.截图ToolStripMenuItem.Name = "截图ToolStripMenuItem";
            this.截图ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.截图ToolStripMenuItem.Text = "网页截图";
            this.截图ToolStripMenuItem.Click += new System.EventHandler(this.截图ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于作者ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于作者ToolStripMenuItem
            // 
            this.关于作者ToolStripMenuItem.Name = "关于作者ToolStripMenuItem";
            this.关于作者ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.关于作者ToolStripMenuItem.Text = "关于作者";
            this.关于作者ToolStripMenuItem.Click += new System.EventHandler(this.关于作者ToolStripMenuItem_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1180, 226);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(118, 36);
            this.button8.TabIndex = 5;
            this.button8.Text = "从右往左查分";
            this.toolTip1.SetToolTip(this.button8, "刮刮乐，保留悬念");
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.No;
            this.button9.Location = new System.Drawing.Point(1170, 575);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(145, 22);
            this.button9.TabIndex = 4;
            this.button9.Text = "心态崩了，世界毁灭吧！！";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(152, 34);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(341, 18);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "作者：WjNaG  咨询QQ:1985996558       代码润色：IAFEnvoy";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1180, 306);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(118, 36);
            this.button10.TabIndex = 20;
            this.button10.Text = "音乐暂停/继续";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 602);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "中考查分小助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pB1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 截图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ToolStripMenuItem 系统计算器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中考计算器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于作者ToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button10;
    }
}


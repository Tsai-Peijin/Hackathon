using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(".");
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "結果： ";
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                double F;
                var C = Convert.ToDouble(textBox1.Text);
                F = C * 9 / 5 + 32;
                label1.Text = "結果：" + C + "°C = " + F + "°F";
            }
            else if (radioButton2.Checked == true)
            {
                double C;
                var F = Convert.ToDouble(textBox1.Text);
                C = (F - 32) * 5 / 9;
                label1.Text = "結果：" + F + "°F = " + C + "°C";
            }
        }
    }
}

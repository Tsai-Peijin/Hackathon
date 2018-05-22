using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon004
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        string an;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random ran = new Random();

            int i;
            while (list.Count < 4)
            {
                i = ran.Next(0, 10);
                if (list.Any((x) => x == i.ToString()) == false)
                {
                    list.Add(i.ToString());
                }
            }
            an = list[0].ToString() + list[1].ToString() + list[2].ToString() + list[3].ToString();
            MessageBox.Show(an);
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show(an);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            int B;
            int A = 0;

            var intersect = an.Intersect(input);
            B = intersect.Count();

            foreach (var a in intersect)
            {
                if (input.IndexOf(a) == an.IndexOf(a))
                {
                    A++;
                }
            }
            B = B - A;
            textBox2.Text += input + "   " + A + "A" + B + "B" + Environment.NewLine;

            if (A == 4 && B == 0)
            {
                MessageBox.Show("恭喜過關！");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}

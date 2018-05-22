using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private string FineData()
        {
            int year = dateTimePicker1.Value.Year;
            DateTime s牡羊 = new DateTime(year, 3, 21);
            DateTime e牡羊 = new DateTime(year, 4, 20);
            DateTime s金牛 = new DateTime(year, 4, 21);
            DateTime e金牛 = new DateTime(year, 5, 20);
            DateTime s雙子 = new DateTime(year, 5, 21);
            DateTime e雙子 = new DateTime(year, 6, 21);
            DateTime s巨蟹 = new DateTime(year, 6, 22);
            DateTime e巨蟹 = new DateTime(year, 7, 22);
            DateTime s獅子 = new DateTime(year, 7, 23);
            DateTime e獅子 = new DateTime(year, 8, 22);
            DateTime s處女 = new DateTime(year, 8, 23);
            DateTime e處女 = new DateTime(year, 9, 22);
            DateTime s天秤 = new DateTime(year, 9, 23);
            DateTime e天秤 = new DateTime(year, 10, 22);
            DateTime s天蠍 = new DateTime(year, 10, 23);
            DateTime e天蠍 = new DateTime(year, 11, 21);
            DateTime s射手 = new DateTime(year, 11, 22);
            DateTime e射手 = new DateTime(year, 12, 21);
            DateTime s魔羯 = new DateTime(year, 12, 22);
            DateTime mi魔羯 = new DateTime(year, 12, 31);
            DateTime m魔羯 = new DateTime(year, 1, 1);
            DateTime e魔羯 = new DateTime(year, 1, 19);
            DateTime s水瓶 = new DateTime(year, 1, 20);
            DateTime e水瓶 = new DateTime(year, 2, 18);
            DateTime s雙魚 = new DateTime(year, 2, 19);
            DateTime e雙魚 = new DateTime(year, 3, 20);

            var date = dateTimePicker1.Value.Date;

            if (s牡羊 <= date && date <= e牡羊)
            {
                return "牡羊座";
            }
            else if (s金牛 <= date && date <= e金牛)
            {
                return "金牛座";
            }
            else if (s雙子 <= date && date <= e雙子)
            {
                return "雙子座";
            }
            else if (s巨蟹 <= date && date <= e巨蟹)
            {
                return "巨蟹座";
            }
            else if (s獅子 <= date && date <= e獅子)
            {
                return "獅子座";
            }
            else if (s處女 <= date && date <= e處女)
            {
                return "處女座";
            }
            else if (s天秤 <= date && date <= e天秤)
            {
                return "天秤座";
            }
            else if (s天蠍 <= date && date <= e天蠍)
            {
                return "天蠍座";
            }
            else if (s射手 <= date && date <= e射手)
            {
                return "射手座";
            }
            else if ((s魔羯 <= date && date <= mi魔羯) || (date <= e魔羯 && m魔羯 <= date))
            {
                return "魔羯座";
            }
            else if (s水瓶 <= date && date <= e水瓶)
            {
                return "水瓶座";
            }
            else
            {
                return "雙魚座";
            }
        }

        private void Lifetree()
        {
            int i = 0;
            int j = 0;
            string lifetree = dateTimePicker1.Value.Year.ToString() + dateTimePicker1.Value.Month.ToString() + dateTimePicker1.Value.Day.ToString();
            foreach (var value in lifetree)
            {
                i += int.Parse(value.ToString());
            }

            if (i > 9)
            {
                foreach (var z in i.ToString())
                {
                    j += int.Parse(z.ToString());
                }
            }
            label5.Text =  j.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string p;
            Lifetree();
            p = FineData();
            label3.Text = p;
           
            switch (p)
            {
                case "牡羊座":
                    var aa = Class1.CreateAries();
                    var bb = aa[int.Parse(label5.Text)];
                    label4.Text = bb;
                    break;
                case "金牛座":
                    aa = Class1.CreateTaurus();
                    bb = aa[int.Parse(label5.Text)];
                    label4.Text = bb;
                    break;
                case "雙子座":
                    aa = Class1.CreateGemini();
                    bb = aa[int.Parse(label5.Text)];
                    label4.Text = bb;
                    break;
                case "巨蟹座":
                    aa = Class1.CreateCancer();
                    bb = aa[int.Parse(label5.Text)];
                    label4.Text = bb;
                    break;
                case "獅子座":
                    aa = Class1.CreateLeo();
                    bb = aa[int.Parse(label5.Text)];
                    label4.Text = bb;
                    break;
                case "處女座":
                    aa = Class1.CreateVirgo();
                    bb = aa[int.Parse(label5.Text)];
                    label4.Text = bb;
                    break;
                case "天秤座":
                    aa = Class1.CreateLibra();
                    bb = aa[int.Parse(label5.Text)];
                    label4.Text = bb;
                    break;
                case "天蠍座":
                    aa = Class1.CreateScorpio();
                    bb = aa[int.Parse(label5.Text)];
                    label4.Text = bb;
                    break;
                case "射手座":
                    aa = Class1.CreateSagittarius();
                    bb = aa[int.Parse(label5.Text)];
                    label4.Text = bb;
                    break;
                case "魔羯座":
                    aa = Class1.CreateCapricorn();
                    bb = aa[int.Parse(label5.Text)];
                    label4.Text = bb;
                    break;
                case "水瓶座":
                    aa = Class1.CreateAquarius();
                    bb = aa[int.Parse(label5.Text)];
                    label4.Text = bb;
                    break;
                default:
                    aa = Class1.CreatePieces();
                    bb = aa[int.Parse(label5.Text)];
                    label4.Text = bb;
                    break;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сalculator
{
    public partial class Сalculator : Form
    {
        int a, b, c;
        
        public Сalculator()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + 9;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            a = int.Parse(txt.Text);
            txt.Clear();
            c = 1;  
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            a = int.Parse(txt.Text);
            txt.Clear();
            c = 2;  
        }

        private void btnUmnozhenie_Click(object sender, EventArgs e)
        {
            a = int.Parse(txt.Text);
            txt.Clear();
            c = 3;  
        }
        private void btnDelenie_Click(object sender, EventArgs e)
        {
            a = int.Parse(txt.Text);
            txt.Clear();
            c = 4;
        }

        private void btnRavno_Click(object sender, EventArgs e)
        {
            switch (c)
            {
                case 1:
                    b = a + int.Parse(txt.Text);
                    txt.Text = b.ToString();
                    break;
                case 2:
                    b = a - int.Parse(txt.Text);
                    txt.Text = b.ToString();
                    break;
                case 3:
                    b = a * int.Parse(txt.Text);
                    txt.Text = b.ToString();
                    break;
                case 4:
                    b = a / int.Parse(txt.Text);
                    txt.Text = b.ToString();
                    break;

                default:
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt.Text = "";
        }
    }
}

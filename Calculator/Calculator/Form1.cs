using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        String n1 = "", n2 = "";
        double num1 = -1, num2 = -1;
        String str = "", op = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (op.Equals(""))
                n1 += one.Text;
            else
                n2 += one.Text;
            str = str + "1";
            textBox1.Text = str;
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (op.Equals(""))
                n1 += two.Text;
            else
                n2 += two.Text;
            str = str + "2";
            textBox1.Text = str;
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (op.Equals(""))
                n1 += three.Text;
            else
                n2 += three.Text;
            str = str + "3";
            textBox1.Text = str;
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (op.Equals(""))
                n1 += four.Text;
            else
                n2 += four.Text;
            str = str + "4";
            textBox1.Text = str;
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (op.Equals(""))
                n1 += five.Text;
            else
                n2 += five.Text;
            str = str + "5";
            textBox1.Text = str;
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (op.Equals(""))
                n1 += six.Text;
            else
                n2 += six.Text;
            str = str + "6";
            textBox1.Text = str;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (op.Equals(""))
                n1 += seven.Text;
            else
                n2 += seven.Text;
            str = str + "7";
            textBox1.Text = str;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (op.Equals(""))
                n1 += eight.Text;
            else
                n2 += eight.Text;
            str = str + "8";
            textBox1.Text = str;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (op.Equals(""))
                n1 += nine.Text;
            else
                n2 += nine.Text;
            str = str + "9";
            textBox1.Text = str;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (op.Equals(""))
                n1 += zero.Text;
            else
                n2 += zero.Text;
            str = str + "0";
            textBox1.Text = str;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(n1);
            num2 = Convert.ToDouble(n2);
            if (n1.Equals(""))
                MessageBox.Show("Enter number first!");
            else
            {
                if (op.Equals("sin") || op.Equals("cos") || op.Equals("tan"))
                {

                }
                else
                {
                    if (op.Equals("+") || op.Equals("-") || op.Equals("*") || op.Equals("/") || op.Equals("pow"))
                    {

                    }
                    else
                    {
                        textBox1.Text = n1;
                    }
                }
            }
        }

        private void sum_Click(object sender, EventArgs e)
        {
            str = str + "+";
            textBox1.Text = str;
            if (op.Equals(""))
            {
                op = "+";
            }
            else
                MessageBox.Show("One operation at a time!");
        }

        private void sub_Click(object sender, EventArgs e)
        {
            str = str + "-";
            textBox1.Text = str;
            if (op.Equals(""))
            {
                op = "-";
            }
            else
                MessageBox.Show("One operation at a time!");
        }

        private void mul_Click(object sender, EventArgs e)
        {
            str = str + "*";
            textBox1.Text = str;
            if (op.Equals(""))
            {
                op = "*";
            }
            else
                MessageBox.Show("One operation at a time!");
        }

        private void div_Click(object sender, EventArgs e)
        {
            str = str + "/";
            textBox1.Text = str;
            if (op.Equals(""))
            {
                op = "/";
            }
            else
                MessageBox.Show("One operation at a time!");
        }

        private void sin_Click(object sender, EventArgs e)
        {
            str = str + "str";
            textBox1.Text = str;
            if (op.Equals(""))
            {
                op = "sin";
            }
            else
                MessageBox.Show("One operation at a time!");
        }

        private void cos_Click(object sender, EventArgs e)
        {
            str = str + "cos";
            textBox1.Text = str;
            if (op.Equals(""))
            {
                op = "cos";
            }
            else
                MessageBox.Show("One operation at a time!");
        }

        private void tan_Click(object sender, EventArgs e)
        {
            str = str + "tan";
            textBox1.Text = str;
            if (op.Equals(""))
            {
                op = "tan";
            }
            else
                MessageBox.Show("One operation at a time!");
        }

        private void power_Click(object sender, EventArgs e)
        {
            str = str + "^";
            textBox1.Text = str;
            if (op.Equals(""))
            {
                op = "pow";
            }
            else
                MessageBox.Show("One operation at a time!");
        }


    }
}

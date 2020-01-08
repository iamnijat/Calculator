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
        public Form1()
        {
            InitializeComponent();
        }

        double firstnum;
        string oper;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox2.Text);

            if (oper == "+")
            {
                Result = (firstnum + SecondNumber);
               
                textBox2.Text = Convert.ToString(Result);
                firstnum = Result;
            }
            if (oper == "-")
            {
                Result = (firstnum - SecondNumber);
                textBox2.Text = Convert.ToString(Result);
                firstnum = Result;
            }

            if (oper == "*")
            {
                Result = (firstnum * SecondNumber);
                textBox2.Text = Convert.ToString(Result);
                firstnum = Result;
            }
            if (oper == "%")
            {
                Result = (firstnum % SecondNumber);
                textBox2.Text = Convert.ToString(Result);
                firstnum = Result;
            }


            if (oper == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox2.Text = "Sifira bolue bilmez";

                }
                else
                {
                    Result = (firstnum / SecondNumber);
                    textBox2.Text = Convert.ToString(Result);
                    firstnum = Result;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "6";
            }
            else
            {
                textBox2.Text = textBox2.Text + "6";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "1";
            }
            else
            {
                textBox2.Text = textBox2.Text + "1";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "2";
            }
            else
            {
                textBox2.Text = textBox2.Text + "2";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "3";
            }
            else
            {
                textBox2.Text = textBox2.Text + "3";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "4";
            }
            else
            {
                textBox2.Text = textBox2.Text + "4";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "5";
            }
            else
            {
                textBox2.Text = textBox2.Text + "5";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "7";
            }
            else
            {
                textBox2.Text = textBox2.Text + "7";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "8";
            }
            else
            {
                textBox2.Text = textBox2.Text + "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "9";
            }
            else
            {
                textBox2.Text = textBox2.Text + "9";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            firstnum = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "0";
            oper = "+";

        }

        private void button5_Click(object sender, EventArgs e)
        {

            firstnum = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "0";
            oper = "-";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "0";
            oper = "*";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "0";
            oper = "/";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "0";
            oper = "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
    }
}

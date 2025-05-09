using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colculator
{
    public partial class Form1 : Form
    {
        decimal number1, number2, result;
     
        enum operation
        {
            blank,
            addition,
            division,
            multiplication,
            subtraction



        }
        operation currenstatus = operation.blank;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            number1 = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            currenstatus = operation.addition;

        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            number1 = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            currenstatus = operation.subtraction;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            number1 = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            currenstatus = operation.multiplication;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            number1 = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            currenstatus = operation.division;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!= " ")
            {
                try
                {


                    number2 = decimal.Parse(textBox1.Text);
                    textBox1.Clear();
                    switch (currenstatus)
                    {
                        case operation.blank:
                            result = number2;
                            break;
                        case operation.addition:
                            result = number1 + number2;
                            break;
                        case operation.subtraction:
                            result = number1 - number2;
                            break;
                        case operation.division:
                            result = number1 / number2;
                            break;
                        case operation.multiplication:
                            result = number1 * number2;
                            break;


                    }
                    textBox1.Text = result.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("لطفا عدد دوم را انتخاب کنید ");

                }

            }
            else
            {
                MessageBox.Show("خطلا در اجرای برنامه لطلا محدد وارد شوید");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
    }
}

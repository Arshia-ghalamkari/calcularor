using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(textBox2.Text);
            textBox2.Text = "";
            str = "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text += 1.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox2.Text += b.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(textBox2.Text);
            textBox2.Text = "";
            str = "+";
        }
        int number1;
        int number2;
        int result;
        string str;

        private void button12_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(textBox2.Text);
            textBox2.Text = "";
            str = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(textBox2.Text);
            textBox2.Text = "";
            str = "*";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            number2 = int.Parse(textBox2.Text);

            switch (str)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
            }
            textBox2.Text = result.ToString();
        }
    }
}

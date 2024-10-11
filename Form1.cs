using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desing_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string caltotal;
        int num1;
        int num2;
        string option;
        int result;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TXTTOTAL.Text = TXTTOTAL.Text + "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TXTTOTAL.Text = TXTTOTAL.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TXTTOTAL.Text = TXTTOTAL.Text + "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TXTTOTAL.Text = TXTTOTAL.Text + "5";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TXTTOTAL.Text = TXTTOTAL.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TXTTOTAL.Text = TXTTOTAL.Text + "9";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TXTTOTAL.Text = TXTTOTAL.Text + "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(TXTTOTAL.Text);
            TXTTOTAL.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(TXTTOTAL.Text);
            if (option.Equals("+"));
            result = num1 + num2;

            
            if (option.Equals("-"));
            result = num1 - num2;

           
            if (option.Equals("*"));
            result = num1 * num2;

           
            if (option.Equals("/"));
            result = num1 / num2;

            TXTTOTAL.Text = result + "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TXTTOTAL_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TXTTOTAL.Text = TXTTOTAL.Text + "2";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TXTTOTAL.Text = TXTTOTAL.Text + "6";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            TXTTOTAL.Text = TXTTOTAL.Text + "0";
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(TXTTOTAL.Text);
            TXTTOTAL.Clear();
        }

        private void buttonmin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(TXTTOTAL.Text);
            TXTTOTAL.Clear();
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(TXTTOTAL.Text);
            TXTTOTAL.Clear();
        }
    }
}

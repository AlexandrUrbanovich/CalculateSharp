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
        private double x = 0, q = 0;
        int count;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
         }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            x = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                count = 1;
            }
            catch {
                MessageBox.Show("Не верно введено число.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                count = 2;
            }
            catch {
                MessageBox.Show("Не верно введено число.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                count = 3;
            }
            catch {
                MessageBox.Show("Не верно введено число.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                count = 4;
            }
            catch {
                MessageBox.Show("Не верно введено число.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                x = Math.Sqrt(Convert.ToSingle(textBox1.Text));
                textBox1.Text = x.ToString();
            }
            catch {
                MessageBox.Show("Не верно введено число.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                calculate();
            }
            catch {
                MessageBox.Show("Не верно введено число.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
        }

        public void calculate() {
            switch (count){
                case 1:
                    x += Convert.ToDouble(textBox1.Text);
                    textBox1.Text = x.ToString();
                    break;
                case 2:
                    x -= Convert.ToDouble(textBox1.Text);
                    textBox1.Text = x.ToString();
                    break;
                case 3:
                    x *= Convert.ToDouble(textBox1.Text);
                    textBox1.Text = x.ToString();
                    break;
                case 4:
                    q = Convert.ToDouble(textBox1.Text);
                    if (q == 0) {
                        MessageBox.Show("Деление на ноль","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                    }
                    else{
                        x /= Convert.ToDouble(textBox1.Text);
                        textBox1.Text = x.ToString();
                    }
                    
                    break;
  
                default:
                    break;
            }
        }
    }
}

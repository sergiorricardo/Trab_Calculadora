using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcVirtual
{
    public partial class Form1 : Form
    {
        double valor1;
        double valor2;
        double result;
        int operacao;
        
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = ("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text == ("0")){
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ("0"))
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

                valor1 = Convert.ToDouble(textBox1.Text);
                operacao = 1;
                textBox1.Text = ("0");
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ("0"))
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ("0"))
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ("0"))
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ("0"))
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ("0"))
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ("0"))
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ("0"))
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ("0"))
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
                      
                valor2 = Convert.ToDouble(textBox1.Text);
           
                switch (operacao)
                {
                    case 1:
                        result = valor1 + valor2;
                        textBox1.Text = result.ToString();
                        //MessageBox.Show("valor " + result);
                        break;

                    case 2:
                        result = valor1 - valor2;
                        textBox1.Text = result.ToString();
                        //MessageBox.Show("valor " + result);
                        break;

                    case 3:
                        result = valor1 * valor2;
                        textBox1.Text = result.ToString();
                        //MessageBox.Show("valor " + result);
                        break;

                    case 4:
                        result = valor1 / valor2;
                        textBox1.Text = result.ToString();
                        //MessageBox.Show("valor " + result);
                        break;
                }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                 

        }

        private void button5_Click(object sender, EventArgs e)
        {
                       
                valor1 = Convert.ToDouble(textBox1.Text);
                operacao = 2;
                textBox1.Text = ("0");
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
          
                valor1 = Convert.ToDouble(textBox1.Text);
                operacao = 3;
                textBox1.Text = ("0");
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
                valor1 = Convert.ToDouble(textBox1.Text);
                operacao = 4;
                textBox1.Text = ("0");
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("0");
        }
    }
}

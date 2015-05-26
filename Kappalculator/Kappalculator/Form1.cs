using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kappalculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
            Console.Beep(420, 200);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            Console.Beep(420, 200);
        }

        private void operator_click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
            Console.Beep(420, 200);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                            Console.Beep(1046, 300);//do
                            Console.Beep(987, 300);//si
                            Console.Beep(880, 300);//la
                            Console.Beep(783, 300);//sol
                            Console.Beep(783, 300);//sol
                            Console.Beep(880, 150);//la
                            Console.Beep(987, 150);//si
                            Console.Beep(880, 300);//la
                            Console.Beep(659, 300); //mi
                            Console.Beep(733, 600); //fa#
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                            Console.Beep(1174, 400); //re2
                            Console.Beep(1174, 200); //re2
                            Console.Beep(1567, 400); //sol2
                            Console.Beep(1396, 200); //sol2
                            Console.Beep(1244, 400); //mib
                            Console.Beep(1174, 200); //re
                            Console.Beep(1046, 400); //do
                            Console.Beep(923, 200);  //sib
                            Console.Beep(880, 400);  //la
                            Console.Beep(783, 200);  //sol
                            Console.Beep(1174, 600);//re2
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                            Console.Beep(1046, 300);//do
                            Console.Beep(987, 300);//si
                            Console.Beep(880, 300);//la
                            Console.Beep(783, 300);//sol
                            Console.Beep(1174, 900);//re2
                            Console.Beep(880, 300);//la
                            Console.Beep(880, 600);//la
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                            Console.Beep(1046, 300);//do
                            Console.Beep(987, 300);//si
                            Console.Beep(880, 300);//la
                            Console.Beep(783, 300);//sol
                            Console.Beep(1174, 900);//re2
                            Console.Beep(880, 300);//la
                            Console.Beep(880, 600);//la

                    break;

                default:
                    break;

                             
            }
            
         

        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section_2_Lecture_4_Calculator
{
    public partial class Form1 : Form
    {
        string operand1, operand2, my_operator, temp_string;
        double my_result;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            operand1 = null;
            operand2 = null;
            my_operator = null;
            Display.Text = "0";
        }

        private void Button_clear_entry_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            concatenate_display("0");
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            concatenate_display("1");
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            concatenate_display("2");
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            concatenate_display("3");
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            concatenate_display("4");
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            concatenate_display("5");
        }
        private void Button_6_Click(object sender, EventArgs e)
        {
            concatenate_display("6");
        }
        private void Button_7_Click(object sender, EventArgs e)
        {
            concatenate_display("7");
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            concatenate_display("8");
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            concatenate_display("9");
        }

        public void op_click(String this_operator)
        {
            if (operand1 == null)
            {   // grab first operand
                operand1 = Display.Text;
                operand2 = null;
                Display.Text = "0";
            }
            else if (operand2 == null)
            {
                // grab second operand
                operand2 = Display.Text;
                operand1 = Convert.ToString(calculate_result());
                Display.Text = operand1;
                operand2 = null;
            }

            my_operator = this_operator;

        }
        private void Button_divide_Click(object sender, EventArgs e)
        {
            op_click("/");
        }

        private void Button_times_Click(object sender, EventArgs e)
        {
            op_click("x");
        }

        private void Button_minus_Click(object sender, EventArgs e)
        {
            op_click("-");
        }

        private void Button_plus_Click(object sender, EventArgs e)
        {
            op_click("+");
        }

        private void Button_decimal_Click(object sender, EventArgs e)
        {
            concatenate_display(".");
        }

        private void Button_equal_Click(object sender, EventArgs e)
        {
            if (operand2 == null)
            {
                operand2 = Display.Text;
            }

            Display.Text = Convert.ToString(calculate_result());
            operand1 = null;
            operand2 = null;
            my_operator = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            operand1 = null;
            operand2 = null;
            my_operator = null;
            Display.Text = "0";
        }

        private void Button_change_sign_Click(object sender, EventArgs e)
        {
            /* change sign requires conversion to double and then back to string for display */
            Display.Text = Convert.ToString(-1 * Convert.ToDouble(Display.Text));
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "D0" || e.KeyCode.ToString() == "NumPad0")
            {
                concatenate_display("0");
            } else if (e.KeyCode.ToString() == "D1" || e.KeyCode.ToString() == "NumPad1")
            {
                concatenate_display("1");
            } else if (e.KeyCode.ToString() == "D2" || e.KeyCode.ToString() == "NumPad2")
            {
                concatenate_display("2");
            } else if (e.KeyCode.ToString() == "D3" || e.KeyCode.ToString() == "NumPad3")
            {
                concatenate_display("3");
            } else if (e.KeyCode.ToString() == "D4" || e.KeyCode.ToString() == "NumPad4")
            {
                concatenate_display("4");
            } else if (e.KeyCode.ToString() == "D5" || e.KeyCode.ToString() == "NumPad5")
            {
                concatenate_display("5");
            } else if (e.KeyCode.ToString() == "D6" || e.KeyCode.ToString() == "NumPad6")
            {
                concatenate_display("6");
            } else if (e.KeyCode.ToString() == "D7" || e.KeyCode.ToString() == "NumPad7")
            {
                concatenate_display("7");
            } else if (e.KeyCode.ToString() == "D8" || e.KeyCode.ToString() == "NumPad8")
            {
                concatenate_display("8");
            } else if (e.KeyCode.ToString() == "D9" || e.KeyCode.ToString() == "NumPad9")
            {
                concatenate_display("9");
            } else if (e.KeyCode.ToString() == "Divide")
            {
                op_click("/");
            } else if (e.KeyCode.ToString() == "Multiply")
            {
                op_click("x");
            } else if (e.KeyCode.ToString() == "Subtract")
            {
                op_click("-");
            } else if (e.KeyCode.ToString() == "Add")
            {
                op_click("+");
            }
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                Display.BackColor = colorDialog1.Color;
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Load(openFileDialog1.FileName);
        }

        public void concatenate_display(string x)
        {
            if (Display.Text != "0" && Display.Text != operand1)
            {
                is_too_long();
                Display.Text = Display.Text + x;
            }   else
                Display.Text = x;
        }

        public void is_too_long()
        {
            if (Display.Text.Length >= 33)
            {
                Console.Beep();
                MessageBox.Show("Your number is too long", "Too Long");
            }
        }

        public ref double calculate_result()
        {
            if (my_operator == "+")
            {
                my_result = Convert.ToDouble(operand1) + Convert.ToDouble(operand2);
            }
            else if (my_operator == "-")
            {
                my_result = Convert.ToDouble(operand1) - Convert.ToDouble(operand2);
            }
            else if (my_operator == "x")
            {
                my_result = Convert.ToDouble(operand1) * Convert.ToDouble(operand2);
            }
            else if (my_operator == "/")
            {
                my_result = Convert.ToDouble(operand1) / Convert.ToDouble(operand2);
            }
            return ref my_result;

        }
    }
}


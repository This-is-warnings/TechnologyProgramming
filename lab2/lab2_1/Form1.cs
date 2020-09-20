using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            textBox1.TextChanged += TextBox1_TextChanged;
            textBox2.TextChanged += TextBox1_TextChanged;
            textBox3.TextChanged += TextBox1_TextChanged;
            textBox4.TextChanged += TextBox1_TextChanged;
            textBox1.KeyPress += TextBox1_KeyPress;
            textBox2.KeyPress += TextBox1_KeyPress;
            textBox3.KeyPress += TextBox1_KeyPress;
            textBox4.KeyPress += TextBox1_KeyPress;
            button1.MouseClick += Button1_MouseClick;
           // button1.MouseDoubleClick += Button1_MouseDoubleClick;
        }

        

        static private bool proverkav2(string s)
        {
            if (s[0] == '.' || s[s.Length - 1] == '.') return false;
           // else if (s[0] == '0' && s.Length != 1) return false;
            else if (s[0] == '-' && s[1] == '.') return false;
            else return true;

        }
        static private bool proverka(string s1, string s2, string s3, string s4)
        {
            if (s1 == "" || s2 == "" || s3 == "" || s4 == "")
                return false;
            else return true;

        }

        static private int proverkav3(double x0,double xn,double dx)
        {
            if (x0 < xn && dx < 0) return -2;
            else if (dx == 0) return -3;
            else if (x0 > xn && dx > 0) return -4;
            else if (xn == x0) return -5;
            else return 0;
        }

        static private double func(double x, double b)        
        {
            return 9 * (x * x * x + b * b * b) * Math.Tan(x);
        }
        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if(!proverka(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text))
                    MessageBox.Show("Введите все поля!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if(!proverkav2(textBox1.Text)|| !proverkav2(textBox2.Text)|| !proverkav2(textBox3.Text)|| !proverkav2(textBox4.Text))
                    MessageBox.Show("Вы ввели некорректные данные!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    richTextBox1.Text = "";
                    string s1 = textBox1.Text;
                    s1 = s1.Replace('.', ',');
                    string s2 = textBox2.Text;
                    s2 = s2.Replace('.', ',');
                    string s3 = textBox3.Text;
                    s3 = s3.Replace('.', ',');
                    string s4 = textBox4.Text;
                    s4 = s4.Replace('.', ',');
                    double x0 = double.Parse(s1);
                    double xn = double.Parse(s2);
                    double dx = double.Parse(s3);
                    double b = double.Parse(s4);
                    double f;
                    if (proverkav3(x0, xn, dx) == 0)
                    {
                        if (dx > 0)
                        {
                            for (double i = x0; i <= xn; i += dx)
                            {
                                f = func(i, b);
                                if (!double.IsNaN(f) || !double.IsInfinity(f))
                                {
                                    richTextBox1.Text += "x = " + i + "\t" + func(i, b) + "\n";
                                }
                                else
                                {
                                    richTextBox1.Text += "x = " + i + "\t" + "Не число или бесконечность" + "\n";
                                }
                            }
                        }
                        else
                        {
                            for (double i = x0; i >= xn; i += dx)
                            {
                                f = func(i, b);
                                if (!double.IsNaN(f) || !double.IsInfinity(f))
                                {
                                    richTextBox1.Text += "x = " + i + "\t" + func(i, b) + "\n";
                                }
                                else
                                {
                                    richTextBox1.Text += "x = " + i + "\t" + "Не число или бесконечность" + "\n";
                                }
                            }
                        }
                    }
                    else
                    {
                        switch(proverkav3(x0,xn,dx))
                        {
                            case -2:
                                MessageBox.Show("Вы ввели некорректные данные!\nx0 < xn && dx > 0", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case -3:
                                MessageBox.Show("Вы ввели некорректные данные!\ndx==0", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case -4:
                                MessageBox.Show("Вы ввели некорректные данные!\nx0 > xn && dx < 0", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case -5:
                                MessageBox.Show("Вы ввели некорректные данные!\nxn == x0", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("Неверные данные!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46 && number != 45) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" &&
                textBox2.Text == "" &&
                textBox3.Text == "" &&
                textBox4.Text == "")
                button1.Enabled = false;
            else button1.Enabled = true;
      
        }
    }
}

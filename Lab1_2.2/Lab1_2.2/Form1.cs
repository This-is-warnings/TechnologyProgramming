using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_2._2
{
    public partial class Form1 : Form
    {
       private static int func = 2;
        public Form1()
        {
            InitializeComponent();
            textBox1.TextChanged += TextBox1_TextChanged;
            textBox2.TextChanged += TextBox1_TextChanged;
            textBox3.TextChanged += TextBox1_TextChanged;
            button1.MouseClick += Button1_MouseClick;
            radioButton1.CheckedChanged += RadioButton1_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton1_CheckedChanged;
            radioButton3.CheckedChanged += RadioButton1_CheckedChanged;
            button2.MouseClick += Button2_MouseClick;
            textBox1.KeyPress += TextBox1_KeyPress;
            textBox2.KeyPress += TextBox1_KeyPress;
            textBox3.KeyPress += TextBox1_KeyPress;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  throw new NotImplementedException();
           
                char number = e.KeyChar;
                if (!Char.IsDigit(number) && number != 8 && number != 46 && number != 45) // цифры, клавиша BackSpace и запятая
                {
                    e.Handled = true;
                }
           
        }

        private void Button2_MouseClick(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
            richTextBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            button2.Enabled = false;    
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (radioButton1.Checked) func = 1;
            if (radioButton2.Checked) func = 2;
            if (radioButton3.Checked) func = 3;
            label7.Text = "";
        }
        bool proverka(string s)
        {
            if (s[0] == '.' || s[s.Length - 1] == '.') return false;
            else if (s[0] == '0' && s.Length != 1) return false;
            else if (s[0] == '-' && s[1] == '.') return false;
            else return true;
        }
        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            // throw new NotImplementedException();
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "") MessageBox.Show("Введите все поля", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if(!proverka(textBox1.Text) || !proverka(textBox2.Text)|| !proverka(textBox3.Text)) MessageBox.Show("Вы ввели некоректные данные", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string s1 = textBox1.Text;
                    s1 = s1.Replace('.', ',');
                    string s2 = textBox2.Text;
                    s2 = s2.Replace('.', ',');
                    string s3 = textBox3.Text;
                    s3 = s3.Replace('.', ',');
                    double x = double.Parse(s1);
                    double y = double.Parse(s2);
                    double z = double.Parse(s3);
                    if (provDel(x,y))
                    {
                        label7.Text = F(x, y, z).ToString();
                        richTextBox1.Text += "n(" + x + "," + y + "," + z + ") = " + F(x, y, z) + " ("+st_F()+")" +"\n" ;
                    }
                    else
                    {
                        MessageBox.Show("В функции происходит деление на ноль!\nВведите другие значения.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                  
                }
            }
            catch
            {
                MessageBox.Show("Вы ввели некоректные данные!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static string st_F()
        {
            if (func == 1) return "sh(x)";
            else if (func == 2) return "x^2";
            else return "e^x";
        }

        static double F(double x, double y, double z)
        {
            double min = 0, max = 0;
            switch (func)
            {
                case 1:
                    {
                        if ((Sh(x) + y) > (y - z)) min = y - z;
                        else min = Sh(x) + y;
                        if (Sh(x) > y) max = Sh(x);
                        else max = y;
                        break;
                    }
                case 2:
                    {
                        if ((x * x + y) > (y - z)) min = y - z;
                        else min = x * x + y;
                        if (x * x > y) max = x * x;
                        else max = y;
                        break;
                    }
                case 3:
                    {
                        if ((Math.Exp(x) + y) > (y - z)) min = y - z;
                        else min = Math.Exp(x) + y;
                        if (Math.Exp(x) > y) max = Math.Exp(x);
                        else max = y;
                        break;
                    }
            }
            return min / max;

        }

        static double Sh(double x)
        {
            return (Math.Exp(x) - Math.Exp(-x)) / 2;
        }

        static bool provDel(double x, double y)
        {
            double res = 0;
            switch (func)
            {
                case 1:
                    {

                        if (Sh(x) > y) res = Sh(x);
                        else res = y;
                        break;
                    }
                case 2:
                    {

                        if (x * x > y) res = x * x;
                        else res = y;
                        break;
                    }
                case 3:
                    {

                        if (Math.Exp(x) > y) res = Math.Exp(x);
                        else res = y;
                        break;
                    }
            }
            if (res == 0) return false;
            else return true;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "")
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                button1.Enabled = false;
                if (richTextBox1.Text == "") button2.Enabled = false;
            }
            label7.Text = "";
        }

   
    }
}

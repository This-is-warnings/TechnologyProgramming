using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.TextChanged += TextBox1_TextChanged;
            textBox2.TextChanged += TextBox1_TextChanged;
            textBox3.TextChanged += TextBox1_TextChanged;
            button1.MouseClick += Button1_MouseClick;
            textBox1.KeyPress += TextBox1_KeyPress;
            textBox2.KeyPress += TextBox1_KeyPress;
            textBox3.KeyPress += TextBox1_KeyPress;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46 && number!=45) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private bool proverka(string s)
        {
            int value1 = 0, value2 = 0 ;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '.') value1++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '-') value2++;
            }
            if (value1 > 1 || value2 > 1) return false;
            else return true;
        }
      

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            // throw new NotImplementedException();
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "") MessageBox.Show("Введите все поля", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if(!proverka(textBox2.Text) || !proverka(textBox3.Text) ||!proverka(textBox1.Text)) MessageBox.Show("Вы ввели некоректные данные", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else

                {
                    string s1 = textBox1.Text;
                    s1=s1.Replace('.', ',');                    
                    string s2 = textBox2.Text;
                    s2 = s2.Replace('.', ',');
                    string s3 = textBox3.Text;
                    s3 = s3.Replace('.', ',');
                    double x = double.Parse(s1);
                    double y = double.Parse(s2);
                    double z = double.Parse(s3);
                    if (y == 0 && x < 0)
                    {
                        MessageBox.Show("Невозможно выполнить действие при данных значениях", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        double result = Math.Pow(2, Math.Pow(y, x)) + Math.Pow(3, y * x) - (y * (Math.Atan(z) - Math.PI / 6)) / (Math.Abs(x) + (1 / (y * y + 1)));
                        label7.Text = result.ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка!","Сообщение",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "")
            {
                button1.Enabled = true;
            }
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                button1.Enabled = false;
            }
            label7.Text = "";
        }


    }
}

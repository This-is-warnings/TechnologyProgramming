using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.TextChanged += TextBox1_TextChanged;
            button1.Enabled = false;
            button2.Enabled = false;
            button1.MouseClick += Button1_MouseClick;
            button2.MouseClick += Button2_MouseClick;
            button3.MouseClick += Button3_MouseClick;
        }

        private void Button2_MouseClick(object sender, MouseEventArgs e)
        {
            int probel =0;
            for(int i = 0; i < textBox1.Text.Length;i++)
            {
                if (textBox1.Text[i] == ' ') probel++;
                if (probel >= 2) break;
                
            }
            if(probel < 2)
            {
                label3.Text = "Строка не преобразовалась(меньше 3 слов)";
            }
            else
            {
                string s1 = "", s2 = "", s3 = "";
                int s1_1 = 0, s1_2, s2_1, s2_2, s3_1, s3_2=0;
                int k = 0;
                for(int i = k; ;i++, k++)
                {
                    if (char.IsLetterOrDigit(textBox1.Text[i]))
                    {
                        s1 += textBox1.Text[i];
                    }
                    else { s1_2 = i-1; break; }
                }
                k++;
               
                bool m = true;
                for (int i = k; ; i++, k++)
                {

                    if (char.IsLetterOrDigit(textBox1.Text[i]) || m)
                    {
                        if (char.IsLetterOrDigit(textBox1.Text[i]))
                        {
                            s2 += textBox1.Text[i];
                            if (m) s2_1 = i;
                            m = false;
                        }
                    }
                    else { s2_2 = i - 1; break; }
                }
                k++; m = true;
               
                for (int i = k; i < textBox1.Text.Length; i++, k++)
                {

                    if (char.IsLetterOrDigit(textBox1.Text[i]) || m)
                    {
                        if (char.IsLetterOrDigit(textBox1.Text[i])) {
                            s3 += textBox1.Text[i];
                            if (m) s3_1 = i;
                            m = false;
                        }
                    }
                    else { s3_2 = i - 1; break; }
                }
                label3.Text += s1 + ' '+ s2 + ' ' + s3;
                string ss = s2 + ' ' + s3 + ' ' + s1;
                string sss = textBox1.Text.Substring(s3_2 + 1,textBox1.Text.Length-s3_2 - 1);
                textBox2.Text = ss + sss;


                label3.Text = "Строка преобразовалась";
            }
        }

        private void Button3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            button1.Enabled = false;
            button2.Enabled = false;
            label3.BackColor = Control.DefaultBackColor;
            textBox1.BackColor = Color.White;
            label3.Text = "Очищено";
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            if(textBox1.Text.Length%2==0)
            {
                string s = "";
                for(int i = 0; i < textBox1.Text.Length;i+=2)
                {
                    s += textBox1.Text[i];
                }
                textBox2.Text = s;
                label3.Text = "Строка преобразовалась";
            }
            else
            {
                label3.Text = "Строка не преобразовалась(длинна не четная)";
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                label3.BackColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                textBox1.BackColor = Color.Red;
                label3.Text = "Строка пустая.";
                textBox2.Text = "";
            }
            else if(textBox1.Text.Length > 200)
            {
                label3.BackColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                textBox1.BackColor = Color.Red;
                label3.Text = "Строка превышает 200 символов.";
                textBox2.Text = "";
            }
            else
            {
                bool prov = true;
                for(int i = 0; i < textBox1.Text.Length;i++)
                {
                    if (textBox1.Text[i] != ' ')
                    {
                        prov = false;
                        break;
                    }


                }
                if(!prov)
                {
                    label3.BackColor = Control.DefaultBackColor;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    textBox1.BackColor = Color.White;
                    label3.Text = "";
                    textBox2.Text = "";
                }
                else
                {
                    label3.BackColor = Color.Red;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    textBox1.BackColor = Color.Red;
                    label3.Text = "Строка пустая.";
                    textBox2.Text = "";
                }
            }
        }
    }
}

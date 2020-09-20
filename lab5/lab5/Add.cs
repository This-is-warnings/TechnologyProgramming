using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        Form1 f;
        public Add(Form1 ff)
        {
            InitializeComponent();
            button1.Enabled = false;
            textBox1.TextChanged += TextBox_TextChanged;
            textBox2.TextChanged += TextBox_TextChanged;
            textBox3.TextChanged += TextBox_TextChanged;
            textBox4.TextChanged += TextBox_TextChanged;
            button1.Click += Button1_Click;
            f = ff;
            this.FormClosed += Add_FormClosed;
        }

        private void Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            f.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            f.listBox1.Items.Add(new Auto(textBox1.Text, textBox2.Text, rashod, ves));
            f.Enabled = true;
            this.Close();
        }

        private bool proverka_na_probel(string text)
        {
            if (text != "")
            {
                if (text[0] == ' ')
                {
                    return false;
                }
                else return true;
            }
            else return false;
        }
        double rashod;
        int ves;
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
           if(proverka_na_probel(textBox1.Text) &&
                proverka_na_probel(textBox2.Text) &&
                proverka_na_probel(textBox3.Text)&&
                proverka_na_probel(textBox4.Text))
            {
                try
                {
                    rashod = double.Parse(textBox3.Text);
                    ves = int.Parse(textBox4.Text);
                    if (rashod >= 2 && rashod <= 80 && ves >= 100 && ves <= 5000)
                    {
                        button1.Enabled = true;
                    }
                    else button1.Enabled = false;
                }
                catch
                {
                    button1.Enabled = false;
                }
            }
           else
            {
                button1.Enabled = false;
            }
        }

       
    }
    
}

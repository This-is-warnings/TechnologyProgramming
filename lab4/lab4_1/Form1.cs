using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            textBox1.TextChanged += TextBox1_TextChanged;
            textBox2.TextChanged += TextBox1_TextChanged;
            textBox3.TextChanged += TextBox1_TextChanged;
            textBox4.TextChanged += TextBox1_TextChanged;
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

        double xmin;
        double xmax;
        double step;
        double b;
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            if (proverka_na_probel(textBox1.Text) && proverka_na_probel(textBox3.Text) && proverka_na_probel(textBox2.Text) && proverka_na_probel(textBox4.Text))
            {
                try
                {

                    xmin = double.Parse(textBox1.Text);
                    xmax = double.Parse(textBox2.Text);
                    step = double.Parse(textBox3.Text);
                    b = double.Parse(textBox4.Text);

                    if (step > 0 && xmin < xmax) button1.Enabled = true;
                    else button1.Enabled = false;
                }
                catch
                {
                    button1.Enabled = false;
                }
            }
            else button1.Enabled = false;
        }
        private double func(double x, double b)
        {
            return 9 * (x * x * x + b * b * b) * Math.Tan(x);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            
                int count = (int)Math.Ceiling((xmax - xmin) / step) + 1;
                double[] x = new double[count];
                double[] y = new double[count];
                //chart1.Series.Cha
                for (int i = 0; i < count; i++)
                {
                    x[i] = xmin + step * i;
                    y[i] = func(x[i], b);
                }
                chart1.ChartAreas[0].AxisX.Minimum = xmin;
                chart1.ChartAreas[0].AxisX.Maximum = xmax;
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = step;
                chart1.Series[0].Points.DataBindXY(x, y);
            
        }
    }
}

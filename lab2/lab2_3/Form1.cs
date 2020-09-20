using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_3
{
    public partial class Form1 : Form
    {
        //bool obn = false;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 10;
            for(int i = 0; i < 10;i++)
            {
                dataGridView1.Columns[i].Width = 30;
            }
            button1.MouseClick += Button1_MouseClick;
            button2.MouseClick += Button2_MouseClick;
        }

        private void Button2_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = "";
            int min;
            int temp;
            for (int i = 0; i < 10;i++)
            {
                min = (int)dataGridView1.Rows[0].Cells[i].Value;
                for(int j = 0; j<10;j++)
                {
                    temp = (int)dataGridView1.Rows[j].Cells[i].Value;
                    if (temp < min)
                        min = temp;
                }
                richTextBox1.Text += "В столбце " + (i+1) + " наим эл " + min + "\n";
            }
            
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            button2.Enabled = true;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    //Получить случайное число (в диапазоне от -100 до 100)

                    dataGridView1.Rows[i].Cells[j].Value = rnd.Next(-100, 100);
                }             
            }
        }
    }
}

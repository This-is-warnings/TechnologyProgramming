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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //listBox1.Items.Add(new Auto("1", "2", 3, 4));
            listBox1.SelectedValueChanged += ListBox1_SelectedValueChanged;
            //label1.Text = listBox1.SelectedIndex.ToString();
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void ListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (listBox1.Items.Count == 0 || listBox1.SelectedIndex == -1)
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else { button2.Enabled = true; button3.Enabled = true; }
            if(listBox1.SelectedIndex == -1)
            {
                label2.Text = "Элемент не выбран";
            }
            else
            {
                Auto a = listBox1.SelectedItem as Auto;
                label2.Text = "Название: " + a.mark_name + "\nФирма: " + a.firm_name + "\nРасход на 100км: " + a.rashod + "\nВес: " + a.ves;
            }
            //label1.Text = listBox1.SelectedIndex.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add a = new Add(this);
            a.Show();
            this.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Change a = new Change(this,(Auto)listBox1.SelectedItem);
            a.Show();
            this.Enabled = false;
        }
    }
    public class Auto
    {
        public string mark_name;
        public string firm_name;
        public double rashod;
        public int ves;
        public override string ToString()
        {
            // string s = mark_name + " " + firm_name + " " + rashod + " " + ves;
            string s = mark_name;
            return s;
        }
        public Auto(string m_name, string f_name, double Rashod, int Ves)
        {
            mark_name = m_name;
            firm_name = f_name;
            rashod = Rashod;
            ves = Ves;
        }
    }
   
}

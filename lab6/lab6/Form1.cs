using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripButton1.Click += ToolStripButton1_Click;
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            listBox1.SelectedValueChanged += ListBox1_SelectedValueChanged;
            toolStripStatusLabel1.Text = "Элемент не выбран";
            сохранитьToolStripMenuItem.Click += СохранитьToolStripMenuItem_Click;
            загрузитьToolStripMenuItem.Click += ЗагрузитьToolStripMenuItem_Click;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void ЗагрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // throw new NotImplementedException();
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                listBox1.Items.Clear();
                string filename = openFileDialog1.FileName;
                TextReader reader = new StreamReader(filename);
                string line;
                while (true)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        string[] mas = line.Split(' ');
                        listBox1.Items.Add(new Auto(mas[0], mas[1], double.Parse(mas[2]), int.Parse(mas[3])));
                    }
                    else break;
                }
                reader.Close();
                reader = null;
                toolStripStatusLabel1.Text = "Загружено";
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //throw new NotImplementedException();
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = saveFileDialog1.FileName;
                TextWriter writer = new StreamWriter(filename);
                foreach (Auto item in listBox1.Items)
                    writer.WriteLine(item.mark_name + " " + item.firm_name + " " + item.rashod + " " + item.ves);
                writer.Close();
                toolStripStatusLabel1.Text = "Сохранено";
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (listBox1.Items.Count == 0)
            {
                toolStripButton4.Enabled = false;
            }
            else toolStripButton4.Enabled = true;
            if (listBox1.Items.Count == 0 || listBox1.SelectedIndex == -1)
            {
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
            }
            else { toolStripButton2.Enabled = true; toolStripButton3.Enabled = true; }
            if (listBox1.SelectedIndex == -1)
            {
                toolStripStatusLabel1.Text = "Элемент не выбран";
            }
            else
            {
                Auto a = listBox1.SelectedItem as Auto;
                //toolStripStatusLabel1.Text = "Название: " + a.mark_name + "; Фирма: " + a.firm_name + "; Расход на 100км: " + a.rashod + "; Вес: " + a.ves;
                toolStripStatusLabel1.Text = a.mark_name + " " + a.firm_name + " " + a.rashod + " " + a.ves;
            }
            //label1.Text = listBox1.SelectedIndex.ToString();
        }
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Add a = new Add(this);
            a.Show();
            this.Enabled = false;
            label3.Text = "";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
            label3.Text = "";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Change a = new Change(this, (Auto)listBox1.SelectedItem);
            a.Show();
            this.Enabled = false;
            label3.Text = "";
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Auto a = (Auto)listBox1.Items[0];
            double min = a.rashod / a.ves;
            foreach(Auto item in listBox1.Items)
            {
                if (min > item.rashod / item.ves)
                {
                    a = item;
                    min = item.rashod / item.ves;
                }
            }
            label3.Text = a.mark_name + " " + a.firm_name +" "+ Math.Round(min,3);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создатель: Бобоед Виталий");
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

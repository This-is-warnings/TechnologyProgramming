using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            MouseMove += Form1_MouseMove; 
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           // label1.Text = "x = " + MousePosition.X + ", y = " + MousePosition.Y;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.Wheat);
            Pen pen = new Pen(Brushes.Black, 2);
            SolidBrush bruhBLACK = new SolidBrush(Color.Black);
            SolidBrush bruhWHITE = new SolidBrush(Color.White);
            g.FillPolygon(bruhWHITE, new Point[3] { new Point(385, 50), new Point(410, 35), new Point(410, 65) });
            g.DrawLine(pen, 20, 50, 510, 50);
            g.FillEllipse(bruhWHITE, 410, 330, 50, 50);
            g.DrawEllipse(pen, 410, 330, 50, 50);
            //---
            g.FillEllipse(bruhBLACK, 65, 45, 10, 10);
            g.DrawLine(pen, 70, 50, 70, 80);
            g.DrawLine(pen, 50, 80, 90, 80);
            g.DrawLine(pen, 50, 90, 90, 90);
            g.DrawLine(pen, 70, 90, 70, 140);
            g.DrawLine(pen, 55, 140, 85, 140);
            //----
            g.FillEllipse(bruhBLACK, 155, 45, 10, 10);
            g.DrawLine(pen, 160, 50, 160, 80);
            g.DrawLine(pen, 140, 80, 180, 80);
            g.DrawLine(pen, 140, 90, 180, 90);
            g.DrawLine(pen, 160, 90, 160, 140);
            g.DrawLine(pen, 145, 140, 175, 140);
            g.DrawLine(pen,175, 65, 175, 75);
            g.DrawLine(pen, 170, 70, 180, 70);
            //-----
            g.FillEllipse(bruhBLACK, 265, 45, 10, 10);
            //---
            g.DrawLine(pen, 385, 35, 385, 65);
            g.DrawPolygon(pen, new Point[3] { new Point(385, 50), new Point(410, 35), new Point(410, 65) });
            //вверху  g.FillPolygon(bruhWHITE, new Point[3] { new Point(385, 50), new Point(410, 35), new Point(410, 65)});
            g.DrawLine(pen, 510, 50, 500, 40);
            g.DrawLine(pen, 510, 50, 500, 60);
            //---
            g.FillEllipse(bruhWHITE,225, 70, 60, 60);
            g.DrawEllipse(pen, 225, 70, 60, 60);
            g.DrawLine(pen, 270, 50, 270, 75);
            g.DrawLine(pen, 245, 77, 245, 122);
            g.DrawLine(pen, 270, 75, 245, 90);
            g.DrawLine(pen, 245, 113, 270, 125);
            g.DrawLine(pen, 270, 125, 265, 120);
            g.DrawLine(pen, 270, 125, 263, 125);
            //--
            g.DrawLine(pen, 270, 125, 270, 155);
            //--
            g.FillEllipse(bruhWHITE, 225, 150, 60, 60);
            g.DrawEllipse(pen, 225, 150, 60, 60);
            g.DrawLine(pen, 270, 130, 270, 155);
            g.DrawLine(pen, 245, 157, 245, 202);
            g.DrawLine(pen, 270, 155, 245, 170);
            g.DrawLine(pen, 245, 193, 270, 205);
            g.DrawLine(pen, 245, 170, 249, 165);
            g.DrawLine(pen, 245, 170, 252, 168);
            //g.DrawLine(pen, 270, 205, 265, 200);
            //g.DrawLine(pen, 270, 205, 263, 205);
            g.DrawLine(pen, 270, 205, 270, 240);
            g.DrawLine(pen, 245, 180, 210, 180);
            //--
            g.DrawLine(pen, 245, 100, 210, 100);
            g.DrawLine(pen, 210, 100, 210, 340);
            g.FillEllipse(bruhBLACK, 205, 175, 10, 10);
            //----
            g.FillEllipse(bruhBLACK, 265, 135, 10, 10);
            g.DrawLine(pen, 270, 140, 340, 140);
            g.DrawLine(pen, 340, 120, 340, 160);
            g.DrawLine(pen, 350, 120, 350, 160);
            g.DrawLine(pen, 330, 121, 330, 131);
            g.DrawLine(pen, 325, 126, 335, 126);
            g.DrawLine(pen, 350, 140, 435, 140);
            g.DrawLine(pen, 435, 140, 435, 490);
            g.FillRectangle(bruhWHITE, 425, 160, 20, 50);
            g.DrawRectangle(pen, 425, 160, 20, 50);
            g.DrawLine(pen, 445, 185, 510, 185);
            g.DrawLine(pen, 445, 185, 450, 182);
            g.DrawLine(pen, 445, 185, 450, 187);
            g.DrawLine(pen, 510, 185, 500, 175);
            g.DrawLine(pen, 510, 185, 500, 195);
            //---
            g.DrawLine(pen, 435, 240, 20, 240);
            g.DrawLine(pen, 20, 50, 20, 240);
            g.FillEllipse(bruhBLACK, 430, 235, 10, 10);
            g.FillEllipse(bruhBLACK, 265, 235, 10, 10);
            g.FillRectangle(bruhWHITE, 100, 225, 40, 90);
            g.DrawRectangle(pen, 100, 225, 40, 90);
            g.DrawLine(pen, 100, 300, 80, 300);
            g.DrawLine(pen, 80, 300, 80, 340);
            g.DrawLine(pen, 80, 340, 210, 340);
            g.FillRectangle(bruhWHITE, 140, 330, 50, 20);
            g.DrawRectangle(pen, 140, 330, 50, 20);
            g.DrawLine(pen, 100, 270, 20, 270);
            g.DrawLine(pen, 20, 270, 20, 490);
            //-----
            g.DrawLine(pen, 20, 420, 310, 420);
            g.FillRectangle(bruhWHITE, 80, 410, 50, 20);
            g.DrawRectangle(pen, 80, 410, 50, 20);

            g.FillRectangle(bruhWHITE, 190, 410, 50, 20);
            g.DrawRectangle(pen, 190, 410, 50, 20);

            g.FillEllipse(bruhBLACK, 255, 415, 10, 10);

            g.DrawLine(pen, 260, 420, 260, 385);
            g.DrawLine(pen, 260, 385, 215, 385);
            g.DrawLine(pen, 215, 385, 215, 410);

            g.FillPolygon(bruhBLACK, new Point[3]  { new Point(215,410),new Point(220,400),new Point(210,400)});
            // g.DrawLine(pen, 215, 410, 220, 400);
            // g.DrawLine(pen, 215, 410, 210, 400);

            g.DrawLine(pen, 310, 420, 345, 400);
            //
            g.DrawLine(pen, 20, 490, 310, 490);
            g.FillRectangle(bruhWHITE, 80, 480, 50, 20);
            g.DrawRectangle(pen, 80, 480, 50, 20);

            g.FillRectangle(bruhWHITE, 190, 480, 50, 20);
            g.DrawRectangle(pen, 190, 480, 50, 20);

            g.FillEllipse(bruhBLACK, 255, 485, 10, 10);

            g.DrawLine(pen, 260, 490, 260, 455);
            g.DrawLine(pen, 260, 455, 215, 455);
            g.DrawLine(pen, 215, 455, 215, 480);

            g.FillPolygon(bruhBLACK, new Point[3] { new Point(215, 480), new Point(220, 470), new Point(210, 470) });
            g.DrawLine(pen, 310, 490, 345, 470);
            //---
            g.DrawLine(pen, 320, 415, 320, 485);
            g.DrawLine(pen, 330, 410, 330, 480);
            //----
            g.DrawLine(pen, 435, 490, 345, 490);
            g.DrawLine(pen, 360,490, 360, 420);
            g.DrawLine(pen, 360, 420, 345, 420);
            //
            g.FillRectangle(bruhWHITE, 425, 420, 20, 50);
            g.DrawRectangle(pen, 425, 420, 20, 50);
            //---
            // g.FillEllipse(bruhWHITE, 410, 330, 50, 50);
            //это вверху g.DrawEllipse(pen, 410, 330, 50, 50);
            g.DrawLine(pen, 420, 345, 450, 345);
            g.DrawPolygon(pen, new Point[3] { new Point(435, 345), new Point(420, 370), new Point(450, 370) });
            //--
            g.DrawLine(pen, 400, 330, 380, 310);
            g.FillPolygon(bruhBLACK, new Point[3] { new Point(380, 310), new Point(385, 310), new Point(380, 315) });
            g.DrawLine(pen, 410, 320, 390, 300);
            g.FillPolygon(bruhBLACK, new Point[3] { new Point(390, 300), new Point(395, 300), new Point(390, 305) });
            //текст
            g.DrawString("C1", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 80, 55);
            g.DrawString("C2", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 182, 60);
            g.DrawString("VT1", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 280, 57);
            g.DrawString("VD2", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 385, 10);
            g.DrawString("+5V", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 470, 15);
            g.DrawString("C3", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 350, 105);
            g.DrawString("VT2", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 280, 145);
            g.DrawString("R1", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 450, 145);
            g.DrawString("DD1.1", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 100, 200);
            g.DrawString("5", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 80, 220);
            g.DrawString("12", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 150, 220);
            g.DrawString("7", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 80, 250);
            g.DrawString("8", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 80, 280);
            g.DrawString("R2", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 150, 310);
            g.DrawString("R3", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 90, 380);
            g.DrawString("R4", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 90, 450);
            g.DrawString("R5", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 180, 380);
            g.DrawString("R6", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 180, 450);
            g.DrawString("SA1.1", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 360, 400);
            g.DrawString("R7", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 450, 420);
            g.DrawString("HL1", new Font("Arial", 12, FontStyle.Italic), bruhBLACK, 450, 315);
        }
    }
}

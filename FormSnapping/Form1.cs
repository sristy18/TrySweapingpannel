using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSnapping
{
    public partial class Form1 : Form
    {
        int x, y,temp;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }



        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            temp = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            temp = 0;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            temp = 2;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            temp = 0;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            temp = 3;
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            temp = 0;
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            temp = 4;
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            temp = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(temp==1)
            {
                panel1.Location = new Point(Cursor.Position.X-200, Cursor.Position.Y-200);
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (temp == 2)
            {
                panel2.Location = new Point(Cursor.Position.X - 200, Cursor.Position.Y - 200);
            }
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (temp == 3)
            {
                panel3.Location = new Point(Cursor.Position.X - 200, Cursor.Position.Y - 200);
            }
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (temp == 4)
            {
                panel4.Location = new Point(Cursor.Position.X - 200, Cursor.Position.Y - 200);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

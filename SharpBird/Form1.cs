using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpBird
{
    public partial class Form1 : Form
    {
        const int GateSize = 200;
        int speed = 0;
        int Points = 0;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                speed -= 35;
            }
        }

        public void Show_Points()
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            numPoints2.Visible = true;
            pictureBox2.Visible = true;
            numPoints2.Text = Convert.ToString(Points);          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            numPoints1.Text = Convert.ToString(Points);
             
            // bird gravity
            speed += 2;
            bird.Top += speed;

            // tube logic
            tube1.Left -= 4;
            tube2.Left -= 4;
            tube3.Left -= 4;
            tube4.Left -= 4;
            
            if ( tube1.Left <= -100 )
            {
                Form1_Load(null, null);
            }

            // PARALAx Logic
            fon1.Left -= 1;
            fon2.Left = fon1.Left + fon1.Width;
            if (fon1.Left<-fon1.Width)
            {               
                fon1.Left = 0;
            }
            // collision logic
            if (bird.Top < -bird.Height || bird.Top > Form1.ActiveForm.Height )
            {
                timer1.Enabled = false;
                Show_Points();
            }


            if (((bird.Top + bird.Width)>= tube1.Top) &&
                ((bird.Left + bird.Width)>= tube1.Left) &&
                ((bird.Left<(tube1.Left + tube1.Width))))
            {
                timer1.Enabled = false;
                Show_Points();
            }

            if (((bird.Top) <    tube2.Top+ tube2.Height) &&
              ((bird.Left + bird.Width) >= tube2.Left) &&
              ((bird.Left < (tube2.Left + tube2.Width))))
            {
                timer1.Enabled = false;
                Show_Points();
            }

            if (bird.Left == tube1.Left + tube1.Width)
            {
                Points++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tube1.Left = 500;
            tube1.Top = rnd.Next(GateSize + 50, 320);

            tube2.Left = tube1.Left;
            tube2.Top = tube1.Top - tube2.Height - GateSize;


            tube3.Left = tube1.Left;
            tube3.Top = tube1.Top;
            tube4.Left = tube2.Left;
            tube4.Top = tube2.Top+ tube2.Height-12 ;
        }

        private void tube2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            numPoints2.Visible = false;
            pictureBox2.Visible = false;
            timer1.Enabled = true;
            bird.Top = 10;
            speed = 0;
            Points = 0;
            tube1.Left = 500;
            tube2.Left = 500;
            tube3.Left = 500;
            tube4.Left = 500;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
